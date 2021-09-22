using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiberConnection.FiberConnection;
using FiberConnection.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FiberConnection.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerServ<Customer> c_serv;
        public CustomerController(ICustomerServ<Customer> _c_serv)
        {
            c_serv = _c_serv;
        }
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(CustomerController));
        [HttpGet]
        public IActionResult RegisterCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterCustomer(Customer c)
        {
            _log4net.Info($"Registering Customer with the name {c.CustomerName}");
            c_serv.AddCustomer(c);
            return RedirectToAction("CustomerLogin");
        }
        [HttpGet]
        public IActionResult CustomerLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CustomerLogin(Customer c)
        {

            Customer result = c_serv.CustomerLogin(c);
            if(result!=null)
            {
                HttpContext.Session.SetString("Username", result.CustomerName);
                HttpContext.Session.SetString("UserId", result.CustomerId.ToString());
                _log4net.Info($"{result.CustomerName} with the id {result.CustomerId} has been Logged In");
                return RedirectToAction("PlanDetails","Fiber");    
            }
            else
            {
                _log4net.Info($"Login Failed with the credential {c.CustomerMailId} and {c.CustomerPassword}");
                return View();
            }
        }
        public IActionResult Logout()
        {
            _log4net.Info($"{HttpContext.Session.GetString("Username")} has been Logged Out");
            HttpContext.Session.Clear();
            return RedirectToAction("PlanDetails", "Fiber");
        }
    }
}
