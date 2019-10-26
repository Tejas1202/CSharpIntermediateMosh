using System;

namespace CSharpIntermediateConsoleApp.Inheritance.ConstuctorInheritance
{
    class Car : Vehicle
    {
        /*We can't create parameterless constructor here if the parent class doesn't have any parameterless constructor.
        Because the runtime doesn't know how to create an object of Vehicle class as Parameter isn't supplied*/
        //public Car()
        //{
        //    //TODO
        //}

        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized. {0}", registrationNumber);
        }
    }
}