using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103
{
    public class TipoComprobante
    {
        string tipoC; //Boleta, Factura

        public string TipoC { get => tipoC; set => tipoC = value; }

        public TipoComprobante(string tipoC)
        {
            this.tipoC = tipoC;
        }
    }
}
