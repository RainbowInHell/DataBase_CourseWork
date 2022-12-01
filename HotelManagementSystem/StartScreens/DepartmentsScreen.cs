using HotelManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System.Collections.Generic;
using System.Data;

namespace HotelManagementSystem.ControlScreens
{
    public partial class DepartmentsScreen : Form
    {
        private HotelDbContext? _context;
        private Department? _tempDepartment;

        private MySqlConnection? _sqlConn;
        private MySqlCommand? _cmd;

        private string selectedHotelId;

        public DepartmentsScreen()
        {
            InitializeComponent();
        }

        public DepartmentsScreen(HotelDbContext _context) : this()
        {
            this._context = _context;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _context.Database.EnsureCreated();
            _context.Departments.Load();
            _context.Hotels.Load();

            departmentsTable.DataSource = _context.Departments.Local.ToBindingList();
            hotelIdCMBox.DataSource = _context.Hotels.Local.ToBindingList();
            hotelIdCMBox.ValueMember = "HotelId";
            hotelIdCMBox.DisplayMember = "HotelName";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!ProjectHelper.AreAllTextBoxesFilled(departmentNameField.Text, departmentSalaryField.Text, departmentDescriptionField.Text))
            {
                MessageBox.Show("Все поля обязательны к заполнению.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _sqlConn = new MySqlConnection();
            _sqlConn.ConnectionString = ProjectHelper.CONNECTION_STRING;
            _cmd = new MySqlCommand();

            try
            {
                _sqlConn.Open();
                _cmd.Connection = _sqlConn;

                _cmd.CommandText = "DoesDepartmentExistInHotel";
                _cmd.CommandType = CommandType.StoredProcedure;

                _cmd.Parameters.AddWithValue("@depName", departmentNameField.Text);
                _cmd.Parameters["@depName"].Direction = ParameterDirection.Input;

                _cmd.Parameters.AddWithValue("@hotId", int.Parse(selectedHotelId));
                _cmd.Parameters["@hotId"].Direction = ParameterDirection.Input;

                _cmd.Parameters.Add("@result", MySqlDbType.Int32);
                _cmd.Parameters["@result"].Direction = ParameterDirection.Output;

                _cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error {ex.Number} has occurred: {ex.Message}");
            }
            finally { _sqlConn.Close(); }

            if ((int)_cmd.Parameters["@result"].Value == 1)
            {
                MessageBox.Show($"Отдел с именем {departmentNameField.Text} уже существует в отеле с Id {selectedHotelId}.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _tempDepartment = new Department();
            _tempDepartment.DepartmentName = departmentNameField.Text;
            _tempDepartment.DepartmentInitialSalary = int.Parse(departmentSalaryField.Text);
            _tempDepartment.DepartmentDescription = departmentDescriptionField.Text;
            _tempDepartment.HotelId = int.Parse(selectedHotelId);

            _context.Departments.Add(_tempDepartment);
            _context.SaveChanges();
        }

        private void hotelIdCMBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedHotelId = hotelIdCMBox.SelectedValue.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ProjectHelper.ClearAllFields(Controls);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!ProjectHelper.AreAllTextBoxesFilled(departmentIdField.Text))
            {
                MessageBox.Show("Поле Id Отдела обязательно к заполнению.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ProjectHelper.DeleteButtonLogic(_context, ProjectHelper.ScreenFlag.DepartmentsScreenFlag, selectedEntityId: departmentIdField.Text))
            {
                MessageBox.Show($"Отсутствует отдел с Id = {departmentIdField.Text}.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProjectHelper.Refreshing(_context, departmentsTable);
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!ProjectHelper.AreAllTextBoxesFilled(Controls))
            {
                MessageBox.Show("Все поля обязательны к заполнению.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _tempDepartment = null;
            _tempDepartment = _context.Departments.Find(long.Parse(departmentIdField.Text));

            if (_tempDepartment == null)
            {
                MessageBox.Show($"Отсутствует отдел с id = {departmentIdField.Text}.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _tempDepartment.DepartmentName = departmentNameField.Text;
            _tempDepartment.DepartmentInitialSalary = int.Parse(departmentSalaryField.Text);
            _tempDepartment.DepartmentDescription = departmentDescriptionField.Text;
            _tempDepartment.HotelId = int.Parse(selectedHotelId);

            _context.SaveChanges();

            ProjectHelper.Refreshing(_context, departmentsTable);
        }

        private void searchDepartmentById_Click(object sender, EventArgs e)
        {
            if (!ProjectHelper.AreAllTextBoxesFilled(departmentIdField.Text))
            {
                MessageBox.Show("Поле Id обязательно к заполнению.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _tempDepartment = null;
            _tempDepartment = _context.Departments.AsNoTracking().FirstOrDefault(dep => dep.DepartmentId == int.Parse(departmentIdField.Text));

            if (_tempDepartment == null)
            {
                MessageBox.Show($"Отсутствует отдел с id = {departmentIdField.Text}.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            departmentNameField.Text = _tempDepartment.DepartmentName;
            departmentSalaryField.Text = _tempDepartment.DepartmentInitialSalary.ToString();
            departmentDescriptionField.Text = _tempDepartment.DepartmentDescription;
            //(hotelIdCMBox.SelectedItem as Hotel).HotelName = _context.Hotels.AsNoTracking().FirstOrDefault(hotel => hotel.HotelId == _tempDepartment.HotelId).HotelName;
        }
    }
}