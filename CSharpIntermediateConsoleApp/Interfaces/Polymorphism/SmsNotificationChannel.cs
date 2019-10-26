using System;

namespace CSharpIntermediateConsoleApp.Interfaces.Polymorphism
{
    class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}