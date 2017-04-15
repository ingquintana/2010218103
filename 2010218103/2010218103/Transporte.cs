using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103
{
    public class Transporte : ServicioTuristico
    {
        private string empresaT;
        private List<TipoTransporte> listadoTipo;
        private List<CategoriaTransporte> listadoCategoria;

        public Transporte(string lugar, int duracion, string empresaT) : base(lugar, duracion)
        {
            this.empresaT = empresaT;
            listadoTipo = new List<TipoTransporte>();
            listadoCategoria = new List<CategoriaTransporte>();
        }

        public List<TipoTransporte> ListadoTipo { get => listadoTipo; set => listadoTipo = value; }
        public List<CategoriaTransporte> ListadoCategoria { get => listadoCategoria; set => listadoCategoria = value; }
        public string EmpresaT { get => empresaT; set => empresaT = value; }
    }
}
