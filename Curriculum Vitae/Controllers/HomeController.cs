using Curriculum_Vitae.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curriculum_Vitae.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Skills()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Actualmente recibiendo ofertas.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string from, string subject, string body)
        {
            if (ModelState.IsValid)
            {
                EmailService.Instance.SendEmail(from, subject, body);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}