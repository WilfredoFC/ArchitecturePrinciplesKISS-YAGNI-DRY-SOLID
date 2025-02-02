using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //SOLID
    //S- Single responsability principle.
    public class EmailService
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"Sending Email to {email}: {message}");
        }
    }
    public class SMSService
    {

        public void SendSMS(string phoneNumber, string message)
        {
            Console.WriteLine($"Sending SMS to {phoneNumber}: {message}");

        }
    }
    public class NotificationService
    {
        public void LogNotification(string message)
        {
            Console.WriteLine($"Logging notification: {message}");
        }
    }
}
