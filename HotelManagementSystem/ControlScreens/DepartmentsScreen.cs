using HotelManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagementSystem.ControlScreens
{
    public partial class DepartmentsScreen : Form
    {
        private HotelDbContext? _context;
        private Department? _tempDepartment;
        private int selectedHotelId;

        public DepartmentsScreen()
        {
            InitializeComponent();
        }

        public DepartmentsScreen(HotelDbContext _context) : this()
        {
            this._context= _context;
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
            MessageBox.Show(hotelIdCMBox.SelectedValue.ToString());

            //foreach (Hotel hotel in _context.Hotels.Local.ToBindingList())
            //{
            //    MessageBox.Show(hotel.HotelName);
            //}
            //hotelIdCMBox.DataSource = _context.Hotels.Local.ToBindingList();
            //hotelIdCMBox.ValueMember = "HotelId";
            //hotelIdCMBox.DisplayMember = "HotelName";
        }
    }
}
