namespace HotelManagementSystem.CalculationScreens
{
    partial class CheckoutScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutScreen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.bookingIdCMBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.paymentTypeCmbox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.payButton = new Guna.UI2.WinForms.Guna2Button();
            this.searchButton = new Guna.UI2.WinForms.Guna2Button();
            this.checkoutTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.paymentIdField = new System.Windows.Forms.TextBox();
            this.statusField = new System.Windows.Forms.TextBox();
            this.amountField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 36);
            this.label1.TabIndex = 38;
            this.label1.Text = "Оформление оплаты";
            // 
            // bookingIdCMBox
            // 
            this.bookingIdCMBox.BackColor = System.Drawing.Color.Transparent;
            this.bookingIdCMBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bookingIdCMBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookingIdCMBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookingIdCMBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookingIdCMBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookingIdCMBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.bookingIdCMBox.ItemHeight = 30;
            this.bookingIdCMBox.Location = new System.Drawing.Point(993, 174);
            this.bookingIdCMBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookingIdCMBox.Name = "bookingIdCMBox";
            this.bookingIdCMBox.Size = new System.Drawing.Size(236, 36);
            this.bookingIdCMBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.bookingIdCMBox.TabIndex = 71;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BorderThickness = 2;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.Location = new System.Drawing.Point(1106, 77);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(53, 43);
            this.guna2CircleButton1.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label4.Location = new System.Drawing.Point(988, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 69;
            this.label4.Text = "Id Брони";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(988, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 67;
            this.label2.Text = "Id Оплаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label3.Location = new System.Drawing.Point(988, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 72;
            this.label3.Text = "Тип оплаты";
            // 
            // paymentTypeCmbox
            // 
            this.paymentTypeCmbox.BackColor = System.Drawing.Color.Transparent;
            this.paymentTypeCmbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.paymentTypeCmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentTypeCmbox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paymentTypeCmbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paymentTypeCmbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentTypeCmbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.paymentTypeCmbox.ItemHeight = 30;
            this.paymentTypeCmbox.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.paymentTypeCmbox.Location = new System.Drawing.Point(992, 260);
            this.paymentTypeCmbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentTypeCmbox.Name = "paymentTypeCmbox";
            this.paymentTypeCmbox.Size = new System.Drawing.Size(236, 36);
            this.paymentTypeCmbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.paymentTypeCmbox.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label5.Location = new System.Drawing.Point(992, 320);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 74;
            this.label5.Text = "Статус";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label6.Location = new System.Drawing.Point(988, 398);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 25);
            this.label6.TabIndex = 76;
            this.label6.Text = "Итоговая сумма к оплате";
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.Color.Transparent;
            this.payButton.BorderRadius = 20;
            this.payButton.BorderThickness = 1;
            this.payButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.payButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.payButton.Location = new System.Drawing.Point(992, 472);
            this.payButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(145, 55);
            this.payButton.TabIndex = 84;
            this.payButton.Text = "ОПЛАТИТЬ";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BorderRadius = 20;
            this.searchButton.BorderThickness = 1;
            this.searchButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchButton.Location = new System.Drawing.Point(1145, 472);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(145, 55);
            this.searchButton.TabIndex = 87;
            this.searchButton.Text = "ОЧИСТИТЬ";
            // 
            // checkoutTable
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.checkoutTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkoutTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.checkoutTable.ColumnHeadersHeight = 40;
            this.checkoutTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.checkoutTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.checkoutTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.checkoutTable.Location = new System.Drawing.Point(41, 65);
            this.checkoutTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkoutTable.Name = "checkoutTable";
            this.checkoutTable.ReadOnly = true;
            this.checkoutTable.RowHeadersVisible = false;
            this.checkoutTable.RowHeadersWidth = 51;
            this.checkoutTable.RowTemplate.Height = 35;
            this.checkoutTable.Size = new System.Drawing.Size(944, 604);
            this.checkoutTable.TabIndex = 116;
            this.checkoutTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.checkoutTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.checkoutTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.checkoutTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.checkoutTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.checkoutTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.checkoutTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.checkoutTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.checkoutTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.checkoutTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkoutTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.checkoutTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.checkoutTable.ThemeStyle.HeaderStyle.Height = 40;
            this.checkoutTable.ThemeStyle.ReadOnly = true;
            this.checkoutTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.checkoutTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.checkoutTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkoutTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.checkoutTable.ThemeStyle.RowsStyle.Height = 35;
            this.checkoutTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.checkoutTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // paymentIdField
            // 
            this.paymentIdField.Location = new System.Drawing.Point(992, 93);
            this.paymentIdField.Name = "paymentIdField";
            this.paymentIdField.Size = new System.Drawing.Size(107, 27);
            this.paymentIdField.TabIndex = 117;
            // 
            // statusField
            // 
            this.statusField.Location = new System.Drawing.Point(992, 348);
            this.statusField.Name = "statusField";
            this.statusField.Size = new System.Drawing.Size(78, 27);
            this.statusField.TabIndex = 118;
            this.statusField.Text = "Оплачен";
            // 
            // amountField
            // 
            this.amountField.Location = new System.Drawing.Point(992, 426);
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(254, 27);
            this.amountField.TabIndex = 119;
            // 
            // CheckoutScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1311, 689);
            this.Controls.Add(this.amountField);
            this.Controls.Add(this.statusField);
            this.Controls.Add(this.paymentIdField);
            this.Controls.Add(this.checkoutTable);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paymentTypeCmbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookingIdCMBox);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(118, 123);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CheckoutScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CheckoutScreen";
            ((System.ComponentModel.ISupportInitialize)(this.checkoutTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox bookingIdCMBox;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox paymentTypeCmbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button payButton;
        private Guna.UI2.WinForms.Guna2Button searchButton;
        private Guna.UI2.WinForms.Guna2DataGridView checkoutTable;
        private TextBox paymentIdField;
        private TextBox statusField;
        private TextBox amountField;
    }
}