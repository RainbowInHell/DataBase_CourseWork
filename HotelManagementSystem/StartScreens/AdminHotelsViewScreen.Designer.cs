namespace HotelManagementSystem.ControlScreens
{
    partial class AdminHotelsViewScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHotelsViewScreen));
            this.label32 = new System.Windows.Forms.Label();
            this.tableOfHotels = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchHotelByIdButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new Guna.UI2.WinForms.Guna2Button();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.hotelIdField = new System.Windows.Forms.TextBox();
            this.hotelNameField = new System.Windows.Forms.TextBox();
            this.hotelContactNumberField = new System.Windows.Forms.TextBox();
            this.hotelEmaildField = new System.Windows.Forms.TextBox();
            this.hotelWebSiteField = new System.Windows.Forms.TextBox();
            this.hotelDescriptionField = new System.Windows.Forms.TextBox();
            this.hotelFloorsCountField = new System.Windows.Forms.TextBox();
            this.hotelCityField = new System.Windows.Forms.TextBox();
            this.hotelCapacityField = new System.Windows.Forms.TextBox();
            this.hotelAdresField = new System.Windows.Forms.TextBox();
            this.hotelCountryField = new System.Windows.Forms.TextBox();
            this.hotelZipCodeField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableOfHotels)).BeginInit();
            this.SuspendLayout();
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label32.Location = new System.Drawing.Point(1026, 225);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(60, 25);
            this.label32.TabIndex = 114;
            this.label32.Text = "Email";
            // 
            // tableOfHotels
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.tableOfHotels.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableOfHotels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tableOfHotels.ColumnHeadersHeight = 40;
            this.tableOfHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableOfHotels.DefaultCellStyle = dataGridViewCellStyle6;
            this.tableOfHotels.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableOfHotels.Location = new System.Drawing.Point(43, 79);
            this.tableOfHotels.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableOfHotels.Name = "tableOfHotels";
            this.tableOfHotels.ReadOnly = true;
            this.tableOfHotels.RowHeadersVisible = false;
            this.tableOfHotels.RowHeadersWidth = 51;
            this.tableOfHotels.RowTemplate.Height = 35;
            this.tableOfHotels.Size = new System.Drawing.Size(975, 596);
            this.tableOfHotels.TabIndex = 113;
            this.tableOfHotels.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableOfHotels.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableOfHotels.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableOfHotels.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableOfHotels.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableOfHotels.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tableOfHotels.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableOfHotels.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.tableOfHotels.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableOfHotels.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableOfHotels.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableOfHotels.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableOfHotels.ThemeStyle.HeaderStyle.Height = 40;
            this.tableOfHotels.ThemeStyle.ReadOnly = true;
            this.tableOfHotels.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableOfHotels.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableOfHotels.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableOfHotels.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableOfHotels.ThemeStyle.RowsStyle.Height = 35;
            this.tableOfHotels.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableOfHotels.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label14.Location = new System.Drawing.Point(1026, 303);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 25);
            this.label14.TabIndex = 111;
            this.label14.Text = "Описание";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label12.Location = new System.Drawing.Point(1205, 519);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 25);
            this.label12.TabIndex = 104;
            this.label12.Text = "Почтовый индекс";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label11.Location = new System.Drawing.Point(1205, 448);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 25);
            this.label11.TabIndex = 102;
            this.label11.Text = "Страна";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label9.Location = new System.Drawing.Point(1205, 373);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 98;
            this.label9.Text = "Город";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label8.Location = new System.Drawing.Point(1026, 519);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 96;
            this.label8.Text = "Адрес";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label7.Location = new System.Drawing.Point(1026, 448);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 94;
            this.label7.Text = "Вместимость";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label6.Location = new System.Drawing.Point(1205, 303);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 25);
            this.label6.TabIndex = 92;
            this.label6.Text = "Количество этажей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label3.Location = new System.Drawing.Point(1205, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 88;
            this.label3.Text = "Контактный номер";
            // 
            // searchHotelByIdButton
            // 
            this.searchHotelByIdButton.BorderThickness = 2;
            this.searchHotelByIdButton.FillColor = System.Drawing.Color.Transparent;
            this.searchHotelByIdButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchHotelByIdButton.ForeColor = System.Drawing.Color.White;
            this.searchHotelByIdButton.Image = ((System.Drawing.Image)(resources.GetObject("searchHotelByIdButton.Image")));
            this.searchHotelByIdButton.Location = new System.Drawing.Point(1158, 92);
            this.searchHotelByIdButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchHotelByIdButton.Name = "searchHotelByIdButton";
            this.searchHotelByIdButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.searchHotelByIdButton.Size = new System.Drawing.Size(53, 43);
            this.searchHotelByIdButton.TabIndex = 87;
            this.searchHotelByIdButton.Click += new System.EventHandler(this.searchHotelByIdButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label4.Location = new System.Drawing.Point(1026, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 85;
            this.label4.Text = "Название отеля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(1026, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "Id Отеля";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 36);
            this.label1.TabIndex = 82;
            this.label1.Text = "Отели";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.BorderRadius = 20;
            this.clearButton.BorderThickness = 1;
            this.clearButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clearButton.Location = new System.Drawing.Point(1043, 644);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(144, 52);
            this.clearButton.TabIndex = 119;
            this.clearButton.Text = "ОЧИСТИТЬ";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Transparent;
            this.updateButton.BorderRadius = 20;
            this.updateButton.BorderThickness = 1;
            this.updateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.updateButton.Location = new System.Drawing.Point(1205, 582);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(144, 52);
            this.updateButton.TabIndex = 118;
            this.updateButton.Text = "ОБНОВИТЬ";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BorderRadius = 20;
            this.deleteButton.BorderThickness = 1;
            this.deleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.Location = new System.Drawing.Point(1205, 644);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(144, 52);
            this.deleteButton.TabIndex = 117;
            this.deleteButton.Text = "УДАЛИТЬ";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BorderRadius = 20;
            this.addButton.BorderThickness = 1;
            this.addButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.Location = new System.Drawing.Point(1043, 582);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(144, 52);
            this.addButton.TabIndex = 116;
            this.addButton.Text = "ДОБАВИТЬ";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // hotelIdField
            // 
            this.hotelIdField.Location = new System.Drawing.Point(1026, 108);
            this.hotelIdField.Name = "hotelIdField";
            this.hotelIdField.Size = new System.Drawing.Size(125, 27);
            this.hotelIdField.TabIndex = 120;
            // 
            // hotelNameField
            // 
            this.hotelNameField.Location = new System.Drawing.Point(1026, 180);
            this.hotelNameField.Name = "hotelNameField";
            this.hotelNameField.Size = new System.Drawing.Size(161, 27);
            this.hotelNameField.TabIndex = 121;
            // 
            // hotelContactNumberField
            // 
            this.hotelContactNumberField.Location = new System.Drawing.Point(1205, 180);
            this.hotelContactNumberField.Name = "hotelContactNumberField";
            this.hotelContactNumberField.Size = new System.Drawing.Size(192, 27);
            this.hotelContactNumberField.TabIndex = 122;
            // 
            // hotelEmaildField
            // 
            this.hotelEmaildField.Location = new System.Drawing.Point(1026, 253);
            this.hotelEmaildField.Name = "hotelEmaildField";
            this.hotelEmaildField.Size = new System.Drawing.Size(161, 27);
            this.hotelEmaildField.TabIndex = 123;
            // 
            // hotelWebSiteField
            // 
            this.hotelWebSiteField.Location = new System.Drawing.Point(1205, 253);
            this.hotelWebSiteField.Name = "hotelWebSiteField";
            this.hotelWebSiteField.Size = new System.Drawing.Size(192, 27);
            this.hotelWebSiteField.TabIndex = 124;
            // 
            // hotelDescriptionField
            // 
            this.hotelDescriptionField.Location = new System.Drawing.Point(1026, 331);
            this.hotelDescriptionField.Multiline = true;
            this.hotelDescriptionField.Name = "hotelDescriptionField";
            this.hotelDescriptionField.Size = new System.Drawing.Size(161, 97);
            this.hotelDescriptionField.TabIndex = 125;
            // 
            // hotelFloorsCountField
            // 
            this.hotelFloorsCountField.Location = new System.Drawing.Point(1205, 331);
            this.hotelFloorsCountField.Name = "hotelFloorsCountField";
            this.hotelFloorsCountField.Size = new System.Drawing.Size(125, 27);
            this.hotelFloorsCountField.TabIndex = 126;
            // 
            // hotelCityField
            // 
            this.hotelCityField.Location = new System.Drawing.Point(1205, 401);
            this.hotelCityField.Name = "hotelCityField";
            this.hotelCityField.Size = new System.Drawing.Size(192, 27);
            this.hotelCityField.TabIndex = 127;
            // 
            // hotelCapacityField
            // 
            this.hotelCapacityField.Location = new System.Drawing.Point(1026, 476);
            this.hotelCapacityField.Name = "hotelCapacityField";
            this.hotelCapacityField.Size = new System.Drawing.Size(161, 27);
            this.hotelCapacityField.TabIndex = 128;
            // 
            // hotelAdresField
            // 
            this.hotelAdresField.Location = new System.Drawing.Point(1026, 547);
            this.hotelAdresField.Name = "hotelAdresField";
            this.hotelAdresField.Size = new System.Drawing.Size(161, 27);
            this.hotelAdresField.TabIndex = 129;
            // 
            // hotelCountryField
            // 
            this.hotelCountryField.Location = new System.Drawing.Point(1205, 476);
            this.hotelCountryField.Name = "hotelCountryField";
            this.hotelCountryField.Size = new System.Drawing.Size(192, 27);
            this.hotelCountryField.TabIndex = 130;
            // 
            // hotelZipCodeField
            // 
            this.hotelZipCodeField.Location = new System.Drawing.Point(1205, 547);
            this.hotelZipCodeField.Name = "hotelZipCodeField";
            this.hotelZipCodeField.Size = new System.Drawing.Size(192, 27);
            this.hotelZipCodeField.TabIndex = 131;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label5.Location = new System.Drawing.Point(1205, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 132;
            this.label5.Text = "Веб-сайт";
            // 
            // AdminHotelsViewScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 714);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hotelZipCodeField);
            this.Controls.Add(this.hotelCountryField);
            this.Controls.Add(this.hotelAdresField);
            this.Controls.Add(this.hotelCapacityField);
            this.Controls.Add(this.hotelCityField);
            this.Controls.Add(this.hotelFloorsCountField);
            this.Controls.Add(this.hotelDescriptionField);
            this.Controls.Add(this.hotelWebSiteField);
            this.Controls.Add(this.hotelEmaildField);
            this.Controls.Add(this.hotelContactNumberField);
            this.Controls.Add(this.hotelNameField);
            this.Controls.Add(this.hotelIdField);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.tableOfHotels);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchHotelByIdButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminHotelsViewScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HotelChainPage";
            ((System.ComponentModel.ISupportInitialize)(this.tableOfHotels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label32;
        private Guna.UI2.WinForms.Guna2DataGridView tableOfHotels;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CircleButton searchHotelByIdButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button clearButton;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private TextBox hotelIdField;
        private TextBox hotelNameField;
        private TextBox hotelContactNumberField;
        private TextBox hotelEmaildField;
        private TextBox hotelWebSiteField;
        private TextBox hotelDescriptionField;
        private TextBox hotelFloorsCountField;
        private TextBox hotelCityField;
        private TextBox hotelCapacityField;
        private TextBox hotelAdresField;
        private TextBox hotelCountryField;
        private TextBox hotelZipCodeField;
        private Label label5;
    }
}