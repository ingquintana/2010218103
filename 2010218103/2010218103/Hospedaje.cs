using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103
{
    public class Hospedaje : ServicioTuristico
    {
        private string empresaH;
        private List<TipoHospedaje> listadoTipo;
        private List<CalificacionHospedaje> listadoCalificacion;
        private List<CategoriaHospedaje> listadoCategoria;
        private List<ServicioHospedaje> listadoServicio;

        public Hospedaje(string lugar, int duracion, string empresaH) : base(lugar, duracion)
        {
            this.empresaH = empresaH;
            listadoTipo = new List<TipoHospedaje>();
            listadoCalificacion = new List<CalificacionHospedaje>();
            listadoCategoria = new List<CategoriaHospedaje>();
            listadoServicio = new List<ServicioHospedaje>();
        }

        public List<TipoHospedaje> ListadoTipo { get => listadoTipo; set => listadoTipo = value; }
        public List<CalificacionHospedaje> ListadoCalificacion { get => listadoCalificacion; set => listadoCalificacion = value; }
        public List<CategoriaHospedaje> ListadoCategoria { get => listadoCategoria; set => listadoCategoria = value; }
        public List<ServicioHospedaje> ListadoServicio { get => listadoServicio; set => listadoServicio = value; }
        public string EmpresaH { get => empresaH; set => empresaH = value; }
    }
}
