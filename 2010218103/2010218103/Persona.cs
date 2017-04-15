using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103
{
    public class Persona
    {
        private string nombre;
        private int edad;

        protected string Nombre { get => nombre; set => nombre = value; }
        protected int Edad { get => edad; set => edad = value; }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}
