using System;
using System.Collections.Generic;

namespace HotelManagementSystem.Models;

public class Hotel
{
    public long HotelId { get; set; }

    public string HotelName { get; set; } = null!;

    public string HotelContactNumber { get; set; } = null!;

    public string HotelEmail { get; set; } = null!;

    public string HotelWebsite { get; set; } = null!;

    public string HotelDescription { get; set; } = null!;

    public long FloorsCount { get; set; }

    public string HotelCity { get; set; } = null!;

    public long TotalRooms { get; set; }

    public string HotelCountry { get; set; } = null!;

    public string HotelAddress { get; set; } = null!;

    public string HotelZip { get; set; } = null!;
}
