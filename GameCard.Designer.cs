
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.PBgamecover = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.LaunchBTN = new Guna.UI2.WinForms.Guna2Button();
            this.AvTimeLBL = new System.Windows.Forms.Label();
            this.PoplateBTN = new Guna.UI2.WinForms.Guna2Button();
            this.TimSpentLBL = new System.Windows.Forms.Label();
            this.Rlbl = new System.Windows.Forms.Label();
            this.Descriptionpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.GameDescriptionLBL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.svlolbl = new System.Windows.Forms.Label();
            this.dateLBL = new System.Windows.Forms.Label();
            this.SizeLBL = new System.Windows.Forms.Label();
            this.gmfolbl = new System.Windows.Forms.Label();
            this.NameLBL = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.exitbutton = new Guna.UI2.WinForms.Guna2Button();
            this.BrowseWb = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbsaveupload = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.grad.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBgamecover)).BeginInit();
            this.panel1.SuspendLayout();
            this.Descriptionpanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseWb)).BeginInit();
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
            this.grad.Size = new System.Drawing.Size(890, 598);
            this.grad.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.LaunchBTN);
            this.panel2.Controls.Add(this.guna2Button2);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.PoplateBTN);
            this.panel2.Controls.Add(this.PBgamecover);
            this.panel2.Controls.Add(this.Descriptionpanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 547);
            this.panel2.TabIndex = 1;
            // 
            // PBgamecover
            // 
            this.PBgamecover.BackColor = System.Drawing.Color.MediumPurple;
            this.PBgamecover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PBgamecover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBgamecover.FillColor = System.Drawing.Color.Transparent;
            this.PBgamecover.ImageRotate = 0F;
            this.PBgamecover.Location = new System.Drawing.Point(52, 6);
            this.PBgamecover.Name = "PBgamecover";
            this.PBgamecover.Size = new System.Drawing.Size(142, 181);
            this.PBgamecover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBgamecover.TabIndex = 6;
            this.PBgamecover.TabStop = false;
            this.PBgamecover.Click += new System.EventHandler(this.PBgamecover_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pbsaveupload);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.AvTimeLBL);
            this.panel1.Controls.Add(this.BrowseWb);
            this.panel1.Controls.Add(this.TimSpentLBL);
            this.panel1.Controls.Add(this.Rlbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.svlolbl);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dateLBL);
            this.panel1.Controls.Add(this.SizeLBL);
            this.panel1.Controls.Add(this.gmfolbl);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.NameLBL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(351, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 547);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gilroy Light", 9.5F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Rating:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LaunchBTN
            // 
            this.LaunchBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaunchBTN.BackColor = System.Drawing.Color.Transparent;
            this.LaunchBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LaunchBTN.BorderColor = System.Drawing.Color.Crimson;
            this.LaunchBTN.CustomBorderColor = System.Drawing.SystemColors.ControlText;
            this.LaunchBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LaunchBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LaunchBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LaunchBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LaunchBTN.FillColor = System.Drawing.Color.Transparent;
            this.LaunchBTN.FocusedColor = System.Drawing.Color.DarkGreen;
            this.LaunchBTN.Font = new System.Drawing.Font("Gilroy ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.LaunchBTN.ForeColor = System.Drawing.Color.White;
            this.LaunchBTN.HoverState.BorderColor = System.Drawing.Color.DarkGreen;
            this.LaunchBTN.HoverState.CustomBorderColor = System.Drawing.Color.DarkGreen;
            this.LaunchBTN.HoverState.FillColor = System.Drawing.Color.DarkGreen;
            this.LaunchBTN.HoverState.ForeColor = System.Drawing.Color.LavenderBlush;
            this.LaunchBTN.Location = new System.Drawing.Point(73, 193);
            this.LaunchBTN.Name = "LaunchBTN";
            this.LaunchBTN.Size = new System.Drawing.Size(90, 38);
            this.LaunchBTN.TabIndex = 0;
            this.LaunchBTN.Text = "Play!";
            // 
            // AvTimeLBL
            // 
            this.AvTimeLBL.AutoSize = true;
            this.AvTimeLBL.Font = new System.Drawing.Font("Gilroy Light", 9.5F);
            this.AvTimeLBL.ForeColor = System.Drawing.Color.White;
            this.AvTimeLBL.Location = new System.Drawing.Point(13, 170);
            this.AvTimeLBL.Name = "AvTimeLBL";
            this.AvTimeLBL.Size = new System.Drawing.Size(85, 15);
            this.AvTimeLBL.TabIndex = 0;
            this.AvTimeLBL.Text = "Avrege Time;";
            this.AvTimeLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PoplateBTN
            // 
            this.PoplateBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PoplateBTN.BackColor = System.Drawing.Color.Transparent;
            this.PoplateBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PoplateBTN.BorderColor = System.Drawing.Color.Crimson;
            this.PoplateBTN.CustomBorderColor = System.Drawing.SystemColors.ControlText;
            this.PoplateBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PoplateBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PoplateBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PoplateBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PoplateBTN.FillColor = System.Drawing.Color.Transparent;
            this.PoplateBTN.FocusedColor = System.Drawing.Color.Crimson;
            this.PoplateBTN.Font = new System.Drawing.Font("Gilroy ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.PoplateBTN.ForeColor = System.Drawing.Color.White;
            this.PoplateBTN.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.PoplateBTN.HoverState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.PoplateBTN.HoverState.FillColor = System.Drawing.Color.MediumPurple;
            this.PoplateBTN.HoverState.ForeColor = System.Drawing.Color.LavenderBlush;
            this.PoplateBTN.Location = new System.Drawing.Point(255, 6);
            this.PoplateBTN.Name = "PoplateBTN";
            this.PoplateBTN.Size = new System.Drawing.Size(90, 38);
            this.PoplateBTN.TabIndex = 0;
            this.PoplateBTN.Text = "Poplaute";
            this.PoplateBTN.Click += new System.EventHandler(this.PoplateBTN_Click);
            // 
            // TimSpentLBL
            // 
            this.TimSpentLBL.AutoSize = true;
            this.TimSpentLBL.Font = new System.Drawing.Font("Gilroy Light", 9.5F);
            this.TimSpentLBL.ForeColor = System.Drawing.Color.White;
            this.TimSpentLBL.Location = new System.Drawing.Point(13, 138);
            this.TimSpentLBL.Name = "TimSpentLBL";
            this.TimSpentLBL.Size = new System.Drawing.Size(77, 15);
            this.TimSpentLBL.TabIndex = 0;
            this.TimSpentLBL.Text = "Time Spent:";
            this.TimSpentLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rlbl
            // 
            this.Rlbl.AutoSize = true;
            this.Rlbl.Font = new System.Drawing.Font("Gilroy ExtraBold", 9.5F);
            this.Rlbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.Rlbl.Location = new System.Drawing.Point(65, 199);
            this.Rlbl.Name = "Rlbl";
            this.Rlbl.Size = new System.Drawing.Size(23, 16);
            this.Rlbl.TabIndex = 0;
            this.Rlbl.Text = "***";
            this.Rlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.Descriptionpanel.Location = new System.Drawing.Point(0, 258);
            this.Descriptionpanel.Name = "Descriptionpanel";
            this.Descriptionpanel.Size = new System.Drawing.Size(354, 289);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gilroy ExtraBold", 9.5F);
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(104, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "***";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gilroy ExtraBold", 9.5F);
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(96, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "***";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gilroy ExtraBold", 9.5F);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(53, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "***";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // svlolbl
            // 
            this.svlolbl.AutoSize = true;
            this.svlolbl.Font = new System.Drawing.Font("Gilroy ExtraBold", 9.5F);
            this.svlolbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.svlolbl.Location = new System.Drawing.Point(321, 61);
            this.svlolbl.Name = "svlolbl";
            this.svlolbl.Size = new System.Drawing.Size(23, 16);
            this.svlolbl.TabIndex = 0;
            this.svlolbl.Text = "***";
            this.svlolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLBL
            // 
            this.dateLBL.AutoSize = true;
            this.dateLBL.Font = new System.Drawing.Font("Gilroy Light", 9.5F);
            this.dateLBL.ForeColor = System.Drawing.Color.White;
            this.dateLBL.Location = new System.Drawing.Point(13, 61);
            this.dateLBL.Name = "dateLBL";
            this.dateLBL.Size = new System.Drawing.Size(92, 15);
            this.dateLBL.TabIndex = 0;
            this.dateLBL.Text = "Release Date:";
            this.dateLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SizeLBL
            // 
            this.SizeLBL.AutoSize = true;
            this.SizeLBL.Font = new System.Drawing.Font("Gilroy Light", 9.5F);
            this.SizeLBL.ForeColor = System.Drawing.Color.White;
            this.SizeLBL.Location = new System.Drawing.Point(13, 100);
            this.SizeLBL.Name = "SizeLBL";
            this.SizeLBL.Size = new System.Drawing.Size(34, 15);
            this.SizeLBL.TabIndex = 0;
            this.SizeLBL.Text = "Size:";
            this.SizeLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gmfolbl
            // 
            this.gmfolbl.AutoSize = true;
            this.gmfolbl.Font = new System.Drawing.Font("Gilroy ExtraBold", 9.5F);
            this.gmfolbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.gmfolbl.Location = new System.Drawing.Point(321, 23);
            this.gmfolbl.Name = "gmfolbl";
            this.gmfolbl.Size = new System.Drawing.Size(23, 16);
            this.gmfolbl.TabIndex = 0;
            this.gmfolbl.Text = "***";
            this.gmfolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.Font = new System.Drawing.Font("Gilroy Light", 9.5F);
            this.NameLBL.ForeColor = System.Drawing.Color.White;
            this.NameLBL.Location = new System.Drawing.Point(13, 23);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(46, 15);
            this.NameLBL.TabIndex = 0;
            this.NameLBL.Text = "Name:";
            this.NameLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.exitbutton);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(890, 51);
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
            this.exitbutton.Location = new System.Drawing.Point(827, 3);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(60, 38);
            this.exitbutton.TabIndex = 0;
            this.exitbutton.Text = "EXIT";
            this.exitbutton.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // BrowseWb
            // 
            this.BrowseWb.AllowExternalDrop = true;
            this.BrowseWb.BackColor = System.Drawing.SystemColors.InfoText;
            this.BrowseWb.CreationProperties = null;
            this.BrowseWb.DefaultBackgroundColor = System.Drawing.Color.White;
            this.BrowseWb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BrowseWb.ForeColor = System.Drawing.Color.DarkMagenta;
            this.BrowseWb.Location = new System.Drawing.Point(0, 247);
            this.BrowseWb.Name = "BrowseWb";
            this.BrowseWb.Size = new System.Drawing.Size(539, 300);
            this.BrowseWb.TabIndex = 7;
            this.BrowseWb.ZoomFactor = 1D;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Game Traiiler";
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button2.BorderColor = System.Drawing.Color.Crimson;
            this.guna2Button2.CustomBorderColor = System.Drawing.SystemColors.ControlText;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.FocusedColor = System.Drawing.Color.Crimson;
            this.guna2Button2.Font = new System.Drawing.Font("Gilroy ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.MediumPurple;
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.LavenderBlush;
            this.guna2Button2.Location = new System.Drawing.Point(255, 100);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(90, 38);
            this.guna2Button2.TabIndex = 0;
            this.guna2Button2.Text = "Game Save";
            this.guna2Button2.Click += new System.EventHandler(this.PoplateBTN_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button1.BorderColor = System.Drawing.Color.Crimson;
            this.guna2Button1.CustomBorderColor = System.Drawing.SystemColors.ControlText;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.FocusedColor = System.Drawing.Color.Crimson;
            this.guna2Button1.Font = new System.Drawing.Font("Gilroy ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.MediumPurple;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.LavenderBlush;
            this.guna2Button1.Location = new System.Drawing.Point(255, 50);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(96, 44);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Game Folder";
            this.guna2Button1.Click += new System.EventHandler(this.PoplateBTN_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button3.BorderColor = System.Drawing.Color.Crimson;
            this.guna2Button3.CustomBorderColor = System.Drawing.SystemColors.ControlText;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.FocusedColor = System.Drawing.Color.Crimson;
            this.guna2Button3.Font = new System.Drawing.Font("Gilroy ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.guna2Button3.HoverState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.MediumPurple;
            this.guna2Button3.HoverState.ForeColor = System.Drawing.Color.LavenderBlush;
            this.guna2Button3.Location = new System.Drawing.Point(437, 100);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(90, 38);
            this.guna2Button3.TabIndex = 0;
            this.guna2Button3.Text = "Upload save";
            this.guna2Button3.Click += new System.EventHandler(this.PoplateBTN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gilroy Light", 9.5F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(213, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Game Location:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gilroy Light", 9.5F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(213, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Save Location:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbsaveupload
            // 
            this.pbsaveupload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.pbsaveupload.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F);
            this.pbsaveupload.ForeColor = System.Drawing.Color.Green;
            this.pbsaveupload.Location = new System.Drawing.Point(315, 114);
            this.pbsaveupload.Minimum = 0;
            this.pbsaveupload.Name = "pbsaveupload";
            this.pbsaveupload.ProgressColor = System.Drawing.Color.CadetBlue;
            this.pbsaveupload.ProgressColor2 = System.Drawing.Color.DarkGreen;
            this.pbsaveupload.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pbsaveupload.ShadowDecoration.BorderRadius = 1000;
            this.pbsaveupload.ShadowDecoration.Depth = 25;
            this.pbsaveupload.ShadowDecoration.Enabled = true;
            this.pbsaveupload.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbsaveupload.ShowText = true;
            this.pbsaveupload.Size = new System.Drawing.Size(130, 130);
            this.pbsaveupload.TabIndex = 1;
            this.pbsaveupload.Text = "guna2CircleProgressBar1";
            // 
            // GameCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 598);
            this.Controls.Add(this.grad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameCard";
            this.Text = "GameCard";
            this.Load += new System.EventHandler(this.GameCard_Load);
            this.grad.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBgamecover)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Descriptionpanel.ResumeLayout(false);
            this.Descriptionpanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BrowseWb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm GCMP;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel grad;
        private System.Windows.Forms.FlowLayoutPanel Descriptionpanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button exitbutton;
        private Guna.UI2.WinForms.Guna2Button PoplateBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AvTimeLBL;
        private System.Windows.Forms.Label TimSpentLBL;
        private System.Windows.Forms.Label dateLBL;
        private System.Windows.Forms.Label SizeLBL;
        private System.Windows.Forms.Label NameLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GameDescriptionLBL;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2PictureBox PBgamecover;
        private Guna.UI2.WinForms.Guna2Button LaunchBTN;
        private System.Windows.Forms.Label svlolbl;
        private System.Windows.Forms.Label gmfolbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Rlbl;
        private Microsoft.Web.WebView2.WinForms.WebView2 BrowseWb;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2CircleProgressBar pbsaveupload;
    }
}