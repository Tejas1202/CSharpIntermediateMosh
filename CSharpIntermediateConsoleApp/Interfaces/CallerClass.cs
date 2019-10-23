using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateConsoleApp.Interfaces
{
    class CallerClass
    {
        public void InterfaceAndTestability()
        {
            //Now, here in the Main method, we can create a dependency on ShippingCalculator
            //Main method knows about all concrete types and ties them together
            //The important part is OrderProcessor class doesn't know about ShippingCalculator class (i.e one concrete type doesn't know about other concrete types)
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { TotalPrice = 100f };
            orderProcessor.Process(order);
        }
    }
}
