namespace WebFormIntelliTest.Tests
{
    using CarsSystem.Data.Models;
    using System;
    using NUnit.Framework;
    using Moq;
    using System.Collections.Generic;

    [TestFixture]
    public class CarTests
    {
        private Car _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Car();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Car();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanSetAndGetId()
        {
            var testValue = 1230405889;
            _testClass.Id = testValue;
            Assert.That(_testClass.Id, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetManufacturer()
        {
            var testValue = "TestValue1839175739";
            _testClass.Manufacturer = testValue;
            Assert.That(_testClass.Manufacturer, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetModel()
        {
            var testValue = "TestValue11872319";
            _testClass.Model = testValue;
            Assert.That(_testClass.Model, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetTypeOfEngine()
        {
            var testValue = EngineType.Gasoline;
            _testClass.TypeOfEngine = testValue;
            Assert.That(_testClass.TypeOfEngine, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetRegistrationNumber()
        {
            var testValue = "TestValue879113707";
            _testClass.RegistrationNumber = testValue;
            Assert.That(_testClass.RegistrationNumber, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetVINNumber()
        {
            var testValue = "TestValue1442194892";
            _testClass.VINNumber = testValue;
            Assert.That(_testClass.VINNumber, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetCountOfTyres()
        {
            var testValue = (byte)115;
            _testClass.CountOfTyres = testValue;
            Assert.That(_testClass.CountOfTyres, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetCountOfDoors()
        {
            var testValue = (byte)123;
            _testClass.CountOfDoors = testValue;
            Assert.That(_testClass.CountOfDoors, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetTypeOfCar()
        {
            var testValue = CarType.Taxi;
            _testClass.TypeOfCar = testValue;
            Assert.That(_testClass.TypeOfCar, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetYearOfManufacturing()
        {
            var testValue = new DateTime(290379029);
            _testClass.YearOfManufacturing = testValue;
            Assert.That(_testClass.YearOfManufacturing, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetValidUntilAnnualCheckUp()
        {
            var testValue = new DateTime(1176252108);
            _testClass.ValidUntilAnnualCheckUp = testValue;
            Assert.That(_testClass.ValidUntilAnnualCheckUp, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetValidUntilVignette()
        {
            var testValue = new DateTime(1382589032);
            _testClass.ValidUntilVignette = testValue;
            Assert.That(_testClass.ValidUntilVignette, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetValidUntilInsurance()
        {
            var testValue = new DateTime(396445618);
            _testClass.ValidUntilInsurance = testValue;
            Assert.That(_testClass.ValidUntilInsurance, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetUserId()
        {
            var testValue = "TestValue2119531021";
            _testClass.UserId = testValue;
            Assert.That(_testClass.UserId, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetUser()
        {
            var testValue = new User { Id = "TestValue313835242", FirstName = "TestValue749654323", SecondName = "TestValue894856167", LastName = "TestValue1680155546", EGN = 1370494913L, NumberOfIdCard = 1444846562, DateOfIssue = new DateTime(874825182), City = "TestValue778892734", PhoneNumber = "TestValue1040294365", Email = "TestValue1949172834", Cars = new Mock<ICollection<Car>>().Object };
            _testClass.User = testValue;
            Assert.That(_testClass.User, Is.EqualTo(testValue));
        }
    }
}