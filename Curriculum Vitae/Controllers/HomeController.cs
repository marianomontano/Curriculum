using Curriculum_Vitae.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<ActionResult> Contact(string from, string subject, string body)
        {
            if (ModelState.IsValid)
            {
                await EmailService.Instance.SendEmailAsync(from, subject, body);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public ActionResult Whatsapp()
		{
            return Redirect("https://web.whatsapp.com/send?phone=5491162204305");
        }
    }
}