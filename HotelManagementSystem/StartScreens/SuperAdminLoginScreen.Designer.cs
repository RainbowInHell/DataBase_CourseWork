namespace HotelManagementSystem.StartScreens
{
    partial class SuperAdminLoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdminLoginScreen));
            this.errorLabel = new System.Windows.Forms.Label();
            this.enterButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.returnBackButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.adminLoginField = new Testing.RoundTextBox();
            this.adminPasswordField = new Testing.RoundTextBox();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(650, 421);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(205, 18);
            this.errorLabel.TabIndex = 12;
            this.errorLabel.Text = "Неверный логин или пароль";
            this.errorLabel.Visible = false;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Transparent;
            this.enterButton.BorderColor = System.Drawing.Color.Transparent;
            this.enterButton.BorderRadius = 20;
            this.enterButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.Location = new System.Drawing.Point(632, 343);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(240, 55);
            this.enterButton.TabIndex = 11;
            this.enterButton.Text = "ВОЙТИ";
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(650, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Администратор";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.DimGray;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-1, -1);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(441, 558);
            this.guna2GradientPanel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(43, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 182);
            this.label3.TabIndex = 15;
            this.label3.Text = "Мы предоставляем наиболее управляемую и безопасную систему для улучшения качества" +
    " вашего отеля.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(138, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "О НАС";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2Panel1.Location = new System.Drawing.Point(692, 86);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(109, 98);
            this.guna2Panel1.TabIndex = 15;
            // 
            // returnBackButton
            // 
            this.returnBackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returnBackButton.BackgroundImage")));
            this.returnBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.returnBackButton.FillColor = System.Drawing.Color.Transparent;
            this.returnBackButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnBackButton.ForeColor = System.Drawing.Color.White;
            this.returnBackButton.Location = new System.Drawing.Point(1007, 4);
            this.returnBackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.returnBackButton.Name = "returnBackButton";
            this.returnBackButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.returnBackButton.Size = new System.Drawing.Size(60, 58);
            this.returnBackButton.TabIndex = 16;
            this.returnBackButton.Click += new System.EventHandler(this.returnBackButton_Click);
            // 
            // adminLoginField
            // 
            this.adminLoginField.BorderColor = System.Drawing.Color.Black;
            this.adminLoginField.BorderFocusColor = System.Drawing.Color.Black;
            this.adminLoginField.BorderRadius = 15;
            this.adminLoginField.BorderSize = 1;
            this.adminLoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminLoginField.Location = new System.Drawing.Point(648, 228);
            this.adminLoginField.Margin = new System.Windows.Forms.Padding(4);
            this.adminLoginField.Multiline = false;
            this.adminLoginField.Name = "adminLoginField";
            this.adminLoginField.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.adminLoginField.PasswordChar = false;
            this.adminLoginField.PlaceholderColor = System.Drawing.Color.DimGray;
            this.adminLoginField.PlaceholderText = "Логин";
            this.adminLoginField.Size = new System.Drawing.Size(198, 33);
            this.adminLoginField.TabIndex = 99;
            this.adminLoginField.Texts = "";
            this.adminLoginField.UnderlinedStyle = false;
            // 
            // adminPasswordField
            // 
            this.adminPasswordField.BorderColor = System.Drawing.Color.Black;
            this.adminPasswordField.BorderFocusColor = System.Drawing.Color.Black;
            this.adminPasswordField.BorderRadius = 15;
            this.adminPasswordField.BorderSize = 1;
            this.adminPasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminPasswordField.Location = new System.Drawing.Point(648, 269);
            this.adminPasswordField.Margin = new System.Windows.Forms.Padding(4);
            this.adminPasswordField.Multiline = false;
            this.adminPasswordField.Name = "adminPasswordField";
            this.adminPasswordField.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.adminPasswordField.PasswordChar = true;
            this.adminPasswordField.PlaceholderColor = System.Drawing.Color.Gray;
            this.adminPasswordField.PlaceholderText = "Пароль";
            this.adminPasswordField.Size = new System.Drawing.Size(198, 33);
            this.adminPasswordField.TabIndex = 100;
            this.adminPasswordField.Texts = "";
            this.adminPasswordField.UnderlinedStyle = false;
            // 
            // SuperAdminLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.adminPasswordField);
            this.Controls.Add(this.adminLoginField);
            this.Controls.Add(this.returnBackButton);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SuperAdminLoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperAdminScreen";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private Guna.UI2.WinForms.Guna2Button enterButton;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton returnBackButton;
        private Testing.RoundTextBox adminLoginField;
        private Testing.RoundTextBox adminPasswordField;
    }
}