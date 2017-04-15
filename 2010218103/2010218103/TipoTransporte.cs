using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103
{
    public class TipoTransporte
    {
        string tipo; //Auto, Bus, Limosina
       
        public string Tipo { get => tipo; set => tipo = value; }

        public TipoTransporte(string tipo)
        {
            this.tipo = tipo;
        }
    }
}
