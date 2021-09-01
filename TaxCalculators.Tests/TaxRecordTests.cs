namespace TaxCalculators.Tests
{
    using TaxCalculators;
    using System;
    using NUnit.Framework;
    using Moq;
    using DAL;
    using Models;

    [TestFixture]
    public class TaxRecordTests
    {
        private TaxRecord _testClass;
        private IDAL _id;

        [SetUp]
        public void SetUp()
        {
            _id = new Mock<IDAL>().Object;
            _testClass = new TaxRecord(_id);
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new TaxRecord(_id);
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CannotConstructWithNullId()
        {
            Assert.Throws<ArgumentNullException>(() => new TaxRecord(default(IDAL)));
        }

        [Test]
        public void CanCallEmployeeHRADeductionEligible()
        {
            var employee = new Employee((uint)1132029774, 1518117282.99, new House { IsRented = true, Location = Location.Metro, MonthlyRent = (uint)261216113 });
            var result = _testClass.EmployeeHRADeductionEligible(employee);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallEmployeeHRADeductionEligibleWithNullEmployee()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.EmployeeHRADeductionEligible(default(Employee)));
        }
    }
}