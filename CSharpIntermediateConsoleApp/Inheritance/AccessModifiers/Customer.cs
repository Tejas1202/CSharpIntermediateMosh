using System;

namespace CSharpIntermediateConsoleApp.Inheritance.AccessModifiers
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //We may want to Promote a customer, so it's okay if we keep this as a part of public interface
        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);

            if (rating == 0)
                Console.WriteLine("Promoted to level 1");
            else
                Console.WriteLine("Promoted to level 2");
        }

        //This method is about implementation details/how a customer is promoted. So we should keep this member as private
        //Here we should not define this method as public because it's an how we calculate rating is an internal mechanism.
        //Also if we declare it as public, then it'll be available in the public interface and any object can call this method and then manipulate the ratings by creating a method like Promote
        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
