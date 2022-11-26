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

namespace HotelManagementSystem.ControlScreens
{
    public partial class AdminHotelsViewScreen : Form
    {
        private HotelDbContext? _context;

        public AdminHotelsViewScreen()
        {
            InitializeComponent();
        }

        public AdminHotelsViewScreen(HotelDbContext _context) : this()
        {
            this._context = _context;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _context = new HotelDbContext();
            _context.Database.EnsureCreated();
            _context.Hotels.Load();
            hotelsTable.DataSource = _context.Hotels.Local.ToBindingList();
        }
    }
}
