using System;

namespace CSharpIntermediateConsoleApp.Interfaces.Exercise.Activities
{
    class CallService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video ready for encoding");
        }
    }
}
