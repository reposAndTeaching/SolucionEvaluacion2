using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionEvaluacion2
{
    class Venta
    {
        private Entrada ticket;
        private int cantidad;
        private int dineroTotal;

        public Venta(Entrada ticket, int cantidad, int dineroTotal)
        {
            this.ticket = ticket;
            this.cantidad = cantidad;
            this.dineroTotal = dineroTotal;
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int DineroTotal { get => dineroTotal; set => dineroTotal = value; }
        internal Entrada Ticket { get => ticket; set => ticket = value; }
    }
}
