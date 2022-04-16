namespace GroupDocs.Viewer.Forms.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.webBrowerMain = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openFileBtn = new System.Windows.Forms.ToolStripButton();
            this.firstPageBtn = new System.Windows.Forms.ToolStripButton();
            this.prevPageBtn = new System.Windows.Forms.ToolStripButton();
            this.pagesStatusLabel = new System.Windows.Forms.ToolStripLabel();
            this.nextPageBtn = new System.Windows.Forms.ToolStripButton();
            this.lastPageBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.licenseStatusLabel = new System.Windows.Forms.ToolStripLabel();
            this.transparentBackgroundColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueBackgroundColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redBackgroundColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteBackgroundColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEvents = new System.Windows.Forms.Button();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allowExternalDropMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acceleratorKeysEnabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webView2Control = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView2Control)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowerMain
            // 
            this.webBrowerMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowerMain.Location = new System.Drawing.Point(-8, 42);
            this.webBrowerMain.Margin = new System.Windows.Forms.Padding(3, 39, 3, 3);
            this.webBrowerMain.MinimumSize = new System.Drawing.Size(20, 39);
            this.webBrowerMain.Name = "webBrowerMain";
            this.webBrowerMain.Size = new System.Drawing.Size(878, 296);
            this.webBrowerMain.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileBtn,
            this.firstPageBtn,
            this.prevPageBtn,
            this.pagesStatusLabel,
            this.nextPageBtn,
            this.lastPageBtn,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.licenseStatusLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(870, 39);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openFileBtn
            // 
            this.openFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFileBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openFileBtn.Image = global::GroupsDocs.Viewer.Forms.UI.Properties.Resources.open_file;
            this.openFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(36, 36);
            this.openFileBtn.Text = "Open file";
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // firstPageBtn
            // 
            this.firstPageBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.firstPageBtn.Image = global::GroupsDocs.Viewer.Forms.UI.Properties.Resources.first;
            this.firstPageBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.firstPageBtn.Name = "firstPageBtn";
            this.firstPageBtn.Size = new System.Drawing.Size(36, 36);
            this.firstPageBtn.Text = "First page";
            this.firstPageBtn.Click += new System.EventHandler(this.FirstPageBtn_Click);
            // 
            // prevPageBtn
            // 
            this.prevPageBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prevPageBtn.Image = global::GroupsDocs.Viewer.Forms.UI.Properties.Resources.prev;
            this.prevPageBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prevPageBtn.Name = "prevPageBtn";
            this.prevPageBtn.Size = new System.Drawing.Size(36, 36);
            this.prevPageBtn.Text = "Previous page";
            this.prevPageBtn.Click += new System.EventHandler(this.PrevPageBtn_Click);
            // 
            // pagesStatusLabel
            // 
            this.pagesStatusLabel.Name = "pagesStatusLabel";
            this.pagesStatusLabel.Size = new System.Drawing.Size(22, 36);
            this.pagesStatusLabel.Text = "     ";
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextPageBtn.Image = global::GroupsDocs.Viewer.Forms.UI.Properties.Resources.next;
            this.nextPageBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(36, 36);
            this.nextPageBtn.Text = "Next page";
            this.nextPageBtn.Click += new System.EventHandler(this.NextPageBtn_Click);
            // 
            // lastPageBtn
            // 
            this.lastPageBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lastPageBtn.Image = global::GroupsDocs.Viewer.Forms.UI.Properties.Resources.last;
            this.lastPageBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lastPageBtn.Name = "lastPageBtn";
            this.lastPageBtn.Size = new System.Drawing.Size(36, 36);
            this.lastPageBtn.Text = "Last page";
            this.lastPageBtn.Click += new System.EventHandler(this.LastPageBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(83, 36);
            this.toolStripLabel2.Text = "License status:";
            // 
            // licenseStatusLabel
            // 
            this.licenseStatusLabel.Name = "licenseStatusLabel";
            this.licenseStatusLabel.Size = new System.Drawing.Size(73, 36);
            this.licenseStatusLabel.Text = "Not licensed";
            // 
            // transparentBackgroundColorMenuItem
            // 
            this.transparentBackgroundColorMenuItem.Name = "transparentBackgroundColorMenuItem";
            this.transparentBackgroundColorMenuItem.Size = new System.Drawing.Size(135, 22);
            this.transparentBackgroundColorMenuItem.Text = "Transparent";
            // 
            // blueBackgroundColorMenuItem
            // 
            this.blueBackgroundColorMenuItem.Name = "blueBackgroundColorMenuItem";
            this.blueBackgroundColorMenuItem.Size = new System.Drawing.Size(135, 22);
            this.blueBackgroundColorMenuItem.Text = "Blue";
            // 
            // redBackgroundColorMenuItem
            // 
            this.redBackgroundColorMenuItem.Name = "redBackgroundColorMenuItem";
            this.redBackgroundColorMenuItem.Size = new System.Drawing.Size(135, 22);
            this.redBackgroundColorMenuItem.Text = "Red";
            // 
            // whiteBackgroundColorMenuItem
            // 
            this.whiteBackgroundColorMenuItem.Name = "whiteBackgroundColorMenuItem";
            this.whiteBackgroundColorMenuItem.Size = new System.Drawing.Size(135, 22);
            this.whiteBackgroundColorMenuItem.Text = "White";
            // 
            // backgroundColorMenuItem
            // 
            this.backgroundColorMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteBackgroundColorMenuItem,
            this.redBackgroundColorMenuItem,
            this.blueBackgroundColorMenuItem,
            this.transparentBackgroundColorMenuItem});
            this.backgroundColorMenuItem.Name = "backgroundColorMenuItem";
            this.backgroundColorMenuItem.Size = new System.Drawing.Size(170, 22);
            this.backgroundColorMenuItem.Text = "Background Color";
            // 
            // xToolStripMenuItem3
            // 
            this.xToolStripMenuItem3.Name = "xToolStripMenuItem3";
            this.xToolStripMenuItem3.Size = new System.Drawing.Size(160, 22);
            this.xToolStripMenuItem3.Text = "Get ZoomFactor";
            // 
            // xToolStripMenuItem2
            // 
            this.xToolStripMenuItem2.Name = "xToolStripMenuItem2";
            this.xToolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.xToolStripMenuItem2.Text = "2.0x";
            // 
            // xToolStripMenuItem1
            // 
            this.xToolStripMenuItem1.Name = "xToolStripMenuItem1";
            this.xToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.xToolStripMenuItem1.Text = "1.0x";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.xToolStripMenuItem.Text = "0.5x";
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(790, 386);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(75, 23);
            this.btnEvents.TabIndex = 18;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem,
            this.xToolStripMenuItem1,
            this.xToolStripMenuItem2,
            this.xToolStripMenuItem3});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // allowExternalDropMenuItem
            // 
            this.allowExternalDropMenuItem.Checked = true;
            this.allowExternalDropMenuItem.CheckOnClick = true;
            this.allowExternalDropMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allowExternalDropMenuItem.Name = "allowExternalDropMenuItem";
            this.allowExternalDropMenuItem.Size = new System.Drawing.Size(217, 22);
            this.allowExternalDropMenuItem.Text = "AllowExternalDrop Enabled";
            // 
            // acceleratorKeysEnabledToolStripMenuItem
            // 
            this.acceleratorKeysEnabledToolStripMenuItem.Checked = true;
            this.acceleratorKeysEnabledToolStripMenuItem.CheckOnClick = true;
            this.acceleratorKeysEnabledToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.acceleratorKeysEnabledToolStripMenuItem.Name = "acceleratorKeysEnabledToolStripMenuItem";
            this.acceleratorKeysEnabledToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.acceleratorKeysEnabledToolStripMenuItem.Text = "AcceleratorKeys Enabled";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceleratorKeysEnabledToolStripMenuItem,
            this.allowExternalDropMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(715, 386);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 17;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(338, 386);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(371, 20);
            this.txtUrl.TabIndex = 16;
            this.txtUrl.Text = "https://www.bing.com/";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(257, 386);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(176, 386);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnForward
            // 
            this.btnForward.Enabled = false;
            this.btnForward.Location = new System.Drawing.Point(95, 386);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 23);
            this.btnForward.TabIndex = 13;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(14, 386);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 358);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(108, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.backgroundColorMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // webView2Control
            // 
            this.webView2Control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView2Control.CreationProperties = null;
            this.webView2Control.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2Control.Location = new System.Drawing.Point(2, 414);
            this.webView2Control.Margin = new System.Windows.Forms.Padding(2);
            this.webView2Control.Name = "webView2Control";
            this.webView2Control.Size = new System.Drawing.Size(868, 296);
            this.webView2Control.Source = new System.Uri("https://www.bing.com/", System.UriKind.Absolute);
            this.webView2Control.TabIndex = 20;
            this.webView2Control.ZoomFactor = 1D;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 710);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.webView2Control);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.webBrowerMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(839, 744);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewer for .NET Windows Forms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView2Control)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowerMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openFileBtn;
        private System.Windows.Forms.ToolStripButton firstPageBtn;
        private System.Windows.Forms.ToolStripButton prevPageBtn;
        private System.Windows.Forms.ToolStripButton nextPageBtn;
        private System.Windows.Forms.ToolStripButton lastPageBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel licenseStatusLabel;
        private System.Windows.Forms.ToolStripLabel pagesStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem transparentBackgroundColorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueBackgroundColorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redBackgroundColorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteBackgroundColorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allowExternalDropMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acceleratorKeysEnabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2Control;
    }
}

