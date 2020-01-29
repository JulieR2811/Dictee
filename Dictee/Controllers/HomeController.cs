using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dictee.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Dictee()
        {
            return View("Dictee");
            
        }


        public ActionResult Dictee2()
        {
            return View("Dictee2");

        }

        public ActionResult Dictee3()
        {
            return View("Dictee3");

        }

        public ActionResult Dictee4()
        {
            return View("Dictee4");

        }

        public ActionResult Conjugaison()
        {


            return View();

        }

        public ActionResult ResultConjugaison()
        {


            return View();

        }

    }
}