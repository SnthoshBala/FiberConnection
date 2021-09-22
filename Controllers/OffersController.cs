using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiberConnection.FiberConnection;
using FiberConnection.Service;
using Microsoft.AspNetCore.Mvc;

namespace FiberConnection.Controllers
{
    public class OffersController : Controller
    {
        private readonly IOfferServ<Offer> o_serv;
        public OffersController(IOfferServ<Offer> _o_serv)
        {
            o_serv = _o_serv;
        }
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(OffersController));
        [HttpGet]
        public IActionResult OfferDetails(int id)
        {
            _log4net.Info($"Offer Details of {id} is called");
            return View(o_serv.GetOffer(id));
        }
        [HttpGet]
        public IActionResult UpdateOffer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateOffer(Offer o)
        {
            _log4net.Info($"{o.OfferId} is called");
            o_serv.AddOffer(o);
            return RedirectToAction($"OfferDetails/{o.OfferId}");
        }
    }
}
