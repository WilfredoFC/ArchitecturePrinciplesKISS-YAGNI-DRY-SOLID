using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DRY
{
    public class Prueba
    {
        //El usuario ingresará el tipo de empleado("1" para tiempo completo, "2" para medio tiempo).
        //Para empleados de tiempo completo, se ingresará el salario base.
        //Para empleados de medio tiempo, se ingresará el sueldo por hora y las horas trabajadas.
        //Se calculará el salario neto aplicando un 18% de impuestos y un 5% de bono.
        static void Main(string[] args)
        {
            Payroll payroll = new Payroll();
            int eleccion = -1;
            decimal salario = 0;
            int horasTrabajadas = 0;
            while (eleccion != 0)
            {
                Console.WriteLine("1- Empleado tiempo completo\n2- Empleado medio tiempo\n3- Salir");
                Console.WriteLine("Ingresa al tipo de empleado que quieres agregar: ");
                eleccion= int.Parse(Console.ReadLine()!);
                if (eleccion == 1)
                {
                    Console.WriteLine("Ingrese el salario base:");
                    salario = decimal.Parse(Console.ReadLine()!);
                    Console.WriteLine($"El salario final es de: {payroll.CalculateSalaryForFullTime(salario):C}");
                }
                else
                {
                    Console.WriteLine("Ingrese el sueldo por hora:");
                    salario = decimal.Parse(Console.ReadLine()!);

                    Console.WriteLine("Ingrese las horas trabajadas:");
                    horasTrabajadas = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"El salario final es de: {payroll.CalculateSalaryForPartTime(salario, horasTrabajadas):C}");
                }
                Console.WriteLine();
            }
        }
    }
}
