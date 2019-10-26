using Amazon;
using CSharpIntermediateConsoleApp.Inheritance.Casting;
using CSharpIntermediateConsoleApp.Inheritance.ConstuctorInheritance;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace CSharpIntermediateConsoleApp.Inheritance
{
    class CallerClass
    {
        public void AccessModifiersCaller()
        {
            #region internal demo
            var employee = new Employee();

            //Now here in this method, we've a dependency of this calculator object. So changes in RateCalculator class breaks down the logic here. Hence defined RateCalculator class as internal
            //Amazon.RateCalculator rateCalculator = new RateCalculator(); So we keep the method as internal
            #endregion
        }

        public void ConstructorInheritance()
        {
            var car = new Car("XYZ 1234");
        }

        public void UpCasting()
        {
            Text text = new Text();
            Shape shape = text; //Upcasting; implicit in nature
            //shape object won't be able to access FontName and FontSize properties as it has a different view than text object (eventhough it'll have those properties references at runtime)

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width); //text and shape are both references to the same object in memory, hence the value of text.Width becomes 100. They just have different views

            #region real world example of Upcasting
            StreamReader reader = new StreamReader(new MemoryStream()); //Or we can pass a FileStream object too, as both the classes derive from Stream class, so they will be automatically upcasted

            //Note: Recommendation(by Mosh) is you should not use ArrayList as they may result in exceptions. That's y we use generic list
            ArrayList list = new ArrayList();
            list.Add(1); //As Add method expects object and as every class in C# derives from object class, so we can add any type here
            list.Add("Mosh"); //Ultimately they all gets upcasted to Object type
            list.Add(new Text());

            var anotherList = new List<int>(); //Generic list
            var shapeList = new List<Shape>();
            #endregion
        }

        public void DownCasting()
        {
            Shape shape = new Text(); //Check the type of object in this line in watch window. It'll be of type Text
            Text text = (Text)shape;
            //Here in this way, the text object will now be able to access FontName and FontSize properties
        }

        public void BoxingUnboxingExample()
        {
            Text text = new Text();
            object obj = text;

            //But when value type is converted to reference type, it's called boxing
            object number = 10;
            int no = (int)number; //Unboxing

            var list = new ArrayList();
            list.Add(1); //Boxing
            list.Add("Mosh"); //No boxing
            list.Add(DateTime.Now); //Boxing

            var cast = (int)list[1]; //Invalid cast exception
        }

        public void Exercise()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push("Mosh");
            stack.Push(DateTime.Now);
            //stack.Push(null);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            stack.Clear();
        }
    }
}
