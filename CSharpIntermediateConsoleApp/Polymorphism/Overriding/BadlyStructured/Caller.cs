using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateConsoleApp.Polymorphism.Overriding.BadlyStructured
{
    class Caller
    {
        public void Call()
        {
            var shapes = new List<Shape>();
            shapes.Add(new Shape { Type = ShapeType.Circle });
            shapes.Add(new Shape { Type = ShapeType.Rectangle });

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
