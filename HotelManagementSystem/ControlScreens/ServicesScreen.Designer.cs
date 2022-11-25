namespace HotelManagementSystem.ControlScreens
{
    partial class ServicesScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.departmentTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clearButton = new Guna.UI2.WinForms.Guna2Button();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.departmentId = new System.Windows.Forms.Label();
            this.serviceIdField = new System.Windows.Forms.TextBox();
            this.serviceNameField = new System.Windows.Forms.TextBox();
            this.serviceDescriptionField = new System.Windows.Forms.TextBox();
            this.seriveCostField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 36);
            this.label1.TabIndex = 37;
            this.label1.Text = "Сервисы";
            // 
            // departmentTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.departmentTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.departmentTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.departmentTable.ColumnHeadersHeight = 40;
            this.departmentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.departmentTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.departmentTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.departmentTable.Location = new System.Drawing.Point(36, 79);
            this.departmentTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departmentTable.Name = "departmentTable";
            this.departmentTable.ReadOnly = true;
            this.departmentTable.RowHeadersVisible = false;
            this.departmentTable.RowHeadersWidth = 51;
            this.departmentTable.RowTemplate.Height = 35;
            this.departmentTable.Size = new System.Drawing.Size(953, 610);
            this.departmentTable.TabIndex = 80;
            this.departmentTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.departmentTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.departmentTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.departmentTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.departmentTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.departmentTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.departmentTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.departmentTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.departmentTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.departmentTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.departmentTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.departmentTable.ThemeStyle.HeaderStyle.Height = 40;
            this.departmentTable.ThemeStyle.ReadOnly = true;
            this.departmentTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.departmentTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.departmentTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmentTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.departmentTable.ThemeStyle.RowsStyle.Height = 35;
            this.departmentTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.departmentTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.BorderRadius = 20;
            this.clearButton.BorderThickness = 1;
            this.clearButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clearButton.Location = new System.Drawing.Point(1012, 440);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(149, 60);
            this.clearButton.TabIndex = 105;
            this.clearButton.Text = "ОЧИСТИТЬ";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Transparent;
            this.updateButton.BorderRadius = 20;
            this.updateButton.BorderThickness = 1;
            this.updateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.updateButton.Location = new System.Drawing.Point(1169, 370);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(149, 60);
            this.updateButton.TabIndex = 104;
            this.updateButton.Text = "ОБНОВИТЬ";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BorderRadius = 20;
            this.deleteButton.BorderThickness = 1;
            this.deleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.Location = new System.Drawing.Point(1169, 440);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(149, 60);
            this.deleteButton.TabIndex = 103;
            this.deleteButton.Text = "УДАЛИТЬ";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BorderRadius = 20;
            this.addButton.BorderThickness = 1;
            this.addButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.Location = new System.Drawing.Point(1012, 370);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(149, 60);
            this.addButton.TabIndex = 102;
            this.addButton.Text = "ДОБАВИТЬ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label3.Location = new System.Drawing.Point(990, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 100;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(990, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 98;
            this.label2.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label4.Location = new System.Drawing.Point(990, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 96;
            this.label4.Text = "Название сервиса";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BorderThickness = 2;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.Location = new System.Drawing.Point(1107, 91);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(53, 43);
            this.guna2CircleButton1.TabIndex = 95;
            // 
            // departmentId
            // 
            this.departmentId.AutoSize = true;
            this.departmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.departmentId.Location = new System.Drawing.Point(990, 80);
            this.departmentId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmentId.Name = "departmentId";
            this.departmentId.Size = new System.Drawing.Size(109, 25);
            this.departmentId.TabIndex = 93;
            this.departmentId.Text = "Id Сервиса";
            // 
            // serviceIdField
            // 
            this.serviceIdField.Location = new System.Drawing.Point(996, 107);
            this.serviceIdField.Name = "serviceIdField";
            this.serviceIdField.Size = new System.Drawing.Size(109, 27);
            this.serviceIdField.TabIndex = 106;
            // 
            // serviceNameField
            // 
            this.serviceNameField.Location = new System.Drawing.Point(996, 178);
            this.serviceNameField.Name = "serviceNameField";
            this.serviceNameField.Size = new System.Drawing.Size(177, 27);
            this.serviceNameField.TabIndex = 107;
            // 
            // serviceDescriptionField
            // 
            this.serviceDescriptionField.Location = new System.Drawing.Point(996, 248);
            this.serviceDescriptionField.Name = "serviceDescriptionField";
            this.serviceDescriptionField.Size = new System.Drawing.Size(102, 27);
            this.serviceDescriptionField.TabIndex = 108;
            // 
            // seriveCostField
            // 
            this.seriveCostField.Location = new System.Drawing.Point(996, 318);
            this.seriveCostField.Name = "seriveCostField";
            this.seriveCostField.Size = new System.Drawing.Size(102, 27);
            this.seriveCostField.TabIndex = 109;
            // 
            // ServicesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1344, 726);
            this.Controls.Add(this.seriveCostField);
            this.Controls.Add(this.serviceDescriptionField);
            this.Controls.Add(this.serviceNameField);
            this.Controls.Add(this.serviceIdField);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.departmentId);
            this.Controls.Add(this.departmentTable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(35, 84);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServicesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServicesScreen";
            ((System.ComponentModel.ISupportInitialize)(this.departmentTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView departmentTable;
        private Guna.UI2.WinForms.Guna2Button clearButton;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Label departmentId;
        private TextBox serviceIdField;
        private TextBox serviceNameField;
        private TextBox serviceDescriptionField;
        private TextBox seriveCostField;
    }
}