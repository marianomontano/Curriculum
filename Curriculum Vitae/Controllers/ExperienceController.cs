using Curriculum_Vitae.Models;
using Curriculum_Vitae.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curriculum_Vitae.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        public ActionResult Index()
        {
            ExperienceService es = new ExperienceService();
            List<ExperienceModel> experiencias = es.GetAll();
            return View(experiencias);
        }
    }
}