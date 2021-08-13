using Curriculum_Vitae.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Curriculum_Vitae.Services
{
    public class EducationService
    {
        public List<EducationModel> GetAll()
        {
            List<EducationModel> lista = new List<EducationModel>();
            lista.Add(new EducationModel
            {
                Institucion = "Educación IT",
                Descripcion = "Curso de desarrollo de Web APIs con ASP .NET CORE",
                FechaInicio = new DateTime(2021, 07, 01),
                FechaFin = new DateTime(2021, 07, 30),
                Estado = "Finalizado"
            });
            lista.Add(new EducationModel
            {
                Institucion = "Universidad Abierta Interamericana",
                Descripcion = "Analista Programador",
                FechaInicio = new DateTime(2018, 03, 01),
                FechaFin = new DateTime(2020, 07, 31),
                Estado = "Finalizado (Pendiente Proyecto Final)"
            });
            lista.Add(new EducationModel
            {
                Institucion = "Udemy",
                Descripcion = "Curso de desarrollo web ASP .NET MVC",
                FechaInicio = new DateTime(2019, 02, 01),
                FechaFin = new DateTime(2019, 03, 01),
                Estado = "Finalizado"
            });
            lista.Add(new EducationModel
            {
                Institucion = "Udemy",
                Descripcion = "Curso de manejo de bases de datos relacionales MS SQL Server",
                FechaInicio = new DateTime(2019, 01, 01),
                FechaFin = new DateTime(2019, 02, 01),
                Estado = "Finalizado"
            });
            lista.Add(new EducationModel
            {
                Institucion = "UBA",
                Descripcion = "Curso de Inversión y Mercado de Capitales",
                FechaInicio = new DateTime(2014, 08, 01),
                FechaFin = new DateTime(2014, 11, 30),
                Estado = "Finalizado"
            });
            lista.Add(new EducationModel
            {
                Institucion = "UTN",
                Descripcion = "Microsoft Office Fundamentals: Word, Excel, Microsoft Windows",
                FechaInicio = new DateTime(2005, 03, 01),
                FechaFin = new DateTime(2008, 11, 30),
                Estado = "Finalizado"
            });

            return lista;
        }
    }
}