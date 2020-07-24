namespace Amazon
{
    //Class members can be accessed across classes in the same library, but not in others (e.g in CSharpIntermediateConsoleApp, it's not accessible)
    // As RateCalculator is applicable (assume) to Employee/Amazon domain, avoid revealing it to a different assembly/domain
    internal class RateCalculator
    {
        public int Calculate(Employee employee)
        {
            return 0;
        }
    }
}
