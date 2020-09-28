using Curriculum_Vitae.Models;
using Curriculum_Vitae.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curriculum_Vitae.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        public ActionResult Index()
        {
            EducationService es = new EducationService();
            List<EducationModel> educacion = es.GetAll();
            return View(educacion);
        }
    }
}