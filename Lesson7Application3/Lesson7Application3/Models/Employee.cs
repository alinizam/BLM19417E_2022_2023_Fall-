﻿using System;
using System.Collections.Generic;

namespace Lesson7Application3.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? DepartmentId { get; set; }

       // public virtual Department? Department { get; set; }
    }
}
