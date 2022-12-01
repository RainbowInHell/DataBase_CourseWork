using System;
using System.Collections.Generic;

namespace HotelManagementSystem.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; } = null!;
        public string EmployeeLastName { get; set; } = null!;
        public string EmployeeLogin { get; set; } = null!;
        public string EmployeePassword { get; set; } = null!;
        public string EmployeeEmailAddress { get; set; } = null!;
        public string EmployeeContactNumber { get; set; } = null!;
        public DateOnly EmployeeBirthDate { get; set; }
        public string EmployeeAdress { get; set; } = null!;
        public int? DepartmentId { get; set; }
        public int HotelId { get; set; }

        public virtual Department? Department { get; set; }
        public virtual Hotel Hotel { get; set; } = null!;
    }
}
