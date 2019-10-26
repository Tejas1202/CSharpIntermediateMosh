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
