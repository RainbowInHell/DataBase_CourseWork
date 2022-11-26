using HotelManagementSystem.Models;
using HotelManagementSystem.ControlScreens;

namespace HotelManagementSystem.StartScreens
{
    public partial class AdminDashboard : Form
    {
        private HotelDbContext? _context;
        private AdminHotelsViewScreen? _hotelsScreen;
        private EmployeesScreen? _employeesScreen;
        private SuperAdminLoginScreen? _superAdminLoginScreen;

        public AdminDashboard()
        {
            InitializeComponent();
        }

        public AdminDashboard(HotelDbContext _context) : this()
        {
            this._context = _context;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _context?.Database.EnsureCreated();
        }

        private void hotelsButton_Click(object sender, EventArgs e)
        {
            _hotelsScreen = new AdminHotelsViewScreen(_context);

            ProjectHelper.FillPanelWithWindow(mainPanel, _hotelsScreen, ProjectHelper.ScreenFlag.AdminHotelsViewScreenFlag);
        }

        private void employessButton_Click(object sender, EventArgs e)
        {
            _employeesScreen= new EmployeesScreen();

            ProjectHelper.FillPanelWithWindow(mainPanel, _employeesScreen, ProjectHelper.ScreenFlag.EmployeesScreenFlag);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();

            _superAdminLoginScreen = new SuperAdminLoginScreen(_context);
            _superAdminLoginScreen.Show();
        }
    }
}
