using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea13Cap9y10
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public double Calificacion { get; set; }
        public string Curso { get; set; }
        public int Edad { get; set; }

        public Estudiante(string nombre, double calificacion, string curso, int edad)
        {
            Nombre = nombre;
            Calificacion = calificacion;
            Curso = curso;
            Edad = edad;
        }
    }
}
