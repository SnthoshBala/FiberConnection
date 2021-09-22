using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace FiberConnection.FiberConnection
{
    public partial class Customer:ICustomer<Customer>
    {
        private readonly fiber_connectionContext fcc = new fiber_connectionContext();
        public Customer()
        {
            Billings = new HashSet<Billing>();
            Statuses = new HashSet<Status>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerAadharNo { get; set; }
        public string CustomerMailId { get; set; }
        public string CustomerPassword { get; set; }

        public virtual ICollection<Billing> Billings { get; set; }
        public virtual ICollection<Status> Statuses { get; set; }

        public void AddCustomer(Customer c)
        {
            fcc.Customers.Add(c);
            fcc.SaveChanges();
        }

        public Customer CustomerLogin(Customer c)
        {
            Customer result = (from i in fcc.Customers
                               where i.CustomerMailId == c.CustomerMailId && i.CustomerPassword == c.CustomerPassword
                               select i).FirstOrDefault();
            return result;
        }
    }
}
