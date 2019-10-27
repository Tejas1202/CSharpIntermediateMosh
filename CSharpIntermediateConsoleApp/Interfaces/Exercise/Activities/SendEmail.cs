using System;

namespace CSharpIntermediateConsoleApp.Interfaces.Exercise.Activities
{
    class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Your video processing has started. Please check email");
        }
    }
}
