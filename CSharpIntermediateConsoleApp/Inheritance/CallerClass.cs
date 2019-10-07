using Amazon;

namespace CSharpIntermediateConsoleApp.Inheritance
{
    class CallerClass
    {
        public void AccessModifiersCaller()
        {
            #region protected demo
            var employee = new Employee();

            //Now here in this method, we've a dependency of this calculator object. So changes in RateCalculator class breaks down the logic here. Hence defined RateCalculator class as internal
            //Amazon.RateCalculator rateCalculator = new RateCalculator(); So we keep the method as internal
            #endregion
        }
    }
}
