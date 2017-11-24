using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Formulario.Models;

namespace Formulario.Controllers
{
    public class HomeController : Controller
    {
        List<Alumno> alumnos = new List<Alumno>();
        public HomeController() {
            alumnos.Add(new Alumno { rut = "16.112.333-2", nombre = "Juan Andres", apellido = "Montaner Saldivia", ciudad = "Puerto Montt", fono = "1452125", sexo = "Hombre" });
            alumnos.Add(new Alumno { rut = "17.254.362-5", nombre = "Juan Andres", apellido = "Montaner Saldivia", ciudad = "Valdivia", fono = "32234234", sexo = "Mujer" });
            alumnos.Add(new Alumno { rut = "18.254.125-4", nombre = "Juan Andres", apellido = "Montaner Saldivia", ciudad = "Osorno", fono = "89875675", sexo = "Mujer" });
            alumnos.Add(new Alumno { rut = "12.1452.744-2", nombre = "Juan Andres", apellido = "Montaner Saldivia", ciudad = "Paillaco", fono = "32567768", sexo = "Hombre" });

        }


        public IActionResult Index()
        {
            return View(new Alumno());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            ViewData["Title"] = "Listar Alumnos";
            return View( alumnos );
        }

       
        [HttpPost]
        public ActionResult Contact(string rut, string nombre, string apellido, string sexo, string fono, string ciudad)
        {
            Alumno nuevo = new Alumno()
            {
                rut = rut,
                nombre = nombre,
                apellido = apellido,
                ciudad = ciudad,
                fono = fono,
                sexo = sexo
            };
            alumnos.Add(nuevo);
            return View(nuevo);
        }

   

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
