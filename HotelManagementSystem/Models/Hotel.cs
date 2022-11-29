using System;
using System.Collections.Generic;

namespace HotelManagementSystem.Models
{
    public partial class Hotel
    {
        public Hotel()
        {
            Departments = new HashSet<Department>();
        }

        public int HotelId { get; set; }
        public string HotelName { get; set; } = null!;
        public string HotelContactNumber { get; set; } = null!;
        public string HotelEmail { get; set; } = null!;
        public string HotelWebsite { get; set; } = null!;
        public string HotelDescription { get; set; } = null!;
        public int FloorsCount { get; set; }
        public string HotelCity { get; set; } = null!;
        public int TotalRooms { get; set; }
        public string HotelCountry { get; set; } = null!;
        public string HotelAddress { get; set; } = null!;
        public string HotelZip { get; set; } = null!;

        public virtual ICollection<Department> Departments { get; set; }
    }
}
