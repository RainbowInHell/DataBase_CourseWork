using HotelManagementSystem.Properties;

namespace HotelManagementSystem.StartScreens
{
    partial class ResetPasswordScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordScreen));
            this.loginField = new Testing.RoundTextBox();
            this.emailAdresField = new Testing.RoundTextBox();
            this.newPasswordField = new Testing.RoundTextBox();
            this.newPasswordConfirmField = new Testing.RoundTextBox();
            this.sendCodeButton = new Guna.UI2.WinForms.Guna2Button();
            this.codeField = new Testing.RoundTextBox();
            this.changePasswordButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.closeButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // loginField
            // 
            this.loginField.BorderColor = System.Drawing.Color.Black;
            this.loginField.BorderFocusColor = System.Drawing.Color.Black;
            this.loginField.BorderRadius = 15;
            this.loginField.BorderSize = 1;
            this.loginField.Location = new System.Drawing.Point(13, 95);
            this.loginField.Margin = new System.Windows.Forms.Padding(4);
            this.loginField.Multiline = false;
            this.loginField.Name = "loginField";
            this.loginField.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.loginField.PasswordChar = false;
            this.loginField.PlaceholderColor = System.Drawing.Color.DimGray;
            this.loginField.PlaceholderText = "Логин";
            this.loginField.Size = new System.Drawing.Size(198, 35);
            this.loginField.TabIndex = 3;
            this.loginField.TabStop = false;
            this.loginField.Texts = "";
            this.loginField.UnderlinedStyle = false;
            // 
            // emailAdresField
            // 
            this.emailAdresField.BorderColor = System.Drawing.Color.Black;
            this.emailAdresField.BorderFocusColor = System.Drawing.Color.Black;
            this.emailAdresField.BorderRadius = 15;
            this.emailAdresField.BorderSize = 1;
            this.emailAdresField.Location = new System.Drawing.Point(13, 138);
            this.emailAdresField.Margin = new System.Windows.Forms.Padding(4);
            this.emailAdresField.Multiline = false;
            this.emailAdresField.Name = "emailAdresField";
            this.emailAdresField.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.emailAdresField.PasswordChar = false;
            this.emailAdresField.PlaceholderColor = System.Drawing.Color.DimGray;
            this.emailAdresField.PlaceholderText = "Почтовый адрес";
            this.emailAdresField.Size = new System.Drawing.Size(198, 35);
            this.emailAdresField.TabIndex = 4;
            this.emailAdresField.TabStop = false;
            this.emailAdresField.Texts = "";
            this.emailAdresField.UnderlinedStyle = false;
            // 
            // newPasswordField
            // 
            this.newPasswordField.BorderColor = System.Drawing.Color.Black;
            this.newPasswordField.BorderFocusColor = System.Drawing.Color.Black;
            this.newPasswordField.BorderRadius = 15;
            this.newPasswordField.BorderSize = 1;
            this.newPasswordField.Location = new System.Drawing.Point(13, 181);
            this.newPasswordField.Margin = new System.Windows.Forms.Padding(4);
            this.newPasswordField.Multiline = false;
            this.newPasswordField.Name = "newPasswordField";
            this.newPasswordField.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.newPasswordField.PasswordChar = false;
            this.newPasswordField.PlaceholderColor = System.Drawing.Color.DimGray;
            this.newPasswordField.PlaceholderText = "Новый пароль";
            this.newPasswordField.Size = new System.Drawing.Size(198, 35);
            this.newPasswordField.TabIndex = 5;
            this.newPasswordField.TabStop = false;
            this.newPasswordField.Texts = "";
            this.newPasswordField.UnderlinedStyle = false;
            // 
            // newPasswordConfirmField
            // 
            this.newPasswordConfirmField.BorderColor = System.Drawing.Color.Black;
            this.newPasswordConfirmField.BorderFocusColor = System.Drawing.Color.Black;
            this.newPasswordConfirmField.BorderRadius = 15;
            this.newPasswordConfirmField.BorderSize = 1;
            this.newPasswordConfirmField.Location = new System.Drawing.Point(13, 224);
            this.newPasswordConfirmField.Margin = new System.Windows.Forms.Padding(4);
            this.newPasswordConfirmField.Multiline = false;
            this.newPasswordConfirmField.Name = "newPasswordConfirmField";
            this.newPasswordConfirmField.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.newPasswordConfirmField.PasswordChar = false;
            this.newPasswordConfirmField.PlaceholderColor = System.Drawing.Color.DimGray;
            this.newPasswordConfirmField.PlaceholderText = "Подтвердите пароль";
            this.newPasswordConfirmField.Size = new System.Drawing.Size(198, 35);
            this.newPasswordConfirmField.TabIndex = 6;
            this.newPasswordConfirmField.TabStop = false;
            this.newPasswordConfirmField.Texts = "";
            this.newPasswordConfirmField.UnderlinedStyle = false;
            // 
            // sendCodeButton
            // 
            this.sendCodeButton.BackColor = System.Drawing.Color.Transparent;
            this.sendCodeButton.BorderColor = System.Drawing.Color.Transparent;
            this.sendCodeButton.BorderRadius = 20;
            this.sendCodeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.sendCodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sendCodeButton.ForeColor = System.Drawing.Color.White;
            this.sendCodeButton.Location = new System.Drawing.Point(13, 268);
            this.sendCodeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendCodeButton.Name = "sendCodeButton";
            this.sendCodeButton.Size = new System.Drawing.Size(198, 42);
            this.sendCodeButton.TabIndex = 5;
            this.sendCodeButton.Text = "Отправить код";
            this.sendCodeButton.Click += new System.EventHandler(this.sendCodeButton_Click);
            // 
            // codeField
            // 
            this.codeField.BorderColor = System.Drawing.Color.Black;
            this.codeField.BorderFocusColor = System.Drawing.Color.Black;
            this.codeField.BorderRadius = 15;
            this.codeField.BorderSize = 1;
            this.codeField.Location = new System.Drawing.Point(13, 319);
            this.codeField.Margin = new System.Windows.Forms.Padding(4);
            this.codeField.Multiline = false;
            this.codeField.Name = "codeField";
            this.codeField.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.codeField.PasswordChar = false;
            this.codeField.PlaceholderColor = System.Drawing.Color.DimGray;
            this.codeField.PlaceholderText = "Введите код";
            this.codeField.Size = new System.Drawing.Size(198, 35);
            this.codeField.TabIndex = 7;
            this.codeField.TabStop = false;
            this.codeField.Texts = "";
            this.codeField.UnderlinedStyle = false;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.changePasswordButton.BorderColor = System.Drawing.Color.Transparent;
            this.changePasswordButton.BorderRadius = 20;
            this.changePasswordButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.changePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changePasswordButton.ForeColor = System.Drawing.Color.White;
            this.changePasswordButton.Location = new System.Drawing.Point(13, 363);
            this.changePasswordButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(198, 54);
            this.changePasswordButton.TabIndex = 8;
            this.changePasswordButton.Text = "Изменить пароль";
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.BackgroundImage")));
            this.guna2CircleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2CircleButton1.BorderThickness = 2;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(68, 12);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(81, 76);
            this.guna2CircleButton1.TabIndex = 99;
            // 
            // closeButton
            // 
            this.closeButton.BorderColor = System.Drawing.Color.Transparent;
            this.closeButton.BorderThickness = 2;
            this.closeButton.FillColor = System.Drawing.Color.Transparent;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(190, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closeButton.Size = new System.Drawing.Size(33, 32);
            this.closeButton.TabIndex = 100;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ResetPasswordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(224, 426);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.codeField);
            this.Controls.Add(this.sendCodeButton);
            this.Controls.Add(this.newPasswordConfirmField);
            this.Controls.Add(this.newPasswordField);
            this.Controls.Add(this.emailAdresField);
            this.Controls.Add(this.loginField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPasswordScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPasswordScreen";
            this.ResumeLayout(false);

        }

        #endregion
        private Testing.RoundTextBox loginField;
        private Testing.RoundTextBox emailAdresField;
        private Testing.RoundTextBox newPasswordField;
        private Testing.RoundTextBox newPasswordConfirmField;
        private Guna.UI2.WinForms.Guna2Button sendCodeButton;
        private Testing.RoundTextBox codeField;
        private Guna.UI2.WinForms.Guna2Button changePasswordButton;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton closeButton;
    }
}