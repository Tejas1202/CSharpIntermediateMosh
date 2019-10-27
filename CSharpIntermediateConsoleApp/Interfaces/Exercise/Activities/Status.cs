using System;

namespace CSharpIntermediateConsoleApp.Interfaces.Exercise.Activities
{
    class Status : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Database result: Processing");
        }
    }
}
