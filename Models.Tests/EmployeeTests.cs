namespace Models.Tests
{
    using Models;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class EmployeeTests
    {
        private Employee _testClass;
        private uint _monthlySalary;
        private double _hraPercent;
        private House _currentProperty;

        [SetUp]
        public void SetUp()
        {
            _monthlySalary = (uint)2071992243;
            _hraPercent = 1228787693.1;
            _currentProperty = new House { IsRented = true, Location = Location.NonMetro, MonthlyRent = (uint)1000136578 };
            _testClass = new Employee(_monthlySalary, _hraPercent, _currentProperty);
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Employee(_monthlySalary, _hraPercent, _currentProperty);
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CannotConstructWithNullCurrentProperty()
        {
            Assert.Throws<ArgumentNullException>(() => new Employee((uint)785643590, 1080820317.06, default(House)));
        }

        [Test]
        public void CanCallInitialize()
        {
            _testClass.Initialize();
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanGetAnnualHouseRentAllowance()
        {
            Assert.That(_testClass.AnnualHouseRentAllowance, Is.InstanceOf<uint>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanGetAnnualBasicSalary()
        {
            Assert.That(_testClass.AnnualBasicSalary, Is.InstanceOf<uint>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanGetProperty()
        {
            Assert.That(_testClass.Property, Is.InstanceOf<House>());
            Assert.Fail("Create or modify test");
        }
    }
}