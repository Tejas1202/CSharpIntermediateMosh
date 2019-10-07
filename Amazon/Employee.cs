namespace Amazon
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rateCalculator = new RateCalculator(); //Caveat: Its not good to instantiate a new object inside a method here as this creates coupling/dependency to this object. We'll see proper way in Interfaces afterwards
            var rating = rateCalculator.Calculate(this);
        }
    }
}
