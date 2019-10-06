﻿using CSharpIntermediateConsoleApp.Classes;
using CSharpIntermediateConsoleApp.ClassesAssociation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateConsoleApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var caller = new ClassesAssociation.CallerClass();
                caller.CompositionExample();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred. More details: " + ex.Message);
            }
        }
    }
}