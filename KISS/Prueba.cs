using EjercicioKiss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KISS
{
    class Prueba
    {
        static void Main(string[] args)
        {
            RestaurantBill restaurantBill = new RestaurantBill();
            LinkedList<decimal> ListPrecios = new LinkedList<decimal>();
            Console.WriteLine("Ingrese los precios de los platos: ");
            decimal precio = -1;
            int cont = 0;
            while (precio != 0) 
            {
                cont++;
                Console.WriteLine("(Introduzca 0 para salir)Introduce el valor del plato " + cont+":");
                precio= decimal.Parse(Console.ReadLine()!);
                ListPrecios.AddLast(precio);
            }

            decimal[] precios = ListPrecios.ToArray();
            int eleccion = -1;
            decimal propina;
            decimal total = 0;
        
            Console.WriteLine("Quieres dejar una propina?\n1-Si\n2- Usar propina por defecto(10%)");
            eleccion = int.Parse(Console.ReadLine()!);
            if (eleccion == 1)
            {
                Console.WriteLine("Que porcentaje de la cuenta quieres dejar de propina?");
                propina = decimal.Parse(Console.ReadLine()!);
                total = restaurantBill.CalculateTotal(precios, propina);
            }
            else
            {
                Console.WriteLine("Se aplicara la propina por defecto");
                total = restaurantBill.CalculateTotal(precios);
            }
            Console.WriteLine($"El monto total a pagar es de {total} ");
            

            
        }
    }
}
