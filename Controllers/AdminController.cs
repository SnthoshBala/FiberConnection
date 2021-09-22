using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FiberConnection.Controllers
{
    public class AdminController : Controller
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(AdminController));
        public IActionResult AdminControl()
        {
            _log4net.Info("Admin has Taken Control ");
            return View();
        }
    }
}