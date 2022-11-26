using System.ComponentModel;
using HotelManagementSystem.Models;
using HotelManagementSystem.ControlScreens;

namespace HotelManagementSystem.StartScreens
{
    public partial class UserLoginScreen : Form
    {
        private HotelDbContext? _context;
        private SuperAdminLoginScreen? _superAdminLoginScreen;
        private DashboardScreen? _dashboardScreen;

        public UserLoginScreen()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _context = new HotelDbContext();
            _context.Database.EnsureCreated();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _context?.Dispose();
            _context = null;
        }

        private void toAdminLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            _superAdminLoginScreen = new SuperAdminLoginScreen(_context);
            _superAdminLoginScreen.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
