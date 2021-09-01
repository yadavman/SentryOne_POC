namespace WebFormIntelliTest.Tests
{
    using CarsSystem.WebForms.Client.Customers;
    using System;
    using NUnit.Framework;
    using Moq;
    using CarsSystem.Services.Data.Contracts;

    [TestFixture]
    public class AllCustomersTests
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

        [Test]
        public void CanSetAndGetService()
        {
            var testValue = new Mock<IUsersService>().Object;
            _testClass.Service = testValue;
            Assert.That(_testClass.Service, Is.EqualTo(testValue));
        }
    }
}