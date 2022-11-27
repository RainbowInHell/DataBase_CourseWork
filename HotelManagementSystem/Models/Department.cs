using System;
using System.Collections.Generic;

namespace HotelManagementSystem.Models;

public partial class Department
{
    public long DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public string DepartmentDescription { get; set; } = null!;

    public long DepartmentInitialSalary { get; set; }

    public long HotelId { get; set; }

    public virtual Hotel Hotel { get; set; } = null!;
}
