namespace Models.Tests
{
    using Models;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class HouseTests
    {
        private House _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new House();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new House();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanSetAndGetIsRented()
        {
            var testValue = true;
            _testClass.IsRented = testValue;
            Assert.That(_testClass.IsRented, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetLocation()
        {
            var testValue = Location.NonMetro;
            _testClass.Location = testValue;
            Assert.That(_testClass.Location, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetMonthlyRent()
        {
            var testValue = (uint)68920607;
            _testClass.MonthlyRent = testValue;
            Assert.That(_testClass.MonthlyRent, Is.EqualTo(testValue));
        }
    }
}