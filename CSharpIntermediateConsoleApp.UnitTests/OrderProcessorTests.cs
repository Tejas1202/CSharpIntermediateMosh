﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpIntermediateConsoleApp.Interfaces.Testability;

// Here we're using Microsoft VS's inbuilt test framework, but whatever framework you choose viz. NUnit/JUnit Framework etc., the underlying principles remain the same
// i.e. Unit test a class's methods independently by passing FakeClass implementing the Interface which class has a dependency on
namespace CSharpIntermediateConsoleApp.UnitTests
{
    // Microsoft's Test Runner will look for these attributes to run tests on them
    [TestClass]
    public class OrderProcessorTests
    {
        //METHODNAME_CONDITION_EXPECTATION

        #region Testing OrderProcessor class's Processor method
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowAnException()
        {
            //Now here, we aren't going to pass that original ShippingCalculator, as we want isolate OrderProcessor, hence we create FakeShippingCalculator
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };

            //Here what we need to Assert is that an exception is thrown. We can do that using visual studio's attribute ExpectedException
            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcessor.Process(order);
            Assert.IsTrue(order.IsShipped); //Making sure IsShipped is set to true after placing the order
            Assert.AreEqual(1, order.Shipment.Cost); // As our Fake class's method is returning 1
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
        #endregion
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        //We're not gonna write implementation in detail as we assume this fake/dummy class is doing it's job properly
        //Our focus is on testing OrderProcessor class
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}