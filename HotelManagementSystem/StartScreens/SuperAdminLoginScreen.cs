using System.Data;
using System.ComponentModel;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.StartScreens
{
    public partial class SuperAdminLoginScreen : Form
    {
        private HotelDbContext? _context;
        private AdminDashboard? _adminDashboard;

        public SuperAdminLoginScreen()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this._context = new HotelDbContext();
            this._context.Database.EnsureCreated();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this._context?.Dispose();
            this._context = null;

            this._adminDashboard?.Dispose();
            this._adminDashboard = null;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (VerifyFieldsHelper.IsAnyOfFieldsNullOrEmpty(adminLoginField.Texts, adminPasswordField.Texts))
            {
                MessageBox.Show("Все поля обязательны к заполнению.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var status = _context.Admins.Where(admin => admin.AdminUserName == adminLoginField.Texts && admin.AdminPassword == adminPasswordField.Texts).FirstOrDefault();

            if (status != null)
            {
                this.Hide();

                _adminDashboard = new AdminDashboard();
                _adminDashboard.Show();
            }
            else
            {
                MessageBox.Show("Неверные данные!", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
