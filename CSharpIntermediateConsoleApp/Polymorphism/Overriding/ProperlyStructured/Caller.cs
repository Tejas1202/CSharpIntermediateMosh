using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateConsoleApp.Polymorphism.Overriding.ProperlyStructured
{
    class Caller
    {
        public void Call()
        {
            var shapes = new List<Shape>
            {
                new Circle(),
                new Rectangle()
            };

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
