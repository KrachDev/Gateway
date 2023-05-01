
namespace Gateway
{
    partial class ConsolForm
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
            this.grad = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.GamesFlow2 = new System.Windows.Forms.FlowLayoutPanel();
            this.AppsFlow2 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.exitbutton = new Guna.UI2.WinForms.Guna2Button();
            this.Gbrowserbtn = new Guna.UI2.WinForms.Guna2Button();
            this.GamepadButton = new Guna.UI2.WinForms.Guna2Button();
            this.PcModebtn = new Guna.UI2.WinForms.Guna2Button();
            this.grad.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // grad
            // 
            this.grad.Controls.Add(this.GamesFlow2);
            this.grad.Controls.Add(this.AppsFlow2);
            this.grad.Controls.Add(this.guna2Panel1);
            this.grad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grad.FillColor = System.Drawing.Color.Indigo;
            this.grad.FillColor2 = System.Drawing.Color.Black;
            this.grad.FillColor3 = System.Drawing.Color.Indigo;
            this.grad.FillColor4 = System.Drawing.Color.Black;
            this.grad.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grad.Location = new System.Drawing.Point(0, 0);
            this.grad.Name = "grad";
            this.grad.ShadowDecoration.BorderRadius = 1000;
            this.grad.Size = new System.Drawing.Size(881, 364);
            this.grad.TabIndex = 1;
            // 
            // GamesFlow2
            // 
            this.GamesFlow2.AutoScroll = true;
            this.GamesFlow2.BackColor = System.Drawing.Color.Transparent;
            this.GamesFlow2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamesFlow2.Location = new System.Drawing.Point(0, 51);
            this.GamesFlow2.Name = "GamesFlow2";
            this.GamesFlow2.Size = new System.Drawing.Size(773, 313);
            this.GamesFlow2.TabIndex = 4;
            // 
            // AppsFlow2
            // 
            this.AppsFlow2.AutoScroll = true;
            this.AppsFlow2.BackColor = System.Drawing.Color.Transparent;
            this.AppsFlow2.Dock = System.Windows.Forms.DockStyle.Right;
            this.AppsFlow2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.AppsFlow2.Location = new System.Drawing.Point(773, 51);
            this.AppsFlow2.Name = "AppsFlow2";
            this.AppsFlow2.Size = new System.Drawing.Size(108, 313);
            this.AppsFlow2.TabIndex = 4;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.exitbutton);
            this.guna2Panel1.Controls.Add(this.Gbrowserbtn);
            this.guna2Panel1.Controls.Add(this.GamepadButton);
            this.guna2Panel1.Controls.Add(this.PcModebtn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(881, 51);
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
            this.exitbutton.Location = new System.Drawing.Point(818, 3);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(60, 38);
            this.exitbutton.TabIndex = 0;
            this.exitbutton.Text = "EXIT";
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // Gbrowserbtn
            // 
            this.Gbrowserbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Gbrowserbtn.Animated = true;
            this.Gbrowserbtn.AutoRoundedCorners = true;
            this.Gbrowserbtn.BackColor = System.Drawing.Color.Transparent;
            this.Gbrowserbtn.BorderColor = System.Drawing.Color.Brown;
            this.Gbrowserbtn.BorderRadius = 18;
            this.Gbrowserbtn.CustomBorderColor = System.Drawing.Color.Indigo;
            this.Gbrowserbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gbrowserbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gbrowserbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gbrowserbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gbrowserbtn.FillColor = System.Drawing.Color.Transparent;
            this.Gbrowserbtn.Font = new System.Drawing.Font("Gilroy ExtraBold", 9.5F, System.Drawing.FontStyle.Bold);
            this.Gbrowserbtn.ForeColor = System.Drawing.Color.White;
            this.Gbrowserbtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gbrowserbtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gbrowserbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gbrowserbtn.Location = new System.Drawing.Point(614, 3);
            this.Gbrowserbtn.Name = "Gbrowserbtn";
            this.Gbrowserbtn.Size = new System.Drawing.Size(111, 38);
            this.Gbrowserbtn.TabIndex = 0;
            this.Gbrowserbtn.Text = "Games Browser";
            // 
            // GamepadButton
            // 
            this.GamepadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GamepadButton.Animated = true;
            this.GamepadButton.AutoRoundedCorners = true;
            this.GamepadButton.BackColor = System.Drawing.Color.Transparent;
            this.GamepadButton.BorderColor = System.Drawing.Color.Brown;
            this.GamepadButton.BorderRadius = 18;
            this.GamepadButton.CustomBorderColor = System.Drawing.Color.Indigo;
            this.GamepadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GamepadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GamepadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GamepadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GamepadButton.FillColor = System.Drawing.Color.Transparent;
            this.GamepadButton.Font = new System.Drawing.Font("Gilroy ExtraBold", 9.5F, System.Drawing.FontStyle.Bold);
            this.GamepadButton.ForeColor = System.Drawing.Color.White;
            this.GamepadButton.HoverState.BorderColor = System.Drawing.Color.DarkGreen;
            this.GamepadButton.HoverState.CustomBorderColor = System.Drawing.Color.DarkGreen;
            this.GamepadButton.HoverState.FillColor = System.Drawing.Color.DarkGreen;
            this.GamepadButton.Location = new System.Drawing.Point(497, 3);
            this.GamepadButton.Name = "GamepadButton";
            this.GamepadButton.Size = new System.Drawing.Size(111, 38);
            this.GamepadButton.TabIndex = 0;
            this.GamepadButton.Text = "Gamepad";
            this.GamepadButton.Click += new System.EventHandler(this.GamepadButton_Click);
            // 
            // PcModebtn
            // 
            this.PcModebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PcModebtn.Animated = true;
            this.PcModebtn.AutoRoundedCorners = true;
            this.PcModebtn.BackColor = System.Drawing.Color.Transparent;
            this.PcModebtn.BorderColor = System.Drawing.Color.Brown;
            this.PcModebtn.BorderRadius = 18;
            this.PcModebtn.CustomBorderColor = System.Drawing.Color.Indigo;
            this.PcModebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PcModebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PcModebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PcModebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PcModebtn.FillColor = System.Drawing.Color.Transparent;
            this.PcModebtn.Font = new System.Drawing.Font("Gilroy ExtraBold", 9.5F, System.Drawing.FontStyle.Bold);
            this.PcModebtn.ForeColor = System.Drawing.Color.White;
            this.PcModebtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PcModebtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PcModebtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PcModebtn.Location = new System.Drawing.Point(731, 3);
            this.PcModebtn.Name = "PcModebtn";
            this.PcModebtn.Size = new System.Drawing.Size(89, 38);
            this.PcModebtn.TabIndex = 0;
            this.PcModebtn.Text = "Pc Mode";
            // 
            // ConsolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 364);
            this.Controls.Add(this.grad);
            this.Font = new System.Drawing.Font("Gilroy Light", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsolForm";
            this.Text = "Console Mode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsolForm_FormClosing);
            this.Load += new System.EventHandler(this.ConsolForm_Load);
            this.grad.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel grad;
        private System.Windows.Forms.FlowLayoutPanel GamesFlow2;
        private System.Windows.Forms.FlowLayoutPanel AppsFlow2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button exitbutton;
        private Guna.UI2.WinForms.Guna2Button Gbrowserbtn;
        private Guna.UI2.WinForms.Guna2Button GamepadButton;
        private Guna.UI2.WinForms.Guna2Button PcModebtn;
    }
}