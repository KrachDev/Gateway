
namespace Gateway
{
    partial class SearchForm
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
            this.mainPanelHome = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitBTN = new Guna.UI2.WinForms.Guna2Button();
            this.Mainpanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.PreSearchBTN = new Guna.UI2.WinForms.Guna2Button();
            this.NextBTN = new Guna.UI2.WinForms.Guna2Button();
            this.SearchBar = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuggestionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainPanelHome.SuspendLayout();
            this.Mainpanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // mainPanelHome
            // 
            this.mainPanelHome.BackColor = System.Drawing.Color.Transparent;
            this.mainPanelHome.Controls.Add(this.label1);
            this.mainPanelHome.Controls.Add(this.SearchBar);
            this.mainPanelHome.Controls.Add(this.ExitBTN);
            this.mainPanelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanelHome.Location = new System.Drawing.Point(0, 0);
            this.mainPanelHome.Name = "mainPanelHome";
            this.mainPanelHome.Size = new System.Drawing.Size(417, 52);
            this.mainPanelHome.TabIndex = 3;
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
            this.ExitBTN.Location = new System.Drawing.Point(345, 3);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(60, 38);
            this.ExitBTN.TabIndex = 1;
            this.ExitBTN.Text = "EXIT";
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // Mainpanel
            // 
            this.Mainpanel.Controls.Add(this.SuggestionsPanel);
            this.Mainpanel.Controls.Add(this.guna2Panel1);
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
            this.Mainpanel.Size = new System.Drawing.Size(417, 450);
            this.Mainpanel.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.NextBTN);
            this.guna2Panel1.Controls.Add(this.SearchBtn);
            this.guna2Panel1.Controls.Add(this.PreSearchBTN);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 398);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(417, 52);
            this.guna2Panel1.TabIndex = 4;
            // 
            // PreSearchBTN
            // 
            this.PreSearchBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PreSearchBTN.BackColor = System.Drawing.Color.Transparent;
            this.PreSearchBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PreSearchBTN.BorderColor = System.Drawing.Color.Crimson;
            this.PreSearchBTN.CustomBorderColor = System.Drawing.SystemColors.ControlText;
            this.PreSearchBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PreSearchBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PreSearchBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PreSearchBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PreSearchBTN.FillColor = System.Drawing.Color.Transparent;
            this.PreSearchBTN.FocusedColor = System.Drawing.Color.Crimson;
            this.PreSearchBTN.Font = new System.Drawing.Font("Gilroy ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.PreSearchBTN.ForeColor = System.Drawing.Color.White;
            this.PreSearchBTN.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.PreSearchBTN.HoverState.CustomBorderColor = System.Drawing.Color.Crimson;
            this.PreSearchBTN.HoverState.FillColor = System.Drawing.Color.Crimson;
            this.PreSearchBTN.HoverState.ForeColor = System.Drawing.Color.LavenderBlush;
            this.PreSearchBTN.Location = new System.Drawing.Point(3, 3);
            this.PreSearchBTN.Name = "PreSearchBTN";
            this.PreSearchBTN.Size = new System.Drawing.Size(96, 46);
            this.PreSearchBTN.TabIndex = 1;
            this.PreSearchBTN.Text = "PREVIOUS";
            // 
            // NextBTN
            // 
            this.NextBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextBTN.BackColor = System.Drawing.Color.Transparent;
            this.NextBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NextBTN.BorderColor = System.Drawing.Color.Crimson;
            this.NextBTN.CustomBorderColor = System.Drawing.SystemColors.ControlText;
            this.NextBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NextBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NextBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NextBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NextBTN.FillColor = System.Drawing.Color.Transparent;
            this.NextBTN.FocusedColor = System.Drawing.Color.Crimson;
            this.NextBTN.Font = new System.Drawing.Font("Gilroy ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.NextBTN.ForeColor = System.Drawing.Color.White;
            this.NextBTN.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.NextBTN.HoverState.CustomBorderColor = System.Drawing.Color.Crimson;
            this.NextBTN.HoverState.FillColor = System.Drawing.Color.Crimson;
            this.NextBTN.HoverState.ForeColor = System.Drawing.Color.LavenderBlush;
            this.NextBTN.Location = new System.Drawing.Point(318, 3);
            this.NextBTN.Name = "NextBTN";
            this.NextBTN.Size = new System.Drawing.Size(96, 46);
            this.NextBTN.TabIndex = 1;
            this.NextBTN.Text = "NEXT";
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.Indigo;
            this.SearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBar.Font = new System.Drawing.Font("Gilroy Light", 9.7F);
            this.SearchBar.ForeColor = System.Drawing.Color.White;
            this.SearchBar.Location = new System.Drawing.Point(59, 14);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(271, 17);
            this.SearchBar.TabIndex = 2;
            this.SearchBar.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gilroy ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchBtn.BorderColor = System.Drawing.Color.Crimson;
            this.SearchBtn.CustomBorderColor = System.Drawing.SystemColors.ControlText;
            this.SearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchBtn.FillColor = System.Drawing.Color.Transparent;
            this.SearchBtn.FocusedColor = System.Drawing.Color.Crimson;
            this.SearchBtn.Font = new System.Drawing.Font("Gilroy ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.SearchBtn.HoverState.CustomBorderColor = System.Drawing.Color.Crimson;
            this.SearchBtn.HoverState.FillColor = System.Drawing.Color.Crimson;
            this.SearchBtn.HoverState.ForeColor = System.Drawing.Color.LavenderBlush;
            this.SearchBtn.Location = new System.Drawing.Point(156, 3);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(96, 46);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "SEARCH";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SuggestionsPanel
            // 
            this.SuggestionsPanel.AutoScroll = true;
            this.SuggestionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.SuggestionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuggestionsPanel.Location = new System.Drawing.Point(0, 52);
            this.SuggestionsPanel.Name = "SuggestionsPanel";
            this.SuggestionsPanel.Size = new System.Drawing.Size(417, 346);
            this.SuggestionsPanel.TabIndex = 5;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.Mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.mainPanelHome.ResumeLayout(false);
            this.mainPanelHome.PerformLayout();
            this.Mainpanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Mainpanel;
        private System.Windows.Forms.FlowLayoutPanel SuggestionsPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button NextBTN;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2Button PreSearchBTN;
        private Guna.UI2.WinForms.Guna2Panel mainPanelHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox SearchBar;
        private Guna.UI2.WinForms.Guna2Button ExitBTN;
    }
}