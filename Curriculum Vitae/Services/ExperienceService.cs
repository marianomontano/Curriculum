using Curriculum_Vitae.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Curriculum_Vitae.Services
{
    public class ExperienceService
    {
        public List<ExperienceModel> GetAll()
        {
            List<ExperienceModel> lista = new List<ExperienceModel>();
            lista.Add(new ExperienceModel
            {
                Emplador = "GPS Mundo - Garmin Store",
                Puesto = "Departamento Comercial",
                FechaInicio = new DateTime(2017, 11, 01),
                FechaFin = DateTime.Today,
                Tareas = new List<string>() {
                    "Ventas",
                    "Atención al cliente",
                    "Caja",
                    "Asistencia en sistema"
                }

            });
            lista.Add(new ExperienceModel
            {
                Emplador = "Tati Golf - Adidas Golf",
                Puesto = "Departamento Comercial + E-Commerce Leader",
                FechaInicio = new DateTime(2013, 01, 01),
                FechaFin = new DateTime(2017, 06, 30),
                Tareas = new List<string>() {
                    "Ventas",
                    "Atención al cliente",
                    "Team Leader Tienda Oficial MercadoLibre",
                    "Team Leader E-Commerce"
                }

            });

            return lista;
        }
    }
}