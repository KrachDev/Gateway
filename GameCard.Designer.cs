
namespace Gateway
{
    partial class GameCard
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
            this.GCMP = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.grad = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.exitbutton = new Guna.UI2.WinForms.Guna2Button();
            this.Descriptionpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.GameDescriptionLBL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameLBL = new System.Windows.Forms.Label();
            this.dateLBL = new System.Windows.Forms.Label();
            this.SizeLBL = new System.Windows.Forms.Label();
            this.TimSpentLBL = new System.Windows.Forms.Label();
            this.AvTimeLBL = new System.Windows.Forms.Label();
            this.PBgamecover = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CoverSearchBTN = new Guna.UI2.WinForms.Guna2Button();
            this.StartGameBTN = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.grad.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.Descriptionpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBgamecover)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // GCMP
            // 
            this.GCMP.ContainerControl = this;
            this.GCMP.DockIndicatorTransparencyValue = 0.6D;
            this.GCMP.TransparentWhileDrag = true;
            // 
            // grad
            // 
            this.grad.Controls.Add(this.panel2);
            this.grad.Controls.Add(this.panel1);
            this.grad.Controls.Add(this.guna2Panel1);
            this.grad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grad.FillColor = System.Drawing.Color.Indigo;
            this.grad.FillColor2 = System.Drawing.Color.Black;
            this.grad.FillColor3 = System.Drawing.Color.Indigo;
            this.grad.FillColor4 = System.Drawing.Color.Black;
            this.grad.Font = new System.Drawing.Font("Gilroy ExtraBold", 9.5F, System.Drawing.FontStyle.Bold);
            this.grad.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grad.Location = new System.Drawing.Point(0, 0);
            this.grad.Name = "grad";
            this.grad.ShadowDecoration.BorderRadius = 1000;
            this.grad.Size = new System.Drawing.Size(800, 450);
            this.grad.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.exitbutton);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 51);
            this.guna2Panel1.TabIndex = 3;
            // 
            // exitbutton
            // 
            this.exitbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitbutton.BackColor = System.Drawing.Color.Transparent;
            this.exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitbutton.BorderColor = System.Drawing.Color.Crimson;
            this.exitbutton.CustomBorderColor = System.Drawing.SystemColors.ControlText;
            this.exitbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitbutton.FillColor = System.Drawing.Color.Transparent;
            this.exitbutton.FocusedColor = System.Drawing.Color.Crimson;
            this.exitbutton.Font = new System.Drawing.Font("Gilroy ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.exitbutton.ForeColor = System.Drawing.Color.White;
            this.exitbutton.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.exitbutton.HoverState.CustomBorderColor = System.Drawing.Color.Crimson;
            this.exitbutton.HoverState.FillColor = System.Drawing.Color.Crimson;
            this.exitbutton.HoverState.ForeColor = System.Drawing.Color.LavenderBlush;
            this.exitbutton.Location = new System.Drawing.Point(737, 3);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(60, 38);
            this.exitbutton.TabIndex = 0;
            this.exitbutton.Text = "EXIT";
            this.exitbutton.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // Descriptionpanel
            // 
            this.Descriptionpanel.AutoScroll = true;
            this.Descriptionpanel.BackColor = System.Drawing.Color.Transparent;
            this.Descriptionpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Descriptionpanel.Controls.Add(this.label1);
            this.Descriptionpanel.Controls.Add(this.GameDescriptionLBL);
            this.Descriptionpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Descriptionpanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Descriptionpanel.Font = new System.Drawing.Font("Gilroy ExtraBold", 9.5F, System.Drawing.FontStyle.Bold);
            this.Descriptionpanel.ForeColor = System.Drawing.Color.Transparent;
            this.Descriptionpanel.Location = new System.Drawing.Point(0, 193);
            this.Descriptionpanel.Name = "Descriptionpanel";
            this.Descriptionpanel.Size = new System.Drawing.Size(354, 206);
            this.Descriptionpanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Descrption:";
            // 
            // GameDescriptionLBL
            // 
            this.GameDescriptionLBL.AutoSize = true;
            this.GameDescriptionLBL.Font = new System.Drawing.Font("Gilroy Light", 9.5F);
            this.GameDescriptionLBL.Location = new System.Drawing.Point(3, 16);
            this.GameDescriptionLBL.Name = "GameDescriptionLBL";
            this.GameDescriptionLBL.Size = new System.Drawing.Size(129, 15);
            this.GameDescriptionLBL.TabIndex = 0;
            this.GameDescriptionLBL.Text = "----descriprion----";
            this.GameDescriptionLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.AvTimeLBL);
            this.panel1.Controls.Add(this.TimSpentLBL);
            this.panel1.Controls.Add(this.dateLBL);
            this.panel1.Controls.Add(this.SizeLBL);
            this.panel1.Controls.Add(this.NameLBL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(348, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 399);
            this.panel1.TabIndex = 5;
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.Font = new System.Drawing.Font("Gilroy Light", 9.5F);
            this.NameLBL.Location = new System.Drawing.Point(13, 23);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(46, 15);
            this.NameLBL.TabIndex = 0;
            this.NameLBL.Text = "Name:";
            this.NameLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLBL
            // 
            this.dateLBL.AutoSize = true;
            this.dateLBL.Font = new System.Drawing.Font("Gilroy Light", 9.5F);
            this.dateLBL.Location = new System.Drawing.Point(13, 61);
            this.dateLBL.Name = "dateLBL";
            this.dateLBL.Size = new System.Drawing.Size(40, 15);
            this.dateLBL.TabIndex = 0;
            this.dateLBL.Text = "Date:";
            this.dateLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SizeLBL
            // 
            this.SizeLBL.AutoSize = true;
            this.SizeLBL.Font = new System.Drawing.Font("Gilroy Light", 9.5F);
            this.SizeLBL.Location = new System.Drawing.Point(13, 100);
            this.SizeLBL.Name = "SizeLBL";
            this.SizeLBL.Size = new System.Drawing.Size(34, 15);
            this.SizeLBL.TabIndex = 0;
            this.SizeLBL.Text = "Size:";
            this.SizeLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimSpentLBL
            // 
            this.TimSpentLBL.AutoSize = true;
            this.TimSpentLBL.Font = new System.Drawing.Font("Gilroy Light", 9.5F);
            this.TimSpentLBL.Location = new System.Drawing.Point(13, 138);
            this.TimSpentLBL.Name = "TimSpentLBL";
            this.TimSpentLBL.Size = new System.Drawing.Size(77, 15);
            this.TimSpentLBL.TabIndex = 0;
            this.TimSpentLBL.Text = "Time Spent:";
            this.TimSpentLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvTimeLBL
            // 
            this.AvTimeLBL.AutoSize = true;
            this.AvTimeLBL.Font = new System.Drawing.Font("Gilroy Light", 9.5F);
            this.AvTimeLBL.Location = new System.Drawing.Point(13, 170);
            this.AvTimeLBL.Name = "AvTimeLBL";
            this.AvTimeLBL.Size = new System.Drawing.Size(85, 15);
            this.AvTimeLBL.TabIndex = 0;
            this.AvTimeLBL.Text = "Avrege Time;";
            this.AvTimeLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBgamecover
            // 
            this.PBgamecover.BackColor = System.Drawing.Color.MediumPurple;
            this.PBgamecover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBgamecover.FillColor = System.Drawing.Color.Transparent;
            this.PBgamecover.ImageRotate = 0F;
            this.PBgamecover.Location = new System.Drawing.Point(41, 8);
            this.PBgamecover.Name = "PBgamecover";
            this.PBgamecover.Size = new System.Drawing.Size(150, 179);
            this.PBgamecover.TabIndex = 6;
            this.PBgamecover.TabStop = false;
            this.PBgamecover.Click += new System.EventHandler(this.PBgamecover_Click);
            // 
            // CoverSearchBTN
            // 
            this.CoverSearchBTN.BackColor = System.Drawing.Color.Transparent;
            this.CoverSearchBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CoverSearchBTN.BorderColor = System.Drawing.Color.Crimson;
            this.CoverSearchBTN.CustomBorderColor = System.Drawing.SystemColors.ControlText;
            this.CoverSearchBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CoverSearchBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CoverSearchBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CoverSearchBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CoverSearchBTN.FillColor = System.Drawing.Color.Transparent;
            this.CoverSearchBTN.FocusedColor = System.Drawing.Color.Crimson;
            this.CoverSearchBTN.Font = new System.Drawing.Font("Gilroy ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.CoverSearchBTN.ForeColor = System.Drawing.Color.White;
            this.CoverSearchBTN.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.CoverSearchBTN.HoverState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.CoverSearchBTN.HoverState.FillColor = System.Drawing.Color.MediumPurple;
            this.CoverSearchBTN.HoverState.ForeColor = System.Drawing.Color.LavenderBlush;
            this.CoverSearchBTN.Location = new System.Drawing.Point(197, 100);
            this.CoverSearchBTN.Name = "CoverSearchBTN";
            this.CoverSearchBTN.Size = new System.Drawing.Size(76, 38);
            this.CoverSearchBTN.TabIndex = 0;
            this.CoverSearchBTN.Text = "Cover Search";
            this.CoverSearchBTN.Click += new System.EventHandler(this.CoverSearchBTN_Click);
            // 
            // StartGameBTN
            // 
            this.StartGameBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartGameBTN.BackColor = System.Drawing.Color.Transparent;
            this.StartGameBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StartGameBTN.BorderColor = System.Drawing.Color.Crimson;
            this.StartGameBTN.CustomBorderColor = System.Drawing.SystemColors.ControlText;
            this.StartGameBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StartGameBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StartGameBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartGameBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StartGameBTN.FillColor = System.Drawing.Color.Transparent;
            this.StartGameBTN.FocusedColor = System.Drawing.Color.Crimson;
            this.StartGameBTN.Font = new System.Drawing.Font("Gilroy ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.StartGameBTN.ForeColor = System.Drawing.Color.White;
            this.StartGameBTN.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.StartGameBTN.HoverState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.StartGameBTN.HoverState.FillColor = System.Drawing.Color.MediumPurple;
            this.StartGameBTN.HoverState.ForeColor = System.Drawing.Color.LavenderBlush;
            this.StartGameBTN.Location = new System.Drawing.Point(197, 149);
            this.StartGameBTN.Name = "StartGameBTN";
            this.StartGameBTN.Size = new System.Drawing.Size(76, 38);
            this.StartGameBTN.TabIndex = 0;
            this.StartGameBTN.Text = "Launch";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.PBgamecover);
            this.panel2.Controls.Add(this.CoverSearchBTN);
            this.panel2.Controls.Add(this.Descriptionpanel);
            this.panel2.Controls.Add(this.StartGameBTN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 399);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.webView21);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(452, 206);
            this.panel3.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(351, 193);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(449, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(452, 206);
            this.webView21.Source = new System.Uri("https://www.google.com/", System.UriKind.Absolute);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // GameCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameCard";
            this.Text = "GameCard";
            this.grad.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.Descriptionpanel.ResumeLayout(false);
            this.Descriptionpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBgamecover)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm GCMP;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel grad;
        private System.Windows.Forms.FlowLayoutPanel Descriptionpanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button exitbutton;
        private Guna.UI2.WinForms.Guna2Button StartGameBTN;
        private Guna.UI2.WinForms.Guna2Button CoverSearchBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AvTimeLBL;
        private System.Windows.Forms.Label TimSpentLBL;
        private System.Windows.Forms.Label dateLBL;
        private System.Windows.Forms.Label SizeLBL;
        private System.Windows.Forms.Label NameLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GameDescriptionLBL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Guna.UI2.WinForms.Guna2PictureBox PBgamecover;
    }
}