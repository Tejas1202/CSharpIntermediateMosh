using System;

namespace CSharpIntermediateConsoleApp.Inheritance.ConstuctorInheritance
{
    class Vehicle
    {
        private readonly string _registrationNumber;

        //If we keep a paramterless ctor, than we can also create a paramaterless ctor in derived classes too (same as ctor overloading)
        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being initialized. {0}", registrationNumber);
        }
    }
}