namespace TaxCalculators.Tests
{
    using TaxCalculators;
    using System;
    using NUnit.Framework;
    using Moq;
    using Models;

    [TestFixture]
    public class TaxCalculatorTests
    {
        private TaxCalculator _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new TaxCalculator();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new TaxCalculator();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanCallCalculateExemptionForRent()
        {
            var employee = new Employee((uint)584132737, 394228397.96999997, new House { IsRented = true, Location = Location.Metro, MonthlyRent = (uint)939663627 });
            var ic = new Mock<ITaxCalculator>().Object;
            var result = _testClass.CalculateExemptionForRent(employee, ic);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallCalculateExemptionForRentWithNullEmployee()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.CalculateExemptionForRent(default(Employee), new Mock<ITaxCalculator>().Object));
        }

        [Test]
        public void CannotCallCalculateExemptionForRentWithNullIc()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.CalculateExemptionForRent(new Employee((uint)2098884979, 1147707754.3799999, new House { IsRented = false, Location = Location.NonMetro, MonthlyRent = (uint)133785727 }), default(ITaxCalculator)));
        }
    }
}