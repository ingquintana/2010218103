using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103
{
    public class Empleado:Persona
    {
        private int codigoEmpleado;

        public Empleado(string nombre, int edad, int codigoEmpleado):base(nombre,edad)
        {
            this.codigoEmpleado = codigoEmpleado;
        }

        public int CodigoEmpleado { get => codigoEmpleado; set => codigoEmpleado = value; }
    }
}
