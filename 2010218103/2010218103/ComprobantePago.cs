using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103
{
    public class ComprobantePago
    {
        private List<TipoComprobante> listadoTipoComprobante;

        public ComprobantePago()
        {
            listadoTipoComprobante = new List<TipoComprobante>();
        }

        public List<TipoComprobante> ListadoTipoComprobante { get => listadoTipoComprobante; set => listadoTipoComprobante = value; }
    }
}
