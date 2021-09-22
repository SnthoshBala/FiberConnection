using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiberConnection.Service
{
    public interface ICustomerServ<Customer>
    {
        public void AddCustomer(Customer c);
        public Customer CustomerLogin(Customer c);
    }
}
