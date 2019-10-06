using System.Collections.Generic;

namespace CSharpIntermediateConsoleApp.Classes
{
    class Car
    {
        public int NumberPlate;
        public string Color;
        public List<Order> Orders = new List<Order>();

        public Car(int numberPlate)
        {
            this.NumberPlate = numberPlate;
        }

        public Car(int numberPlate, string color)
            : this(numberPlate)
        {
            this.Color = color;
        }

        public void Promote()
        {
            Orders = new List<Order>(); //Just to showcase the importance of readonly
            //Implementation
        }
    }
}
