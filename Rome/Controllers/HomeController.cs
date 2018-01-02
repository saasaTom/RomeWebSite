using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rome.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        [HttpPost]
        public ActionResult PostContact(Contact contact)
        {
            ViewBag.Message = $"Thanks {contact.Name} for sending me a message";
            ViewBag.MessageSent = true;

            return View("Index");
        }
    }
}