using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103
{
    public class ServicioHospedaje
    {
        string servicio; //Lavanderia, Plachado, Room Service

        public string Servicio { get => servicio; set => servicio = value; }

        public ServicioHospedaje(string servicio)
        {
            this.servicio = servicio;
        }
    }
}
