using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiberConnection.FiberConnection;
using FiberConnection.Repository;

namespace FiberConnection.Service
{
    public class CustomerServ : ICustomerServ<Customer>
    {
        private readonly ICustomerRepo<Customer> c_repo;
        public CustomerServ(ICustomerRepo<Customer> _c_repo)
        {
            c_repo = _c_repo;
        }
        public void AddCustomer(Customer c)
        {
            c_repo.AddCustomer(c);
        }

        public Customer CustomerLogin(Customer c)
        {
           return c_repo.CustomerLogin(c);
        }
    }
}
