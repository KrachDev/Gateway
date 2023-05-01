
namespace Gateway
{
    partial class GameBrowse
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Mainpanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.mainPanelHome = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitBTN = new Guna.UI2.WinForms.Guna2Button();
            this.DragBTN = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Shortpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.WebBckButton = new Guna.UI2.WinForms.Guna2Button();
            this.BrowserWb = new Diga.WebView2.WinForms.WebView();
            this.Mainpanel.SuspendLayout();
            this.mainPanelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Mainpanel
            // 
            this.Mainpanel.Controls.Add(this.BrowserWb);
            this.Mainpanel.Controls.Add(this.mainPanelHome);
            this.Mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mainpanel.FillColor = System.Drawing.Color.Indigo;
            this.Mainpanel.FillColor2 = System.Drawing.Color.Black;
            this.Mainpanel.FillColor3 = System.Drawing.Color.Indigo;
            this.Mainpanel.FillColor4 = System.Drawing.Color.Black;
            this.Mainpanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Mainpanel.Location = new System.Drawing.Point(0, 0);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.ShadowDecoration.BorderRadius = 1000;
            this.Mainpanel.Size = new System.Drawing.Size(800, 450);
            this.Mainpanel.TabIndex = 1;
            // 
            // mainPanelHome
            // 
            this.mainPanelHome.BackColor = System.Drawing.Color.Transparent;
            this.mainPanelHome.Controls.Add(this.guna2Button2);
            this.mainPanelHome.Controls.Add(this.Shortpanel);
            this.mainPanelHome.Controls.Add(this.ExitBTN);
            this.mainPanelHome.Controls.Add(this.WebBckButton);
            this.mainPanelHome.Controls.Add(this.guna2Button1);
            this.mainPanelHome.Controls.Add(this.guna2Button4);
            this.mainPanelHome.Controls.Add(this.DragBTN);
            this.mainPanelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanelHome.Location = new System.Drawing.Point(0, 0);
            this.mainPanelHome.Name = "mainPanelHome";
            this.mainPanelHome.Size = new System.Drawing.Size(800, 51);
            this.mainPanelHome.TabIndex = 2;
            // 
            // ExitBTN
            // 
            this.ExitBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBTN.BackColor = System.Drawing.Color.Transparent;
            this.ExitBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitBTN.BorderColor = System.Drawing.Color.Crimson;
            this.ExitBTN.CustomBorderColor = System.Drawing.SystemColors.ControlText;
            this.ExitBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitBTN.FillColor = System.Drawing.Color.Transparent;
            this.ExitBTN.FocusedColor = System.Drawing.Color.Crimson;
            this.ExitBTN.Font = new System.Drawing.Font("Gilroy ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.ExitBTN.ForeColor = System.Drawing.Color.White;
            this.ExitBTN.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.ExitBTN.HoverState.CustomBorderColor = System.Drawing.Color.Crimson;
            this.ExitBTN.HoverState.FillColor = System.Drawing.Color.Crimson;
            this.ExitBTN.HoverState.ForeColor = System.Drawing.Color.LavenderBlush;
            this.ExitBTN.Location = new System.Drawing.Point(737, 3);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(60, 38);
            this.ExitBTN.TabIndex = 0;
            this.ExitBTN.Text = "EXIT";
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // DragBTN
            // 
            this.DragBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DragBTN.Animated = true;
            this.DragBTN.AutoRoundedCorners = true;
            this.DragBTN.BackColor = System.Drawing.Color.Transparent;
            this.DragBTN.BorderColor = System.Drawing.Color.Brown;
            this.DragBTN.BorderRadius = 18;
            this.DragBTN.CustomBorderColor = System.Drawing.Color.Indigo;
            this.DragBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DragBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DragBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DragBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DragBTN.FillColor = System.Drawing.Color.Transparent;
            this.DragBTN.Font = new System.Drawing.Font("Gilroy ExtraBold", 9.5F, System.Drawing.FontStyle.Bold);
            this.DragBTN.ForeColor = System.Drawing.Color.White;
            this.DragBTN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DragBTN.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DragBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DragBTN.Location = new System.Drawing.Point(650, 3);
            this.DragBTN.Name = "DragBTN";
            this.DragBTN.Size = new System.Drawing.Size(89, 38);
            this.DragBTN.TabIndex = 0;
            this.DragBTN.Text = "MAXIMIZE";
            this.DragBTN.Click += new System.EventHandler(this.MaxmizeBtn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Brown;
            this.guna2Button1.BorderRadius = 18;
            this.guna2Button1.CustomBorderColor = System.Drawing.Color.Indigo;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Gilroy ExtraBold", 9.5F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Button1.Location = new System.Drawing.Point(467, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(60, 38);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Hide";
            this.guna2Button1.Click += new System.EventHandler(this.HidePanelbtn_Click);
            // 
            // Shortpanel
            // 
            this.Shortpanel.AutoScroll = true;
            this.Shortpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Shortpanel.Location = new System.Drawing.Point(0, 0);
            this.Shortpanel.Name = "Shortpanel";
            this.Shortpanel.Size = new System.Drawing.Size(200, 51);
            this.Shortpanel.TabIndex = 1;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.Brown;
            this.guna2Button2.BorderRadius = 18;
            this.guna2Button2.CustomBorderColor = System.Drawing.Color.Indigo;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Gilroy ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(206, 3);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(60, 38);
            this.guna2Button2.TabIndex = 0;
            this.guna2Button2.Text = "ADD";
            this.guna2Button2.Click += new System.EventHandler(this.PlusShort_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button4.Animated = true;
            this.guna2Button4.AutoRoundedCorners = true;
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderColor = System.Drawing.Color.Brown;
            this.guna2Button4.BorderRadius = 18;
            this.guna2Button4.CustomBorderColor = System.Drawing.Color.Indigo;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Gilroy ExtraBold", 9.5F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.BorderColor = System.Drawing.Color.DarkGreen;
            this.guna2Button4.HoverState.CustomBorderColor = System.Drawing.Color.DarkGreen;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.DarkGreen;
            this.guna2Button4.Location = new System.Drawing.Point(533, 3);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(111, 38);
            this.guna2Button4.TabIndex = 0;
            this.guna2Button4.Text = "DOWNLOADS";
            this.guna2Button4.Click += new System.EventHandler(this.DownloadHubbtn_Click);
            // 
            // WebBckButton
            // 
            this.WebBckButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WebBckButton.Animated = true;
            this.WebBckButton.AutoRoundedCorners = true;
            this.WebBckButton.BackColor = System.Drawing.Color.Transparent;
            this.WebBckButton.BorderColor = System.Drawing.Color.Brown;
            this.WebBckButton.BorderRadius = 18;
            this.WebBckButton.CustomBorderColor = System.Drawing.Color.Indigo;
            this.WebBckButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WebBckButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WebBckButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WebBckButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WebBckButton.FillColor = System.Drawing.Color.Transparent;
            this.WebBckButton.Font = new System.Drawing.Font("Gilroy ExtraBold", 9.5F, System.Drawing.FontStyle.Bold);
            this.WebBckButton.ForeColor = System.Drawing.Color.White;
            this.WebBckButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.WebBckButton.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.WebBckButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.WebBckButton.Location = new System.Drawing.Point(401, 3);
            this.WebBckButton.Name = "WebBckButton";
            this.WebBckButton.Size = new System.Drawing.Size(60, 38);
            this.WebBckButton.TabIndex = 0;
            this.WebBckButton.Text = "Bsck";
            this.WebBckButton.Click += new System.EventHandler(this.WebBckButton_Click);
            // 
            // BrowserWb
            // 
            this.BrowserWb.AreBrowserAcceleratorKeysEnabled = true;
            this.BrowserWb.BackColor = System.Drawing.Color.Black;
            this.BrowserWb.DefaultBackgroundColor = System.Drawing.Color.Empty;
            this.BrowserWb.DefaultContextMenusEnabled = false;
            this.BrowserWb.DefaultScriptDialogsEnabled = true;
            this.BrowserWb.DevToolsEnabled = true;
            this.BrowserWb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserWb.EnableMonitoring = false;
            this.BrowserWb.HtmlContent = null;
            this.BrowserWb.IsGeneralAutoFillEnabled = false;
            this.BrowserWb.IsMuted = false;
            this.BrowserWb.IsPasswordAutosaveEnabled = false;
            this.BrowserWb.IsScriptEnabled = true;
            this.BrowserWb.IsStatusBarEnabled = false;
            this.BrowserWb.IsWebMessageEnabled = true;
            this.BrowserWb.IsZoomControlEnabled = true;
            this.BrowserWb.Location = new System.Drawing.Point(0, 51);
            this.BrowserWb.MonitoringFolder = null;
            this.BrowserWb.MonitoringUrl = null;
            this.BrowserWb.Name = "BrowserWb";
            this.BrowserWb.RemoteObjectsAllowed = true;
            this.BrowserWb.Size = new System.Drawing.Size(800, 399);
            this.BrowserWb.TabIndex = 3;
            this.BrowserWb.Url = "https://www.google.com/";
            this.BrowserWb.ZoomFactor = 0D;
            // 
            // GameBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameBrowse";
            this.Text = "GameBrowse";
            this.Load += new System.EventHandler(this.GameBrowse_Load);
            this.Mainpanel.ResumeLayout(false);
            this.mainPanelHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Mainpanel;
        private Guna.UI2.WinForms.Guna2Panel mainPanelHome;
        private Guna.UI2.WinForms.Guna2Button ExitBTN;
        private Guna.UI2.WinForms.Guna2Button DragBTN;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.FlowLayoutPanel Shortpanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button WebBckButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Diga.WebView2.WinForms.WebView BrowserWb;
    }
}