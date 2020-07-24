namespace CSharpIntermediateConsoleApp.Interfaces.Testability
{
    // Declaration of capabilities or services that a class should provide
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
}
