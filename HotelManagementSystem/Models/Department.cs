using System;
using System.Collections.Generic;

namespace HotelManagementSystem.Models
{
    public partial class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string DepartmentDescription { get; set; } = null!;
        public int DepartmentInitialSalary { get; set; }
        public int HotelId { get; set; }

        public virtual Hotel Hotel { get; set; } = null!;
    }
}
