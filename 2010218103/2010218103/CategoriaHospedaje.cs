using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103
{
    public class CategoriaHospedaje
    {
        string categoria; //Basico, Normal, VIP

        public string Categoria { get => categoria; set => categoria = value; }

        public CategoriaHospedaje(string categoria)
        {
            this.categoria = categoria;
        }
    }
}
