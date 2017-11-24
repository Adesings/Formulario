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
       // list una clase que permite agregar objetos especificos
       //creamos una  referencia a una lista de objetos tipo Alumno
       //este objeto se llamara "alumnos"
       //se inicia con un new a ALumno() --> Modelo,
                    //es una clase publica en la carpeta Models
                    //se definen las prpiedades y logica del modelo Alumno
        List<Alumno> alumnos = new List<Alumno>();//inicianod un listado de tipo Alumno
        //desde aqui, alumnos me permitira agregar objetos de tipo Alumno

        public HomeController() {//constructor, es el primer metodo que se carga, cuandos e instancia la calse HomeController
            //al listado alumno, añado "Add" objetos:
                // alumnos como es un listado de tipo alumnos, es posible
                //agregar objetos del mismo tipo
                //en este caso, estamos añadiendo cuatro alumnos "new Alumno"
            alumnos.Add(new Alumno { rut = "16.112.333-2", nombre = "Juan Andres", apellido = "Montaner Saldivia", ciudad = "Puerto Montt", fono = "1452125", sexo = "Hombre" });
            alumnos.Add(new Alumno { rut = "17.254.362-5", nombre = "Juan Andres", apellido = "Montaner Saldivia", ciudad = "Valdivia", fono = "32234234", sexo = "Mujer" });
            alumnos.Add(new Alumno { rut = "18.254.125-4", nombre = "Juan Andres", apellido = "Montaner Saldivia", ciudad = "Osorno", fono = "89875675", sexo = "Mujer" });
            alumnos.Add(new Alumno { rut = "12.1452.744-2", nombre = "Juan Andres", apellido = "Montaner Saldivia", ciudad = "Paillaco", fono = "32567768", sexo = "Hombre" });

            //
            // alumnos  --> corresponde al listado de posibles objetos de tipo alumnos
            //.Add (    --> es un metodo que permite agregar objetos del mismo tipo del listado (de tipo Alumnos)
            // new Alumno{   --> new Alumno crea un objeto de tipo Alumno, entre las llaves debemos agregar valores a las propiedaes
                        // rut = "111111111"
                        //la propiedad rut del objeto Alumno se asigna el valor "11111111"
                        //por cada propiedad debe ser separada por coma


            //}
        }


        public IActionResult Index()
        {
            //index renderiza la vista Index
            //que esta en la carpeta Views/Home/Index

            //a la vista le paso un objeto vacio de tipo Alumno
            //por que vamos hacer que la vista se bindee (enlace)
            //directamente conn el modelo
            return View(new Alumno());
        }

        public IActionResult About()
        {//about corresponde ala vista del controlador, cuando sea llamda
            //desde alguna accion realizada en la vista
            //ViewData es un componente que me permite pasar
            //informacion entre el controaldor y la vistaq 
            ViewData["Title"] = "Listar Alumnos";

            return View( alumnos );
            //@RenderBody, que carge la nueva vista de About y 
                            // ademas pasa una lista de objetos
                            //en este caso una lista de objetos tipo Alumnos
        }

       
        [HttpPost]
        public ActionResult Contact(string rut, string nombre, string apellido, string sexo, string fono, string ciudad)
        {
            //crear un objeto de tipo alumno
            //nuevo sera el nuevo alumno enviado por el formulario
            //para ello asigamos valores directos a sus propeuidads
            Alumno nuevo = new Alumno()
            {
                rut = rut,  // rut (propiedad del objeto)  =  rut (parametro recibido por el metodo Contact)
                nombre = nombre,
                apellido = apellido,
                ciudad = ciudad,
                fono = fono,
                sexo = sexo
            };
            alumnos.Add(nuevo);//agrega el objeto nuevo a la lista de alumnos

            return View(nuevo);//envia un objeto a la vista Contact
        }

   

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
