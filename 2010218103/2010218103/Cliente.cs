using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103
{
    public class Cliente:Persona
    {
        private int codigoCliente;

        public Cliente(string nombre, int edad, int codigoCliente):base(nombre,edad)
        {
            this.codigoCliente = codigoCliente;
        }

        public int CodigoCliente { get => codigoCliente; set => codigoCliente = value; }
    }
}
