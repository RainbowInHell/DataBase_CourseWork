using HotelManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.ControlScreens
{
    public partial class EmployeesScreen : Form
    {
        private HotelDbContext? _context;
        private DepartmentsScreen? _departmentsScreen;

        public EmployeesScreen()
        {
            InitializeComponent();
        }

        public EmployeesScreen(HotelDbContext _context) : this()
        {
            this._context = _context;
        }

        private void addDepartmentButton_Click(object sender, EventArgs e)
        {
            _departmentsScreen = new DepartmentsScreen(_context);
            _departmentsScreen.Show();
        }
    }
}
