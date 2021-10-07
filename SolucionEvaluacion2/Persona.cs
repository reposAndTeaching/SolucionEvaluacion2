using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionEvaluacion2
{
    class Persona
    {
        private string nombre;
        private string rut;

        public Persona(string nombre, string rut)
        {
            this.nombre = nombre;
            this.rut = rut;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Rut { get => rut; set => rut = value; }
    }
}
