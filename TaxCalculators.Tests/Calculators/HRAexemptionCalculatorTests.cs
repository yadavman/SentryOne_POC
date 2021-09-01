namespace TaxCalculators.Tests
{
    using TaxCalculators;
    using System;
    using NUnit.Framework;
    using Models;

    [TestFixture]
    public class HRAexemptionCalculatorTests
    {
        private HRAexemptionCalculator _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new HRAexemptionCalculator();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new HRAexemptionCalculator();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanCallcalculate()
        {
            var IsRented = true;
            var location = Location.Metro;
            var AnnualBasicSalary = (uint)345508166;
            var MonthlyRent = (uint)1840652718;
            var AnnualHouseRentAllowance = (uint)960684803;
            var result = _testClass.calculate(IsRented, location, AnnualBasicSalary, MonthlyRent, AnnualHouseRentAllowance);
            Assert.Fail("Create or modify test");
        }
    }
}