namespace CSharpIntermediateConsoleApp.Inheritance.AccessModifiers
{
    class GoldCustomer : Customer
    {
        //But let's say tomorrow if the Customer class changes it's CalculateRating logic/Rename the method or maybe even delete the whole method, then the code breaks here
        //Hence use protected keyword only when some business domain logic is stable or when it makes sense to make it necessary 
        public void OfferVoucher()
        {
            var rating = this.CalculateRating(excludeOrders: true);
        }
    }
}
