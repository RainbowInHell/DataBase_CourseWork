namespace HotelManagementSystem.RoomScreens
{
    partial class RoomTypeScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomTypeScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.roomtypeTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clearButton = new Guna.UI2.WinForms.Guna2Button();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.departmentId = new System.Windows.Forms.Label();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.smokeCMBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.petCMBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.typeIdField = new System.Windows.Forms.TextBox();
            this.typeNameField = new System.Windows.Forms.TextBox();
            this.typeCostField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 36);
            this.label1.TabIndex = 39;
            this.label1.Text = "Типы номеров";
            // 
            // roomtypeTable
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.roomtypeTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomtypeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.roomtypeTable.ColumnHeadersHeight = 40;
            this.roomtypeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomtypeTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.roomtypeTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomtypeTable.Location = new System.Drawing.Point(56, 74);
            this.roomtypeTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomtypeTable.Name = "roomtypeTable";
            this.roomtypeTable.ReadOnly = true;
            this.roomtypeTable.RowHeadersVisible = false;
            this.roomtypeTable.RowHeadersWidth = 51;
            this.roomtypeTable.RowTemplate.Height = 35;
            this.roomtypeTable.Size = new System.Drawing.Size(671, 466);
            this.roomtypeTable.TabIndex = 80;
            this.roomtypeTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.roomtypeTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.roomtypeTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.roomtypeTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.roomtypeTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.roomtypeTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.roomtypeTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomtypeTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.roomtypeTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.roomtypeTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roomtypeTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.roomtypeTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.roomtypeTable.ThemeStyle.HeaderStyle.Height = 40;
            this.roomtypeTable.ThemeStyle.ReadOnly = true;
            this.roomtypeTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.roomtypeTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.roomtypeTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomtypeTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.roomtypeTable.ThemeStyle.RowsStyle.Height = 35;
            this.roomtypeTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomtypeTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.BorderRadius = 20;
            this.clearButton.BorderThickness = 1;
            this.clearButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clearButton.Location = new System.Drawing.Point(807, 439);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(125, 46);
            this.clearButton.TabIndex = 105;
            this.clearButton.Text = "ОЧИСТИТЬ";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Transparent;
            this.updateButton.BorderRadius = 20;
            this.updateButton.BorderThickness = 1;
            this.updateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.updateButton.Location = new System.Drawing.Point(940, 383);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(125, 46);
            this.updateButton.TabIndex = 104;
            this.updateButton.Text = "ОБНОВИТЬ";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BorderRadius = 20;
            this.deleteButton.BorderThickness = 1;
            this.deleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.Location = new System.Drawing.Point(940, 439);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(125, 46);
            this.deleteButton.TabIndex = 103;
            this.deleteButton.Text = "УДАЛИТЬ";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BorderRadius = 20;
            this.addButton.BorderThickness = 1;
            this.addButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.Location = new System.Drawing.Point(807, 383);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 46);
            this.addButton.TabIndex = 102;
            this.addButton.Text = "ДОБАВИТЬ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(748, 221);
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
            this.label4.Location = new System.Drawing.Point(748, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 25);
            this.label4.TabIndex = 96;
            this.label4.Text = "Наименование типа номера";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BorderThickness = 2;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.Location = new System.Drawing.Point(909, 56);
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
            this.departmentId.Location = new System.Drawing.Point(748, 74);
            this.departmentId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmentId.Name = "departmentId";
            this.departmentId.Size = new System.Drawing.Size(153, 25);
            this.departmentId.TabIndex = 93;
            this.departmentId.Text = "Id Типа номера";
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.BorderThickness = 2;
            this.guna2CircleButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Location = new System.Drawing.Point(1113, 19);
            this.guna2CircleButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(33, 40);
            this.guna2CircleButton2.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label5.Location = new System.Drawing.Point(748, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 107;
            this.label5.Text = "Разрешено курить";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label6.Location = new System.Drawing.Point(940, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 25);
            this.label6.TabIndex = 108;
            this.label6.Text = "Разрешены животные";
            // 
            // smokeCMBox
            // 
            this.smokeCMBox.BackColor = System.Drawing.Color.Transparent;
            this.smokeCMBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.smokeCMBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smokeCMBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.smokeCMBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.smokeCMBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.smokeCMBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.smokeCMBox.ItemHeight = 30;
            this.smokeCMBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.smokeCMBox.Location = new System.Drawing.Point(748, 318);
            this.smokeCMBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.smokeCMBox.Name = "smokeCMBox";
            this.smokeCMBox.Size = new System.Drawing.Size(180, 36);
            this.smokeCMBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.smokeCMBox.TabIndex = 111;
            // 
            // petCMBox
            // 
            this.petCMBox.BackColor = System.Drawing.Color.Transparent;
            this.petCMBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.petCMBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.petCMBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.petCMBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.petCMBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.petCMBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.petCMBox.ItemHeight = 30;
            this.petCMBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.petCMBox.Location = new System.Drawing.Point(940, 318);
            this.petCMBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.petCMBox.Name = "petCMBox";
            this.petCMBox.Size = new System.Drawing.Size(180, 36);
            this.petCMBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.petCMBox.TabIndex = 112;
            // 
            // typeIdField
            // 
            this.typeIdField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeIdField.Location = new System.Drawing.Point(748, 102);
            this.typeIdField.Name = "typeIdField";
            this.typeIdField.Size = new System.Drawing.Size(153, 20);
            this.typeIdField.TabIndex = 113;
            // 
            // typeNameField
            // 
            this.typeNameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeNameField.Location = new System.Drawing.Point(748, 175);
            this.typeNameField.Name = "typeNameField";
            this.typeNameField.Size = new System.Drawing.Size(274, 20);
            this.typeNameField.TabIndex = 114;
            // 
            // typeCostField
            // 
            this.typeCostField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeCostField.Location = new System.Drawing.Point(748, 249);
            this.typeCostField.Name = "typeCostField";
            this.typeCostField.Size = new System.Drawing.Size(58, 20);
            this.typeCostField.TabIndex = 115;
            // 
            // RoomTypeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1163, 554);
            this.Controls.Add(this.typeCostField);
            this.Controls.Add(this.typeNameField);
            this.Controls.Add(this.typeIdField);
            this.Controls.Add(this.petCMBox);
            this.Controls.Add(this.smokeCMBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.departmentId);
            this.Controls.Add(this.roomtypeTable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RoomTypeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomType";
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView roomtypeTable;
        private Guna.UI2.WinForms.Guna2Button clearButton;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Label departmentId;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox smokeCMBox;
        private Guna.UI2.WinForms.Guna2ComboBox petCMBox;
        private TextBox typeIdField;
        private TextBox typeNameField;
        private TextBox typeCostField;
    }
}