using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateConsoleApp.Classes
{
    public class ParameterModifiers
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public void DoAWeirdThing(ref int a)
        {
            a += 2;
        }

        public void ConvertToInt(string str)
        {
            try
            {
                var num = int.Parse(str);
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed");
            }

            var result = int.TryParse(str, out int number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");
        }
    }
}
