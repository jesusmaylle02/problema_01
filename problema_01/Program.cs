using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determinar variables 
            string fruta;
            double distancia, precio;

            Console.Write("Ingrese la fruta deseada  (Naranja, Fresa, Mango): ");
            fruta = Console.ReadLine();

            Console.Write("Ingrese la distancia en km:");
            distancia = double.Parse(Console.ReadLine());

            switch (fruta)
            {
                case "Naranja":
                    if (distancia < 30)
                        precio = 2.00;
                    else
                        precio = 4.00;
                    break;

                case "Fresa":
                    if (distancia < 30)
                        precio = 6.00;
                    else
                        precio = 9.00;
                    break;

                case "Mango":
                    if (distancia < 30)
                        precio = 3.00;
                    else
                        precio = 5.00;
                    break;

                default:
                    Console.WriteLine("Fruta no existente: ");
                    return;
            }

            double pago = precio * 1; 

            Console.WriteLine("El pago que debe realizarse por esa carga es: " + pago.ToString("C"));
            Console.WriteLine("Muchas gracias por su compra ");
            Console.ReadKey();
        }
    }
}
