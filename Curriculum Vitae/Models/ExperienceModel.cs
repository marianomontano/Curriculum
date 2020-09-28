using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Curriculum_Vitae.Models
{
    public class ExperienceModel
    {
        [Display(Name ="Empleador")]
        public string Emplador { get; set; }
        public string Puesto { get; set; }

        [Display(Name = "Fecha de Inicio")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaInicio { get; set; }

        [Display(Name = "Fecha de Fin")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaFin { get; set; }

        [Display(Name = "Tareas realizadas")]
        public List<string> Tareas { get; set; }
    }
}