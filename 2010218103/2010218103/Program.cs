﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalfinal = 0;
            Console.WriteLine("BIENVENIDO AL SISTEMA");
            void ReporteVentas()
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingresar ID del paquete a consultar");
                    Console.WriteLine("[1] Paquete Basico");
                    Console.WriteLine("[2] Paquete Normal");
                    Console.WriteLine("[3] Paquete VIP");
                    int paquete = int.Parse(Console.ReadLine());
                    VentaPaquete obj = new VentaPaquete();
                    if (paquete < 1 || paquete > 3)
                    {
                        Console.WriteLine("Paquete Inexistente");
                    }
                    else
                    {
                        double precio = obj.CalcularPrecio(paquete);
                        int cantidad = obj.GenerarCantidad();
                        Console.WriteLine("Precio unitario   ---> " + precio);
                        Console.WriteLine("Cantidad mensual  ---> " + cantidad);
                        double total = obj.TotalVentas(cantidad, precio);
                        Console.WriteLine("Total del paquete ---> " + total);
                        totalfinal += total;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("TOTAL DE VENTAS ---> " + totalfinal);
                Console.WriteLine("");
                Console.WriteLine("¿Desea continuar? Si/No");
                string rpta2 = Console.ReadLine();
                if (rpta2 == "Si")
                    ReporteVentas();
                else
                    Environment.Exit(0);
            }
            ReporteVentas();
            Console.ReadKey();
            
        }
    }
}
