using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.IO;
using System.Text.RegularExpressions;

namespace ProxHarvester
{
    public partial class Form1 : Form
    {
        private List<string> lstProxies = new List<string>();
        private HtmlWeb web = new HtmlWeb();
        public delegate void _UpdateListview(ListViewItem proxy);
        public delegate void _UpdateLog(string line);
        private Object proxlistaccess = new Object();
        private Object logaccess = new Object();
        private Object lstProxiesAccess = new Object();
        private Object proxiesCantAccess = new Object();
        private int threads = 0;
        private int proxiesfound = 0;
        private bool stop_threads = false;
        List<string> sources = new List<string> { "http://www.proxyserverlist24.top/", 
                                                  "http://www.sslproxies24.top/", 
                                                  "http://proxy-daily.com/", 
                                                  "http://newfreshproxies-24.blogspot.com/",
                                                  "https://www.hide-my-ip.com/proxylist.shtml"};

        public static void SetDoubleBuffering(System.Windows.Forms.Control control, bool value)
        {
            System.Reflection.PropertyInfo controlProperty = typeof(System.Windows.Forms.Control)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            controlProperty.SetValue(control, value, null);
        }

        public Form1()
        {
            InitializeComponent();
            SetDoubleBuffering(listviewProxies, true);
            combServer.ContextMenu = new ContextMenu();
            combServer.SelectedIndex = 0;
        }

        private void harvestproxydaily(HtmlAgilityPack.HtmlDocument doc, string url)
        {
            List<string> webproxyList = new List<string>();

            HtmlNodeCollection node = doc.DocumentNode.SelectNodes("//div//div//h2//a"); // get posts links 
            if (node != null && node.Count == 0)                  
            {
                UpdateLog("Links not found...");
                return;
            }

            var posts = node.Select(n => n.Attributes[0].Value);            
            foreach (var post in posts)
            {
                if (stop_threads)
                {
                    threads--;
                    return;
                }

                HtmlAgilityPack.HtmlDocument link;
                try
                {
                    link = web.Load(post);
                }
                catch (Exception ex)
                {
                    --threads;
                    UpdateLog("Error: " + ex.Message);
                    return;
                }

                node = link.DocumentNode.SelectNodes("//div//div//p//text()"); 
                if (node == null || node.Count == 0)
                {
                    UpdateLog("Proxy list not found in: " + post);
                    continue;
                }

                foreach (var item in node)
                    webproxyList.Add(item.InnerText.Trim());
            }

            SanitizeProxyList(ref webproxyList);
            // filter by port
            ProcessPortFilter(ref webproxyList);
            // update global list
            lstProxies.AddRange(webproxyList);

            UpdateLog("Adding proxy list from: " + url);
            foreach (var item in webproxyList)
            {
                if (stop_threads)
                {
                    threads--;
                    return;
                }

                string[] tokens = item.Split(':');
                ListViewItem proxy = new ListViewItem();
                if (tokens.Length > 1 && !tokens.Contains(""))
                {
                    proxy.Text = tokens[0];
                    proxy.SubItems.Add(tokens[1]);

                    UpdateProxiesList(proxy);
                    proxiesfound++;
                }
                Thread.Sleep(5);
            }

            UpdateLog("Done with: " + url);
            --threads;
        }

        private void harvesthidemyip(string url)
        {
            List<string> webproxyList = new List<string>();

            string html = "";
            try
            {
                html = new System.Net.WebClient
                {
                    Proxy = null
                }.DownloadString(url);
            }
            catch (Exception ex)
            {
                --threads;
                UpdateLog("Error: " + ex.Message);
                return;
            }

            string keystart = "var json =";
            string keyend = "<!-- proxylist -->";
            var start = html.IndexOf(keystart) + keystart.Length;
            string jsonProxyList = html.Substring(start, html.IndexOf(keyend) - start);

            List<string> chunks = jsonProxyList.Split(',').ToList();
            List<string> proxies = new List<string>();
            for (int i = 0; i < chunks.Count; i++)
			{
                string line = chunks[i];
                int startl = line.IndexOf("[{\"i\":\"") + 7;
                string address = line.Substring(startl, line.Length - startl - 1);
                address = address.TrimStart('"');
                if (address.Length > 0)
                {
                    string line2 = chunks[i + 1];
                    int startr = line2.IndexOf("\"p\":\"") + 5;
                    string port = line2.Substring(startr, line2.Length - startr - 1);
                    if (port.Length > 0)
                    {
                        address += ":" + port;
                        webproxyList.Add(address);
                        i += 7; // skip the rest
                    }
                }
            }

            // sanitize strings by IP:PORT
            SanitizeProxyList(ref webproxyList);
            // filter by port
            ProcessPortFilter(ref webproxyList);
            // update global list
            lstProxies.AddRange(webproxyList);

            UpdateLog("Adding proxy list from: " + url);
            foreach (var item in webproxyList)
            {
                if (stop_threads)
                {
                    threads--;
                    return;
                }

                string[] tokens = item.Split(':');
                ListViewItem proxy = new ListViewItem();
                if (tokens.Length > 1 && !tokens.Contains(""))
                {
                    proxy.Text = tokens[0];
                    proxy.SubItems.Add(tokens[1]);

                    UpdateProxiesList(proxy);
                    proxiesfound++;
                }
                Thread.Sleep(5);
            }

            UpdateLog("Done with: " + url);
            --threads;

        }

        private void harvestnewfreshproxies24(HtmlAgilityPack.HtmlDocument doc, string url)
        {
            harvestproxyserverlist24(doc, url); // same scheme
        }

        private void harvestsslproxies24(HtmlAgilityPack.HtmlDocument doc, string url)
        {
            harvestproxyserverlist24(doc, url); // same scheme
        }

        private void ProcessPortFilter(ref List<string> webproxyList)
        {
            if (checkPortFilter.Checked)
            {
                webproxyList = webproxyList.FindAll(line =>
                {
                    string[] tokens = line.Split(':');
                    string[] ports = txtPortFilter.Text.Split(';');
                    foreach (var port in ports)
                    {
                        if (tokens.Contains(port))
                            return true;
                    }
                    return false;
                });
            }
        }

        private void SanitizeProxyList(ref List<string> proxList)
        {
            Regex regex = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}:\d{1,5}$");

            proxList = proxList.FindAll(line => 
            {
                string proxy = line.Trim();
                Match match = regex.Match(proxy);
                return (match.Success);
            });
        }

        public void harvestproxyserverlist24(HtmlAgilityPack.HtmlDocument doc, string url)
        {
            List<string> webproxyList = new List<string>();

            HtmlNodeCollection node = doc.DocumentNode.SelectNodes("//*[@id=\"Blog1\"]//div//div//div//div//div//h3//a"); // get posts links
            if (node != null && node.Count == 0)
            {
                UpdateLog("Links not found...");
                return;
            }

            var posts = node.Select(n => n.Attributes[0].Value);
            foreach (var post in posts)
            {
                if (stop_threads)
                {
                    threads--;
                    return;
                }

                HtmlAgilityPack.HtmlDocument link;
                try
                {
                    link = web.Load(post);
                }
                catch (Exception ex)
                {
                    --threads;
                    UpdateLog("Error: " + ex.Message);
                    return;
                }

                node = link.DocumentNode.SelectNodes("//pre//span//span//text()");
                if (node == null || node.Count == 0)
                {
                    UpdateLog("Proxy list not found in: " + post);
                    continue;
                }

                foreach (var item in node)
                    webproxyList.AddRange(item.InnerText.Split('\n').ToList());
            }

            // sanitize strings by IP:PORT
            SanitizeProxyList(ref webproxyList);
            // filter by port
            ProcessPortFilter(ref webproxyList);
            // update global list
            lstProxies.AddRange(webproxyList);

            UpdateLog("Adding proxy list from: " + url);
            foreach (var item in webproxyList)
            {
                if (stop_threads)
                {
                    threads--;
                    return;
                }

                string[] tokens = item.Split(':');
                ListViewItem proxy = new ListViewItem();
                if (tokens.Length > 1 && !tokens.Contains(""))
                {
                    proxy.Text = tokens[0];
                    proxy.SubItems.Add(tokens[1]);

                    UpdateProxiesList(proxy);
                    proxiesfound++;
                }
                Thread.Sleep(5);
            }

            UpdateLog("Done with: " + url);
            --threads;
        }

        private void HarvestProxies(string url)
        {
            HtmlAgilityPack.HtmlDocument doc;

            try{
                UpdateLog("Loading URL: " + url);
                doc = web.Load(url);
            }
            catch (Exception ex)
            {
                --threads;
                UpdateLog("Error: " + ex.Message);
                return;
            }

            switch(sources.IndexOf(url))
            {
                case 0:
                    harvestproxyserverlist24(doc, url);
                    break;
                case 1:
                    harvestsslproxies24(doc, url);
                    break;
                case 2:
                    harvestproxydaily(doc, url);
                    break;
                case 3:
                    harvestnewfreshproxies24(doc, url);
                    break;
                case 4:
                    harvesthidemyip(url);
                    break;
            }            
        }

        private void UpdateLog(string line)
        {
            if (!txtLog.InvokeRequired)
            {
                lock (logaccess)
                    txtLog.AppendText(DateTime.Now.ToString("hh:mm:ss") + "    " + line + Environment.NewLine);
            }
            else
                this.Invoke(new Form1._UpdateLog(this.UpdateLog), new object[] { line });
        }

        private void UpdateProxiesList(ListViewItem proxy)
        {            
            if (!listviewProxies.InvokeRequired)
            {
                lock (proxlistaccess)
                    listviewProxies.Items.Add(proxy);
            }
            else
                this.Invoke(new Form1._UpdateListview(this.UpdateProxiesList), new object[] { proxy });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblProxiesAdded.Text = Convert.ToString(proxiesfound);
            if(threads == 0)
            {
                btnClean.Enabled = btnExport.Enabled = btnHarvest.Enabled = true;
                lblProxiesAdded.Text = Convert.ToString(lstProxies.Count);
                lblState.Text = "Done!";
                UpdateLog("-------------------------------------------------");
                UpdateLog("Total Proxies: " + lblProxiesAdded.Text);
                UpdateLog(lblState.Text);
                timer1.Enabled = btnStop.Enabled = false;
            }
        }

        private void btnHarvest_Click(object sender, EventArgs e)
        {
            btnHarvest.Enabled = false;
            btnStop.Enabled = timer1.Enabled = true;
            proxiesfound = 0;
            stop_threads = false;

            listviewProxies.Items.Clear();
            lstProxies.Clear();

            lblState.Text = "Harvesting proxies...";
            UpdateLog(lblState.Text);
            UpdateLog("-------------------------------------------------");

            int selected = combServer.SelectedIndex;
            if (selected == combServer.Items.Count - 1) // if go over all servers
            {
                ThreadPool.SetMaxThreads(sources.Count, sources.Count);
                // one task for every source
                foreach (var url in sources)
                {
                    ThreadPool.QueueUserWorkItem((thr) => HarvestProxies(url));
                    threads++;
                }
            }
            else
            {
                ThreadPool.SetMaxThreads(1, 1);
                ThreadPool.QueueUserWorkItem((thr) => HarvestProxies(sources[selected]));
                threads++;
            }
        }

        private void txtPortFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ';')
                e.Handled = true;
        }

        private void checkPortFilter_CheckedChanged(object sender)
        {
            txtPortFilter.Enabled = checkPortFilter.Checked;
        }

        private void CleanList()
        {
            UpdateLog("-------------------------------------------------");
            UpdateLog("Cleaning the proxy list...");
            
            // removing duplicates
            lstProxies = lstProxies.Distinct().ToList();

            // removing blanks
            for (int i = 0; i < lstProxies.Count; i++)
            {
                string line = lstProxies[i];
                if (line.Length == 0) // if line is blank then remove it
                {
                    lstProxies.RemoveAt(i);
                    --i; // move index down
                }
                else
                {
                    string[] tokens = line.Split(':');
                    if (tokens.Contains("") || tokens.Contains(" ")) // if any part is blank then remove it
                    {
                        lstProxies.RemoveAt(i);
                        --i; // move index down
                    }
                }
            }

            // filter using regex for IP:PORT


            --threads;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lblState.Text = ("Cleaning the list...");
            threads++;
            timer1.Enabled = true;
            Thread cleanListThread = new Thread(() => CleanList());
            cleanListThread.Start();

        }

        private void SaveProxyListFile(string path)
        {
            try
            {
                File.WriteAllLines(path, lstProxies.ToArray());
                UpdateLog("-------------------------------------------------");
                UpdateLog("Exported " + lblProxiesAdded.Text + " proxies");
                UpdateLog("File successfully saved as: " + path);
            }
            catch (System.Exception ex)
            {
                UpdateLog("Error: " + ex.Message + "\nThe file could not be saved");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                SaveProxyListFile(saveFileDialog1.FileName);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            UpdateLog("-------------------------------------------------");
            lblState.Text = "Terminating all threads...";
            UpdateLog(lblState.Text);
            stop_threads = true;

            btnStop.Enabled = false;
            btnHarvest.Enabled = btnExport.Enabled = btnClean.Enabled = true;
        }

        private void combServer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
