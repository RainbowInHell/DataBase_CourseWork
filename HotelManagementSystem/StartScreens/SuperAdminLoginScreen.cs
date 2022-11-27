using System.Data;
using System.ComponentModel;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.StartScreens
{
    public partial class SuperAdminLoginScreen : Form
    {
        private HotelDbContext? _context;
        private AdminDashboard? _adminDashboard;
        private UserLoginScreen? _userLoginScreen;

        public SuperAdminLoginScreen()
        {
            InitializeComponent();
        }

        public SuperAdminLoginScreen(HotelDbContext _context) : this()
        {
            this._context = _context;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            _context.Database.EnsureCreated();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (!ProjectHelper.AreAllTextBoxesFilled(adminLoginField.Texts, adminPasswordField.Texts))
            {
                MessageBox.Show("Все поля обязательны к заполнению.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var status = _context?.Admins.Where(admin => admin.AdminUserName == adminLoginField.Texts && admin.AdminPassword == adminPasswordField.Texts).FirstOrDefault();

            if (status != null)
            {
                this.Close();

                _adminDashboard = new AdminDashboard(_context);
                _adminDashboard.Show();
            }
            else
            {
                MessageBox.Show("Неверные данные!", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void returnBackButton_Click(object sender, EventArgs e)
        {
            this.Close();

            _userLoginScreen = new UserLoginScreen();
            _userLoginScreen.Show();
        }
    }
}
