using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103
{
    public class Alimentacion:ServicioTuristico
    {
        private string empresaA;
        private List<CategoriaAlimentacion> listadoCategoria;

        public Alimentacion(string lugar, int duracion, string empresaA) : base(lugar, duracion)
        {
            this.empresaA = empresaA;
            listadoCategoria = new List<CategoriaAlimentacion>();
        }

        public List<CategoriaAlimentacion> ListadoCategoria { get => listadoCategoria; set => listadoCategoria = value; }
        public string EmpresaA { get => empresaA; set => empresaA = value; }
    }
}
