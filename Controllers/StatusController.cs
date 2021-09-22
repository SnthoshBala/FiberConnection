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
    public class StatusController : Controller
    {
        private readonly IStatusServ<Status> s_serv;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(StatusController));

        public StatusController(IStatusServ<Status> _s_serv)
        {
            s_serv = _s_serv;
        }
        public IActionResult StatusList(int id)
        {
            id = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
            _log4net.Info($" Status of Connection as been shown for {HttpContext.Session.GetString("Username")}");
            return View(s_serv.GetAllStatus(id));
        }
        [HttpGet]
        public IActionResult StatusDetails(int id)
        {
             _log4net.Info($"Getting the Status of {id}");
             return View(s_serv.GetStatusByID(id));
        }
        [HttpGet]
        public IActionResult StatusCancel(int id)
        {
            _log4net.Info($"Request Canceling the Status of {id}");
            return View(s_serv.GetStatusByID(id));
        }
        [HttpPost]
        public IActionResult StatusCancel(Status s)
        {
            _log4net.Info($"Canceling the Status of {s.StatusId}");
            s_serv.DeleteStatus(s);
            return RedirectToAction("StatusList", "Status");
        }
    }
}
