using System.Collections.Generic;

namespace CSharpIntermediateConsoleApp.Classes
{
    class Customer
    {
        public int Id; //In real world example, we don't create fields with public access modifiers like this (instead properties are used)
        public string Name;
        public List<Order> Orders;
        public List<Order> LargeOrders = new List<Order>(); //Hence here, we don't need to use constructor. Also usage of this() also is not needed to initialize 
        //this list in case of constructor overloading

        //Constructor overloading

        //Initializing the Orders member so we an object is created in any other class, this List will not be null which avoids null reference exception
        public Customer()
        {
            Orders = new List<Order>();
        }

        //Here in this case, the below two constructors are not that much important to create, as creating an object directly and
        //after that assigning the class members will still do
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

    }
}
