using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateConsoleApp.Polymorphism.Overriding.ProperlyStructured
{
    class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach(var shape in shapes)
            {
                shape.Draw(); //Hence at runtime, depending upon the type of object, it's respective Draw method will be called. And this is called Polymorphism (many forms)
            }
        }
    }
}
