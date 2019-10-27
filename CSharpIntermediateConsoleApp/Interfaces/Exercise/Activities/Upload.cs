using System;

namespace CSharpIntermediateConsoleApp.Interfaces.Exercise.Activities
{
    class Upload : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video uploaded to cloud storage");
        }
    }
}
