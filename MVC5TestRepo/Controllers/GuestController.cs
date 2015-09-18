using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5TestRepo.Models;

namespace MVC5TestRepo.Controllers
{
    public class GuestController : Controller
    {
        //
        // GET: /Guest/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Reserve()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Reserve(GuestResponse response)
        {
            if (ModelState.IsValid)
            {
                PartyRepository.Add(response);
                return View("Thanks", response);
            }

            return View();
        }

        [ChildActionOnly]
        public ActionResult Attendes()
        {
            return View(PartyRepository.GuestResponses.Where(x => x.Attend == true).ToList());
        }
    }
}