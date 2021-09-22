﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FiberConnection.FiberConnection
{
    public partial class Employee:IEmployee<Employee>
    {
        private readonly fiber_connectionContext fcc = new fiber_connectionContext();
        public Employee()
        {
            Statuses = new HashSet<Status>();
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public string WorkLocation { get; set; }
        public string PhoneNumber { get; set; }
        public string EmployeeMail { get; set; }
        public string EmployeePassword { get; set; }

        public virtual ICollection<Status> Statuses { get; set; }
    }
}
