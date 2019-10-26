using System;

namespace CSharpIntermediateConsoleApp.Interfaces.Polymorphism
{
    class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending Email...");
        }
    }
}