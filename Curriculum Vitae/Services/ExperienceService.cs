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
                Empleador = "Accusys Tecnology",
                Puesto = "Analista Programador .NET Jr",
                FechaInicio = new DateTime(2021, 01, 25),
                FechaFin = DateTime.Today,
                Tareas = new List<string>()
                {
                    "Desarrollo de software de escritorio en C# y VB6",
                    "Desarrollo de software web en ASP .NET web form y MVC5",
                    "Desarrollo en base de datos SQL con MS SQL Server",
                    "Stored Procedures"
                }
            }) ;

            lista.Add(new ExperienceModel
            {
                Empleador = "GPS Mundo - Garmin Store",
                Puesto = "Departamento Comercial",
                FechaInicio = new DateTime(2017, 11, 01),
                FechaFin = new DateTime(2021, 01, 24),
                Tareas = new List<string>() {
                    "Ventas",
                    "Atención al cliente",
                    "Caja",
                    "Asistencia en sistema"
                }
            });
            lista.Add(new ExperienceModel
            {
                Empleador = "Tati Golf - Adidas Golf",
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