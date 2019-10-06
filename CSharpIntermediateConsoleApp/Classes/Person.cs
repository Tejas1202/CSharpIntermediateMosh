using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateConsoleApp.Classes
{
    public class Person
    {
        public string Name;
        public static string NameTwo;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
            NameTwo = to;
        }

        //Doesn't makes sense to keep this member as instance
        public Person Parse(string str)
        {
            var person = new Person
            {
                Name = str,
            };
            NameTwo = str;

            return person;
        }

        /// <summary>
        /// This method is similar to int.Parse or any other primitive type Parse methods
        /// You pass a string and get the respective type in return i.e here Person
        /// </summary>
        /// <param name="str">string to be Parsed</param>
        /// <returns>Person</returns>
        public static Person StaticParse(string str)
        {
            var person = new Person
            {
                Name = str
            };
            NameTwo = str;

            return person;
        }
    }
}
