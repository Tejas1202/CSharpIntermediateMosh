﻿using System;

namespace CSharpIntermediateConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var caller = new Polymorphism.CallerClass();
                caller.OverridingExample();
                caller.AbstractExample();
                caller.Exercise();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred. More details: " + ex.Message);
            }
        }
    }
}
