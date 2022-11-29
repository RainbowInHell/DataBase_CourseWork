using HotelManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagementSystem.ControlScreens
{
    public partial class DepartmentsScreen : Form
    {
        private HotelDbContext? _context;
        private Department? _tempDepartment;
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

            _tempDepartment = new Department();
            _tempDepartment.DepartmentName = departmentNameField.Text;
            _tempDepartment.DepartmentInitialSalary = int.Parse(departmentSalaryField.Text);
            _tempDepartment.DepartmentDescription = departmentDescriptionField.Text;
            _tempDepartment.HotelId = int.Parse(selectedHotelId);

            _context.Departments.Add(_tempDepartment);
            _context.SaveChanges();

            //if (_context.Departments.Any(dep => dep.DepartmentName == departmentNameField.Text && dep.HotelId == int.Parse(selectedHotelId)))
            //{
            //    MessageBox.Show("Test");
            //    return;
            //}
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

            departmentsTable.DataSource = _context.Departments.Local.ToBindingList();
            departmentsTable.Refresh();
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
            _context.Departments.Load();

            departmentsTable.DataSource = _context.Departments.Local.ToBindingList();
            departmentsTable.Refresh();
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