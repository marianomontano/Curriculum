using Curriculum_Vitae.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Curriculum_Vitae.Services
{
    public class SkillsService
    {
        public List<SkillsModel> GetAll()
        {
            List<SkillsModel> lista = new List<SkillsModel>();
            lista.Add(new SkillsModel
            {
                Grupo = "Lenguajes de Programación",
                Habilidades = new List<string>()
                {
                    "C#", "ASP .NET MVC", "SQL", "Java Básico", "HTML", "JavaScript Intermedio"
                }
            });
            lista.Add(new SkillsModel
            {
                Grupo = "Acceso a datos",
                Habilidades = new List<string>()
                {
                    "ADO .NET", "Entity Framework", "MS SQL Server"
                }
            });
            lista.Add(new SkillsModel
            {
                Grupo = "Herramientas de trabajo",
                Habilidades = new List<string>()
                {
                    "Visual Studio", ".NET Framework", ".NET Core", "Blazor básico"
                }
            });
            lista.Add(new SkillsModel
            {
                Grupo = "Ofimática",
                Habilidades = new List<string>()
                {
                    "MS Office", "Libre Office" 
                }
            });
            lista.Add(new SkillsModel
            {
                Grupo = "Sistemas Operativos",
                Habilidades = new List<string>()
                {
                    "Microsoft Windows", "Linux"
                }
            });
            lista.Add(new SkillsModel
            {
                Grupo = "Otros",
                Habilidades = new List<string>()
                {
                    "Patrones de diseño", "Principios SOLID", "Unit Testing y Mocking",
                    "Rápido aprendizaje", "Trabajo en equipo", "Capacidad autodidacta"
                }
            });

            return lista;
        }
    }
}