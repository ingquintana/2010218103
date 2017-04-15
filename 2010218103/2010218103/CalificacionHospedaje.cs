using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103
{
    public class CalificacionHospedaje
    {
        int calificacion; // 1 al 5

        public int Calificacion { get => calificacion; set => calificacion = value; }

        public CalificacionHospedaje(int calificacion)
        {
            this.calificacion=calificacion;
        }

    }
}
