using System;
using System.Collections.Generic;

#nullable disable

namespace FiberConnection.FiberConnection
{
    public partial class Admin:IAdmin<Admin>
    {
        private readonly fiber_connectionContext fcc = new fiber_connectionContext();
        public int AdminId { get; set; }
        public string AdminUserName { get; set; }
        public string AdminPassword { get; set; }
    }
}
