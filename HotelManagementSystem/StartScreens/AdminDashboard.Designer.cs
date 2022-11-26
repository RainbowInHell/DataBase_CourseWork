namespace HotelManagementSystem.StartScreens
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.employessButton = new Guna.UI2.WinForms.Guna2Button();
            this.hotelsButton = new Guna.UI2.WinForms.Guna2Button();
            this.closeButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.mainPanel.BorderColor = System.Drawing.Color.Transparent;
            this.mainPanel.BorderRadius = 30;
            this.mainPanel.FillColor = System.Drawing.Color.Transparent;
            this.mainPanel.Location = new System.Drawing.Point(47, 103);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1511, 700);
            this.mainPanel.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.employessButton);
            this.guna2Panel2.Controls.Add(this.hotelsButton);
            this.guna2Panel2.Location = new System.Drawing.Point(47, 25);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(421, 75);
            this.guna2Panel2.TabIndex = 0;
            // 
            // employessButton
            // 
            this.employessButton.BorderRadius = 15;
            this.employessButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.employessButton.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.employessButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.employessButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employessButton.FillColor = System.Drawing.Color.DimGray;
            this.employessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employessButton.ForeColor = System.Drawing.Color.White;
            this.employessButton.ImageSize = new System.Drawing.Size(30, 30);
            this.employessButton.Location = new System.Drawing.Point(227, 7);
            this.employessButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employessButton.Name = "employessButton";
            this.employessButton.Size = new System.Drawing.Size(188, 54);
            this.employessButton.TabIndex = 4;
            this.employessButton.Text = "Работники";
            this.employessButton.Click += new System.EventHandler(this.employessButton_Click);
            // 
            // hotelsButton
            // 
            this.hotelsButton.BorderRadius = 15;
            this.hotelsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.hotelsButton.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.hotelsButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.hotelsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hotelsButton.FillColor = System.Drawing.Color.DimGray;
            this.hotelsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hotelsButton.ForeColor = System.Drawing.Color.White;
            this.hotelsButton.ImageSize = new System.Drawing.Size(30, 30);
            this.hotelsButton.Location = new System.Drawing.Point(24, 7);
            this.hotelsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hotelsButton.Name = "hotelsButton";
            this.hotelsButton.Size = new System.Drawing.Size(173, 54);
            this.hotelsButton.TabIndex = 2;
            this.hotelsButton.Text = "Отели";
            this.hotelsButton.Click += new System.EventHandler(this.hotelsButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BorderColor = System.Drawing.Color.Transparent;
            this.closeButton.BorderThickness = 2;
            this.closeButton.FillColor = System.Drawing.Color.Transparent;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1603, 19);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closeButton.Size = new System.Drawing.Size(33, 32);
            this.closeButton.TabIndex = 94;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1652, 826);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button hotelsButton;
        private Guna.UI2.WinForms.Guna2Button employessButton;
        private Guna.UI2.WinForms.Guna2CircleButton closeButton;
    }
}