using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103
{
    public abstract class ServicioTuristico
    {
        protected string lugar;
        protected int duracion;

        public string Lugar { get => lugar; set => lugar = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        public ServicioTuristico(string lugar, int duracion)
        {
            this.lugar = lugar;
            this.duracion = duracion;
        }
    }
}
