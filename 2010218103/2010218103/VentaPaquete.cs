using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103
{
    public class VentaPaquete
    {
        public string tipoPaquete;
        public int cantidad;
        public double precio=500;
        public double total;
        private List<Paquete> listadoPaquete;
        private List<ComprobantePago> listadoComprobantePago;
        private List<MedioPago> listadoMedioPago;
        private Empleado empleado;
        private Cliente cliente;

        public double TotalVentas (int cant, double prec)
        {
            total = prec * cant;
            return total;
        }

        public int GenerarCantidad()
        {
            Random rdn = new Random();
            int a = rdn.Next(1, 100);
            return a;
        }

        public double CalcularPrecio(int _paquete)
        {
            switch (_paquete)
            {
                case 1:
                    {
                        precio = 100;
                        break;
                    }
                case 2:
                    {
                        precio = 300;
                        break;
                    }
                case 3:
                    {
                        precio = 500;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Paquete Inexistente");
                        precio = 0;
                        break;
                    }
            }
            return precio;
        }

        public VentaPaquete()
        {
            listadoPaquete = new List<Paquete>();
            listadoComprobantePago = new List<ComprobantePago>();
            listadoMedioPago = new List<MedioPago>();
        }

        public List<Paquete> ListadoPaquete { get => listadoPaquete; set => listadoPaquete = value; }
        public List<ComprobantePago> ListadoComprobantePago { get => listadoComprobantePago; set => listadoComprobantePago = value; }
        public List<MedioPago> ListadoMedioPago { get => listadoMedioPago; set => listadoMedioPago = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
    }

}
