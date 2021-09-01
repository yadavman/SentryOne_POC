namespace WebFormIntelliTest.Tests
{
    using CarsSystem.Data.Models;
    using System;
    using NUnit.Framework;
    using Moq;
    using System.Collections.Generic;

    [TestFixture]
    public class UserTests
    {
        private User _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new User();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new User();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanSetAndGetId()
        {
            var testValue = "TestValue1998143369";
            _testClass.Id = testValue;
            Assert.That(_testClass.Id, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetFirstName()
        {
            var testValue = "TestValue597047597";
            _testClass.FirstName = testValue;
            Assert.That(_testClass.FirstName, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetSecondName()
        {
            var testValue = "TestValue1040615471";
            _testClass.SecondName = testValue;
            Assert.That(_testClass.SecondName, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetLastName()
        {
            var testValue = "TestValue408080090";
            _testClass.LastName = testValue;
            Assert.That(_testClass.LastName, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetEGN()
        {
            var testValue = 414931668L;
            _testClass.EGN = testValue;
            Assert.That(_testClass.EGN, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetNumberOfIdCard()
        {
            var testValue = 899069365;
            _testClass.NumberOfIdCard = testValue;
            Assert.That(_testClass.NumberOfIdCard, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetDateOfIssue()
        {
            var testValue = new DateTime(722044332);
            _testClass.DateOfIssue = testValue;
            Assert.That(_testClass.DateOfIssue, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetCity()
        {
            var testValue = "TestValue2030145671";
            _testClass.City = testValue;
            Assert.That(_testClass.City, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetPhoneNumber()
        {
            var testValue = "TestValue340178347";
            _testClass.PhoneNumber = testValue;
            Assert.That(_testClass.PhoneNumber, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetEmail()
        {
            var testValue = "TestValue1621546188";
            _testClass.Email = testValue;
            Assert.That(_testClass.Email, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetCars()
        {
            var testValue = new Mock<ICollection<Car>>().Object;
            _testClass.Cars = testValue;
            Assert.That(_testClass.Cars, Is.EqualTo(testValue));
        }
    }
}