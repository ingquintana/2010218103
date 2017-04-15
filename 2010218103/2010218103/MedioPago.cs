using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103
{
    public class MedioPago
    {
        string medioP; //Efectivo, Tarjeta

        public string MedioP { get => medioP; set => medioP = value; }

        public MedioPago(string medioP)
        {
            this.medioP = medioP;
        }
    }
}
