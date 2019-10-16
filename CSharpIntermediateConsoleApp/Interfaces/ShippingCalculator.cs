namespace CSharpIntermediateConsoleApp.Interfaces
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice = 0.1f;

            return 0;
        }
    }
}
