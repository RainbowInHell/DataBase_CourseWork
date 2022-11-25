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

namespace HotelManagementSystem.StartScreens
{
    public partial class SuperAdminLoginScreen : Form
    {
        HotelDbContext _context = null;

        public SuperAdminLoginScreen()
        {
            InitializeComponent();
            _context = new HotelDbContext();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            var status = _context.Admins.Where(admin => admin.AdminUserName == adminLoginField.Texts && admin.AdminPassword == adminPasswordField.Texts).FirstOrDefault();

            if (status != null)
            {
                this.Hide();

                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
            }
        }
    }
}
