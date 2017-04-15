using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103
{
    public class Paquete
    {
        private List<ServicioTuristico> listadoServicioTuristico;

        public Paquete()
        {
            listadoServicioTuristico = new List<ServicioTuristico>();
        }

        public List<ServicioTuristico> ListadoServicioTuristico { get => listadoServicioTuristico; set => listadoServicioTuristico = value; }
    }
}
