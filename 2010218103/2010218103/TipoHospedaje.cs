using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103
{
    public class TipoHospedaje
    {
        string tipo; //Hotel, Hostal, Backpacker

        public string Tipo { get => tipo; set => tipo = value; }

        public TipoHospedaje(string tipo)
        {
            this.tipo = tipo;
        }
    }
}
