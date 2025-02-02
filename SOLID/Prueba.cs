using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Prueba
    {
        static void Main(string[] args)
        {
            EmailService emailService = new EmailService();
            SMSService SMSService = new SMSService();
            NotificationService notificationService = new NotificationService();
            int opcion=-1;
            string mensaje;

            Console.WriteLine("Escribe el mensaje:");
            mensaje=Console.ReadLine()!;
            Console.WriteLine("Selecciona la opcion\n1- Enviar mensaje por Email.\n2- Enviar mensaje por SMS.\n3- Enviar notificacion.\n4-Salir.");
            opcion=int.Parse(Console.ReadLine()!);
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Escribe el Email: ");
                    emailService.SendEmail(Console.ReadLine()!,mensaje);
                    break;
                case 2:
                    Console.WriteLine("Escribe el numero de telefono: ");
                    SMSService.SendSMS(Console.ReadLine()!,mensaje);
                    break;
                case 3:
                    notificationService.LogNotification(mensaje);
                    break;
                default:
                    Console.WriteLine("Saliendo");
                    break;
            }
            Console.WriteLine("\nEnviado...\n");
            
        }
    }
}
