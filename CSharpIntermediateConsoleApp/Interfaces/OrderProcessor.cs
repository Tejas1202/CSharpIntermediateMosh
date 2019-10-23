using System;

namespace CSharpIntermediateConsoleApp.Interfaces
{
    public class OrderProcessor
    {
        //#region tight coupling
        //private readonly ShippingCalculator _shippingCalculator;

        //public OrderProcessor()
        //{
        //    _shippingCalculator = new ShippingCalculator();
        //}
        //#endregion

        #region loose coupling
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
