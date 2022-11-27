using HotelManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagementSystem.ControlScreens
{
    public partial class AdminHotelsViewScreen : Form
    {
        private HotelDbContext? _context;
        private Hotel? _tempHotel;

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

            _context?.Database.EnsureCreated();
            _context.Hotels.Load();

            tableOfHotels.DataSource = _context.Hotels.Local.ToBindingList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(!ProjectHelper.AreAllTextBoxesFilled(hotelNameField.Text, hotelContactNumberField.Text, hotelEmaildField.Text, hotelWebSiteField.Text,
                hotelDescriptionField.Text, hotelFloorsCountField.Text, hotelCityField.Text, hotelCapacityField.Text, hotelCountryField.Text,
                hotelAdresField.Text, hotelZipCodeField.Text))
            {
                MessageBox.Show("Все поля обязательны к заполнению.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _tempHotel = new Hotel();
            _tempHotel.HotelName = hotelNameField.Text;
            _tempHotel.HotelContactNumber = hotelContactNumberField.Text;
            _tempHotel.HotelEmail = hotelEmaildField.Text;
            _tempHotel.HotelWebsite = hotelWebSiteField.Text;
            _tempHotel.HotelDescription = hotelDescriptionField.Text;
            _tempHotel.FloorsCount = int.Parse(hotelFloorsCountField.Text);
            _tempHotel.HotelCity = hotelCityField.Text;
            _tempHotel.TotalRooms = int.Parse(hotelCapacityField.Text);
            _tempHotel.HotelCountry = hotelCountryField.Text;
            _tempHotel.HotelAddress = hotelAdresField.Text;
            _tempHotel.HotelZip = hotelZipCodeField.Text;

            _context.Hotels.Add(_tempHotel);
            _context.SaveChanges();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ProjectHelper.ClearAllFields(Controls);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!ProjectHelper.AreAllTextBoxesFilled(hotelIdField.Text))
            {
                MessageBox.Show("Поле Id обязательно к заполнению.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!ProjectHelper.DeleteButtonLogic(_context, ProjectHelper.ScreenFlag.AdminHotelsViewScreenFlag, hotelIdField.Text))
            {
                MessageBox.Show($"Отсутствует отель с id = {hotelIdField.Text}.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tableOfHotels.DataSource = _context.Hotels.Local.ToBindingList();
            tableOfHotels.Refresh();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!ProjectHelper.AreAllTextBoxesFilled(Controls))
            {
                MessageBox.Show("Все поля обязательны к заполнению.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _tempHotel = null;
            _tempHotel = _context.Hotels.Find(long.Parse(hotelIdField.Text));

            if (_tempHotel == null)
            {
                MessageBox.Show($"Отсутствует отель с id = {hotelIdField.Text}.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _tempHotel.HotelName = hotelNameField.Text;
            _tempHotel.HotelContactNumber = hotelContactNumberField.Text;
            _tempHotel.HotelEmail = hotelEmaildField.Text;
            _tempHotel.HotelWebsite = hotelWebSiteField.Text;
            _tempHotel.HotelDescription = hotelDescriptionField.Text;
            _tempHotel.FloorsCount = int.Parse(hotelFloorsCountField.Text);
            _tempHotel.HotelCity = hotelCityField.Text;
            _tempHotel.TotalRooms = int.Parse(hotelCapacityField.Text);
            _tempHotel.HotelCountry = hotelCountryField.Text;
            _tempHotel.HotelAddress = hotelAdresField.Text;
            _tempHotel.HotelZip = hotelZipCodeField.Text;

            _context.SaveChanges();
            _context.Hotels.Load();

            tableOfHotels.DataSource = _context.Hotels.Local.ToBindingList();
            tableOfHotels.Refresh();
        }

        private void searchHotelByIdButton_Click(object sender, EventArgs e)
        {
            if (!ProjectHelper.AreAllTextBoxesFilled(hotelIdField.Text))
            {
                MessageBox.Show("Поле Id обязательно к заполнению.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _tempHotel = null;
            _tempHotel = _context.Hotels.AsNoTracking().FirstOrDefault(hotel => hotel.HotelId == int.Parse(hotelIdField.Text));

            if(_tempHotel == null) 
            {
                MessageBox.Show($"Отсутствует отель с id = {hotelIdField.Text}.", "Внимаение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            hotelNameField.Text = _tempHotel.HotelName;
            hotelContactNumberField.Text = _tempHotel.HotelContactNumber;
            hotelEmaildField.Text = _tempHotel.HotelEmail;
            hotelWebSiteField.Text = _tempHotel.HotelWebsite;
            hotelDescriptionField.Text = _tempHotel.HotelDescription;
            hotelFloorsCountField.Text = _tempHotel.FloorsCount.ToString();
            hotelCityField.Text = _tempHotel.HotelCity;
            hotelCapacityField.Text = _tempHotel.TotalRooms.ToString();
            hotelCountryField.Text = _tempHotel.HotelCountry;
            hotelAdresField.Text = _tempHotel.HotelAddress;
            hotelZipCodeField.Text = _tempHotel.HotelZip;
        }
    }
}
