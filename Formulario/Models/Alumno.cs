using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formulario.Models
{
    //El modelo Alumno debe ser una clase publica, para que  permita
    //ser visualizada desde otros objetos (Clases)
    public class Alumno
    {
        //definimos las propiedades del modelo
        //todas publicas
        //CLASES TIPO POCO
        public  string rut;
        public string nombre;
        public string apellido;
        public string sexo;
        public string ciudad;
        public string fono;

        //ideal listar todas las propiedas y su tipo de dato

    }
}
