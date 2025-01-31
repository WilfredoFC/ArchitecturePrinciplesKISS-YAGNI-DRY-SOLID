using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioKiss;
using EjerciciosDRY;
using EjerciciosSOLID;
using EjerciciosYAGNI;
//WIlfredoFC
namespace EjerciciosPrincipios
{
    public class Proyect
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probando clase RestaurantBill con los precios de 5,10,7 ");
            decimal[] prices = { 5, 10, 7 };
            RestaurantBill restaurantBill = new RestaurantBill();
            decimal total= restaurantBill.CalculateTotal(prices);
            Console.WriteLine($"El total, incluyendo la propina por defecto (10% del total) es de: {total:C}");

            Console.WriteLine("\nProbando clase Payroll con dos clientes:\n1-Empleado  con un sueldo fijo bruto de 50,000 DOP\n2-Empleado por horas con una tarifa de 500 DOP por hora y 20h trabajadas");
            Payroll payroll= new Payroll();
            Console.WriteLine($"Sueldo cliente1: {payroll.CalculateSalaryForFullTime(50000):C}\nSueldo cliente2: {payroll.CalculateSalaryForPartTime(500,20):C}");

            Console.WriteLine("\nProbando clase ProducService");
            ProductService productService = new ProductService();
            productService.AddProduct("Iphone 14 Pro",26000);
            productService.DeleteProduct(1);

            Console.WriteLine("\nProbando clase EmailService");
            EmailService emailService = new EmailService();
            emailService.SendEmail("wfelizcaba7@gmai.com", "Hola WIlfredo");

            Console.WriteLine("\nProbando clase SMSService");
            SMSService SMSService = new SMSService();
            SMSService.SendSMS("809-888-7777", "Hola Wilfredo");

            Console.WriteLine("\nProbando clase NotificationService");
            NotificationService notificationService = new NotificationService();
            notificationService.LogNotification("Hola Wilfredo");

        }

    }
}
