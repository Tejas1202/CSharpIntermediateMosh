using System;

namespace CSharpIntermediateConsoleApp.Interfaces.Polymorphism
{
    class MailService
    {
        public void Send(Mail mail)
        {
            Console.WriteLine("Sending email...");
        }
    }
}