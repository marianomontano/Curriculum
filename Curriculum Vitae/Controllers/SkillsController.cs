using Curriculum_Vitae.Models;
using Curriculum_Vitae.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curriculum_Vitae.Controllers
{
    public class SkillsController : Controller
    {
        // GET: Skills
        public ActionResult Index()
        {
            SkillsService ss = new SkillsService();
            List<SkillsModel> habilidades = ss.GetAll();
            return View(habilidades);
        }
    }
}