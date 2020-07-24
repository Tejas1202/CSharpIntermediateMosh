using System;

namespace CSharpIntermediateConsoleApp.Polymorphism.Abstract
{
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }
}
