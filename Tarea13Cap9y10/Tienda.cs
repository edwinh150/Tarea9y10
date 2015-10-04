using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea13Cap9y10
{
    class Tienda
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double ITBS { get; set; }
        public double Precio { get; set; }
        public double Devuelta { get; set; }

        public Tienda(string nombre, int cantidad, double itbs, double precio, double devuelta)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            ITBS = itbs;
            Precio = precio;
            Devuelta = devuelta;
        }
    }
}
