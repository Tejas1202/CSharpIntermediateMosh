using System;
using System.Collections.Generic;

namespace CSharpIntermediateConsoleApp.Polymorphism.Overriding.BadlyStructured
{
    class Canvas
    {
        //Cons: 
        //If we want to add any new Shape(ex. Triangle here) first we've to add it's enum and then this method has to be changed for implementing algorithm
        //As a result, this Canvas class containing this method has to recompiled and redeployed
        //Hence any class in this application which uses this class also needs to be recompiled and redeployed (and same is the case of ShapeType enum)
        //As a result, there's a lot of tight coupling
        //Also, as the number of shapes increases, this method is gonna get really fat and complex (including refactor also)
        //Reasons we've problem with this code is:
        //The Shape class has only properties, it doesn't have any behaviour
        //Acc. to Encapsulation principle, we want to have data and behaviour encapsulated in the same class
        //Here data is somewhere and behaviour as somewhere else (here data in Shape class while behaviour in Canvas method)
        public void DrawShapes(List<Shape> shapes)
        {
            foreach(var shape in shapes)
            {
                switch (shape.Type)
                {
                    case ShapeType.Circle:
                        Console.WriteLine("Draw a circle"); //Algorithm here
                        break;
                    case ShapeType.Rectangle:
                        Console.WriteLine("Draw a rectangle");
                        break;
                    case ShapeType.Triangle:
                        Console.WriteLine("Draw a triangle");
                        break;
                }
            }
        }
    }
}
