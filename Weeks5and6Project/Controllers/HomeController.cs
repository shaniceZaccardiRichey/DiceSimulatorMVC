using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Weeks5and6Project.Models;

namespace Weeks5and6Project.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            Dice dice = new Dice(1, 1);
            return View(dice);
        }

        [HttpPost]
        public ActionResult Index(Dice dice)
        {
            return View(dice);
        }

        [Authorize]
        public ActionResult ValidationCheck()
        {
            return View();
        }
    }
}