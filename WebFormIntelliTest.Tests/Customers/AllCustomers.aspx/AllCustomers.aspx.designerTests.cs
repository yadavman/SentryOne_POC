namespace WebFormIntelliTest.Tests
{
    using CarsSystem.WebForms.Client.Customers;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class AllCustomersTests1
    {
        private AllCustomers _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new AllCustomers();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new AllCustomers();
            Assert.IsNotNull(instance);
        }
    }
}