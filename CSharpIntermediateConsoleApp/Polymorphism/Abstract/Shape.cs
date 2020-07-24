using System;

namespace CSharpIntermediateConsoleApp.Polymorphism.Abstract
{
    // Creating Shape class as abstract is also reasonable as creating instance of Shape class has no meaning as it's too abstract concept
    // Hence defining Shape class abstract to avoid creating instance from it as well as providing some common behaviour like Copy() which can be inherited in derived classes
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
