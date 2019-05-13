namespace ProxHarvester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listviewProxies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.formSkin1 = new FlatUI.FormSkin();
            this.btnStop = new Bunifu.Framework.UI.BunifuTileButton();
            this.flatMini1 = new FlatUI.FlatMini();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.flatGroupBox1 = new FlatUI.FlatGroupBox();
            this.lblState = new FlatUI.FlatLabel();
            this.flatLabel6 = new FlatUI.FlatLabel();
            this.lblProxiesAdded = new FlatUI.FlatLabel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.btnHarvest = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClean = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnExport = new Bunifu.Framework.UI.BunifuTileButton();
            this.flatClose1 = new FlatUI.FlatClose();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.flatGroupBox2 = new FlatUI.FlatGroupBox();
            this.txtPortFilter = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.checkPortFilter = new FlatUI.FlatCheckBox();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.combServer = new System.Windows.Forms.ComboBox();
            this.formSkin1.SuspendLayout();
            this.flatGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listviewProxies
            // 
            this.listviewProxies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.listviewProxies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listviewProxies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listviewProxies.ForeColor = System.Drawing.Color.White;
            this.listviewProxies.FullRowSelect = true;
            this.listviewProxies.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listviewProxies.Location = new System.Drawing.Point(151, 74);
            this.listviewProxies.Name = "listviewProxies";
            this.listviewProxies.Size = new System.Drawing.Size(276, 400);
            this.listviewProxies.TabIndex = 0;
            this.listviewProxies.UseCompatibleStateImageBehavior = false;
            this.listviewProxies.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Address";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Port";
            this.columnHeader2.Width = 100;
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.combServer);
            this.formSkin1.Controls.Add(this.flatLabel2);
            this.formSkin1.Controls.Add(this.flatGroupBox2);
            this.formSkin1.Controls.Add(this.btnStop);
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Controls.Add(this.txtLog);
            this.formSkin1.Controls.Add(this.flatGroupBox1);
            this.formSkin1.Controls.Add(this.checkPortFilter);
            this.formSkin1.Controls.Add(this.txtPortFilter);
            this.formSkin1.Controls.Add(this.btnHarvest);
            this.formSkin1.Controls.Add(this.btnClean);
            this.formSkin1.Controls.Add(this.btnExport);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Controls.Add(this.listviewProxies);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(131)))), ((int)(((byte)(133)))));
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(901, 495);
            this.formSkin1.TabIndex = 2;
            this.formSkin1.Text = "ProxHarvester";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStop.color = System.Drawing.Color.SeaGreen;
            this.btnStop.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImagePosition = 9;
            this.btnStop.ImageZoom = 50;
            this.btnStop.LabelPosition = 32;
            this.btnStop.LabelText = "Stop";
            this.btnStop.Location = new System.Drawing.Point(30, 189);
            this.btnStop.Margin = new System.Windows.Forms.Padding(6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(94, 87);
            this.btnStop.TabIndex = 22;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(845, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 21;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(172)))), ((int)(((byte)(173)))));
            this.txtLog.Location = new System.Drawing.Point(446, 300);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(432, 174);
            this.txtLog.TabIndex = 20;
            this.txtLog.Text = "";
            // 
            // flatGroupBox1
            // 
            this.flatGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatGroupBox1.Controls.Add(this.lblState);
            this.flatGroupBox1.Controls.Add(this.flatLabel6);
            this.flatGroupBox1.Controls.Add(this.lblProxiesAdded);
            this.flatGroupBox1.Controls.Add(this.flatLabel1);
            this.flatGroupBox1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.flatGroupBox1.Location = new System.Drawing.Point(446, 184);
            this.flatGroupBox1.Name = "flatGroupBox1";
            this.flatGroupBox1.ShowText = true;
            this.flatGroupBox1.Size = new System.Drawing.Size(432, 107);
            this.flatGroupBox1.TabIndex = 19;
            this.flatGroupBox1.Text = "Progression Status";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(75, 76);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(44, 21);
            this.lblState.TabIndex = 16;
            this.lblState.Text = "Idle...";
            // 
            // flatLabel6
            // 
            this.flatLabel6.AutoSize = true;
            this.flatLabel6.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatLabel6.ForeColor = System.Drawing.Color.White;
            this.flatLabel6.Location = new System.Drawing.Point(75, 57);
            this.flatLabel6.Name = "flatLabel6";
            this.flatLabel6.Size = new System.Drawing.Size(43, 19);
            this.flatLabel6.TabIndex = 15;
            this.flatLabel6.Text = "State:";
            // 
            // lblProxiesAdded
            // 
            this.lblProxiesAdded.AutoSize = true;
            this.lblProxiesAdded.BackColor = System.Drawing.Color.Transparent;
            this.lblProxiesAdded.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblProxiesAdded.ForeColor = System.Drawing.Color.White;
            this.lblProxiesAdded.Location = new System.Drawing.Point(262, 76);
            this.lblProxiesAdded.Name = "lblProxiesAdded";
            this.lblProxiesAdded.Size = new System.Drawing.Size(19, 21);
            this.lblProxiesAdded.TabIndex = 14;
            this.lblProxiesAdded.Text = "0";
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(262, 57);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(88, 19);
            this.flatLabel1.TabIndex = 13;
            this.flatLabel1.Text = "Total Proxies:";
            // 
            // btnHarvest
            // 
            this.btnHarvest.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHarvest.color = System.Drawing.Color.SeaGreen;
            this.btnHarvest.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnHarvest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHarvest.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnHarvest.ForeColor = System.Drawing.Color.White;
            this.btnHarvest.Image = ((System.Drawing.Image)(resources.GetObject("btnHarvest.Image")));
            this.btnHarvest.ImagePosition = 9;
            this.btnHarvest.ImageZoom = 50;
            this.btnHarvest.LabelPosition = 32;
            this.btnHarvest.LabelText = "Harvest";
            this.btnHarvest.Location = new System.Drawing.Point(30, 94);
            this.btnHarvest.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnHarvest.Name = "btnHarvest";
            this.btnHarvest.Size = new System.Drawing.Size(94, 91);
            this.btnHarvest.TabIndex = 14;
            this.btnHarvest.Click += new System.EventHandler(this.btnHarvest_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.SeaGreen;
            this.btnClean.color = System.Drawing.Color.SeaGreen;
            this.btnClean.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.Enabled = false;
            this.btnClean.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Image = ((System.Drawing.Image)(resources.GetObject("btnClean.Image")));
            this.btnClean.ImagePosition = 9;
            this.btnClean.ImageZoom = 50;
            this.btnClean.LabelPosition = 32;
            this.btnClean.LabelText = "Clean";
            this.btnClean.Location = new System.Drawing.Point(30, 280);
            this.btnClean.Margin = new System.Windows.Forms.Padding(5);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(94, 86);
            this.btnClean.TabIndex = 13;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.SeaGreen;
            this.btnExport.color = System.Drawing.Color.SeaGreen;
            this.btnExport.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Enabled = false;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImagePosition = 9;
            this.btnExport.ImageZoom = 50;
            this.btnExport.LabelPosition = 32;
            this.btnExport.LabelText = "Export";
            this.btnExport.Location = new System.Drawing.Point(30, 370);
            this.btnExport.Margin = new System.Windows.Forms.Padding(6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(94, 87);
            this.btnExport.TabIndex = 5;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(869, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 2;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text Files | *.txt";
            this.saveFileDialog1.Title = "Save Proxy List";
            // 
            // flatGroupBox2
            // 
            this.flatGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatGroupBox2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.flatGroupBox2.Location = new System.Drawing.Point(446, 54);
            this.flatGroupBox2.Name = "flatGroupBox2";
            this.flatGroupBox2.ShowText = true;
            this.flatGroupBox2.Size = new System.Drawing.Size(432, 47);
            this.flatGroupBox2.TabIndex = 23;
            this.flatGroupBox2.Text = "Options";
            // 
            // txtPortFilter
            // 
            this.txtPortFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPortFilter.Enabled = false;
            this.txtPortFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPortFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPortFilter.HintForeColor = System.Drawing.Color.Empty;
            this.txtPortFilter.HintText = "";
            this.txtPortFilter.isPassword = false;
            this.txtPortFilter.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(177)))), ((int)(((byte)(143)))));
            this.txtPortFilter.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPortFilter.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(177)))), ((int)(((byte)(143)))));
            this.txtPortFilter.LineThickness = 4;
            this.txtPortFilter.Location = new System.Drawing.Point(610, 149);
            this.txtPortFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtPortFilter.Name = "txtPortFilter";
            this.txtPortFilter.Size = new System.Drawing.Size(268, 29);
            this.txtPortFilter.TabIndex = 15;
            this.txtPortFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPortFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPortFilter_KeyPress);
            // 
            // checkPortFilter
            // 
            this.checkPortFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.checkPortFilter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.checkPortFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.checkPortFilter.Checked = false;
            this.checkPortFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkPortFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkPortFilter.Location = new System.Drawing.Point(446, 153);
            this.checkPortFilter.Name = "checkPortFilter";
            this.checkPortFilter.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.checkPortFilter.Size = new System.Drawing.Size(157, 22);
            this.checkPortFilter.TabIndex = 18;
            this.checkPortFilter.Text = "Filter proxies with port:";
            this.checkPortFilter.CheckedChanged += new FlatUI.FlatCheckBox.CheckedChangedEventHandler(this.checkPortFilter_CheckedChanged);
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(443, 117);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(89, 19);
            this.flatLabel2.TabIndex = 24;
            this.flatLabel2.Text = "Select Server:";
            // 
            // combServer
            // 
            this.combServer.FormattingEnabled = true;
            this.combServer.Items.AddRange(new object[] {
            "http://www.proxyserverlist24.top/",
            "http://www.sslproxies24.top/",
            "http://proxy-daily.com/",
            "http://newfreshproxies-24.blogspot.com/",
            "https://www.hide-my-ip.com/",
            "All Servers (Slow)"});
            this.combServer.Location = new System.Drawing.Point(541, 112);
            this.combServer.Name = "combServer";
            this.combServer.Size = new System.Drawing.Size(337, 29);
            this.combServer.TabIndex = 1;
            this.combServer.Text = "http://www.proxyserverlist24.top/";
            this.combServer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combServer_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 495);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.flatGroupBox1.ResumeLayout(false);
            this.flatGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listviewProxies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatClose flatClose1;
        private Bunifu.Framework.UI.BunifuTileButton btnExport;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuTileButton btnClean;
        private Bunifu.Framework.UI.BunifuTileButton btnHarvest;
        private FlatUI.FlatGroupBox flatGroupBox1;
        private FlatUI.FlatLabel lblState;
        private FlatUI.FlatLabel flatLabel6;
        private FlatUI.FlatLabel lblProxiesAdded;
        private FlatUI.FlatLabel flatLabel1;
        private System.Windows.Forms.RichTextBox txtLog;
        private FlatUI.FlatMini flatMini1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Bunifu.Framework.UI.BunifuTileButton btnStop;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatGroupBox flatGroupBox2;
        private FlatUI.FlatCheckBox checkPortFilter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPortFilter;
        private System.Windows.Forms.ComboBox combServer;



    }
}

