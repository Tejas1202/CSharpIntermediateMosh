using CSharpIntermediateConsoleApp.Interfaces.Extensibility;
using CSharpIntermediateConsoleApp.Interfaces.Polymorphism;
using CSharpIntermediateConsoleApp.Interfaces.Testability;

namespace CSharpIntermediateConsoleApp.Interfaces
{
    class CallerClass
    {
        public void InterfaceAndTestability()
        {
            #region for tight coupling
            //var orderProcessor = new OrderProcessor();
            #endregion


            //Now, here in the Main method, we can create a dependency on ShippingCalculator
            //Main method knows about all concrete types and ties them together
            //The important part is OrderProcessor class doesn't know about ShippingCalculator class (i.e one concrete type doesn't know about other concrete types)
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { TotalPrice = 100f };
            orderProcessor.Process(order);
        }

        public void InterfaceAndExtensibility()
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger()); //passing a concrete class here
            dbMigrator.Migrate();

            //Now changing the behaviour by logging into file instead of console
            //And in doing this, we didn't changed a single line of DbMigrator (OCP priciple)
            var dbMigratorTwo = new DbMigrator(new FileLogger(@"E:\log.txt"));

            dbMigratorTwo.Migrate();
        }

        public void InterfacesAndPolymorphism()
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.Encode(new Video());
        }
    }
}
