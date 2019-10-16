using System;

namespace CSharpIntermediateConsoleApp.Polymorphism.Overriding.ProperlyStructured
{
    //Now here,we've the implementation details in the class itself as opposed to BadlyStructure code example (can also define properties here too related to Circle)
    //Hence we maintain Encapsulation also. This class doesn't gets bulky as it only knows about Circle
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }

    //Now as we add this third shape, it doesn't change anything in the Shape class as it doesn't know anything about triangle
    //Also, the DrawShapes method in the Canvas class remains unchanged
    //In this way, we design a loosely coupled application (zero/negligible impact on other classes)
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a triangle");
        }
    }

    //So instead of creating enum of ShapeType, we create classes for shape types
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual void Draw()
        {

        }
    }
}
