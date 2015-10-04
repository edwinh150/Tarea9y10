using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea13Cap9y10
{
    class Poligono
    {
        public double Lados { get; set; }

        public Poligono(double lado)
        {
            Lados = lado;
        }

        public double CalcularP()
        {
            double re = (Lados - 2) * 180;
            return re / Lados;
        }
    }
}
