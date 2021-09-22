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
    public class BillingController : Controller
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(BillingController));
        private readonly IBillingServ<Billing> serv_b;
        public BillingController(IBillingServ<Billing> _serv_b)
        {
            serv_b = _serv_b;
        }
        [HttpGet]
        public IActionResult RequestBilling(int id)
        {            
            return View(serv_b.FindByID(id));
        }
        [HttpPost]
        public IActionResult RequestBilling(Billing b)
        {
            serv_b.AddStatusBilling(b); 
            _log4net.Info($"Billing has been booked");
            return RedirectToAction("PlanDetails", "Fiber");
        }

        [Route("BillingDetails/Request/{id:int}")]
        public IActionResult Request(Billing b,int id)
        {          
            int c_id= Convert.ToInt32(HttpContext.Session.GetString("UserId"));
            _log4net.Info($"Billing the Customer {b.CustomerName} with {b.PlanName} of Rs {b.PlanPrice}");
            return RedirectToAction("RequestBilling", new { id = serv_b.AddBilling(b,id,c_id) });
        }
    }
}
