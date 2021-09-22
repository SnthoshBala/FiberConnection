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
    public class FiberController : Controller
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(FiberController));
        private readonly IFiberPlanServ<FiberPlan> fp_serv;
        public FiberController(IFiberPlanServ<FiberPlan> _fp_serv)
        {
            fp_serv = _fp_serv;
        }
        public IActionResult PlanDetails()
        {
            _log4net.Info("Plan Details are Called");
            HttpContext.Session.GetString("Username");
            return View(fp_serv.GetFiberPlans());
        }
        [HttpGet]
        public IActionResult UpdatePlan()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdatePlan(FiberPlan fp)
        {
            fp_serv.AddPlans(fp);
            _log4net.Info($"New plan is Added with the name {fp.PlanName} and {fp.PlanId}");
            return RedirectToAction("PlanDetails");
        }

    }
}
