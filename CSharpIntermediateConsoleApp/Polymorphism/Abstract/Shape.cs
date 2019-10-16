using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateConsoleApp.Polymorphism.Abstract
{
    abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        //If we keep this method as virtual and let's say Rectangle class doesn't override it, then when Rectangle object calls Draw method, it'll not do anything
        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copy shape to clipboard.");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape");
        }
    }
}
