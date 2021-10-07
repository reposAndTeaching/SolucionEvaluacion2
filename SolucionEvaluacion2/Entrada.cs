using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionEvaluacion2
{
    class Entrada
    {
        private string nombre;
        private int precio;
        private int stock;

        public Entrada(string nombre, int precio, int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
