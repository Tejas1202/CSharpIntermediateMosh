using System;

namespace CSharpIntermediateConsoleApp.Interfaces.Testability
{
    public class OrderProcessor
    {
        //#region tight coupling (because we cannot isolate OrderProcessor class from ShippingCalculator class here)
        //private readonly ShippingCalculator _shippingCalculator;

        //public OrderProcessor()
        //{
        //    _shippingCalculator = new ShippingCalculator();
        //}
        //#endregion

        #region loose coupling (hence now, even if we change anything in the ShippingCalculator class, it doesn't change anything here as OrderProcessor doesn't know anything about that class)
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            // If we do this, then again it becomes a dependency on concrete class ShippingCalculator in OrderProcessor which we wanted to avoid in the first place
            // hence passing IShippingCalculator as argument which we can assing concrete class during runtime either through Main method or Dependency Injection
            // _shippingCalculator = new ShippingCalculator();
            _shippingCalculator = shippingCalculator;
        }
        #endregion

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
