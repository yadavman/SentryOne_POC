namespace WebFormIntelliTest.Tests
{
    using CarsSystem.WebForms.Client.Customers;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class CustomerDetailsTests1
    {
        private CustomerDetails _testClass1;

        [SetUp]
        public void SetUp()
        {
            _testClass1 = new CustomerDetails();
        }

        [Test]
        public void CanConstruct1()
        {
            var instance = new CustomerDetails();
            Assert.IsNotNull(instance);
        }
    }
}