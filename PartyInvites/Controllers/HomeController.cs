using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RSVPForm()
        {


            return View();
        }

        [HttpPost]
        public ActionResult RSVPForm(guest g)
        {


            return View("thanks", g);
        }
    }
}