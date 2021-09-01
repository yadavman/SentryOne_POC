namespace WebFormIntelliTest.Tests
{
    using CarsSystem.WebForms.Client.Customers;
    using System;
    using NUnit.Framework;
    using Moq;
    using CarsSystem.Services.Data.Contracts;

    [TestFixture]
    public class CustomerDetailsTests
    {
        private CustomerDetails _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new CustomerDetails();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new CustomerDetails();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanSetAndGetUsersService()
        {
            var testValue = new Mock<IUsersService>().Object;
            _testClass.UsersService = testValue;
            Assert.That(_testClass.UsersService, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetCarsService()
        {
            var testValue = new Mock<ICarsService>().Object;
            _testClass.CarsService = testValue;
            Assert.That(_testClass.CarsService, Is.EqualTo(testValue));
        }
    }
}