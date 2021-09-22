using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiberConnection.FiberConnection;

namespace FiberConnection.Repository
{
    public class CustomerRepo : ICustomerRepo<Customer>
    {
        private readonly ICustomer<Customer> c_obj;
        public CustomerRepo(ICustomer<Customer> _c_obj)
        {
            c_obj = _c_obj;
        }
        public void AddCustomer(Customer c)
        {
            c_obj.AddCustomer(c);
        }

        public Customer CustomerLogin(Customer c)
        {
            return c_obj.CustomerLogin(c);
        }
    }
}
