using DAL;
using System;
using NUnit.Framework;
using Models;
namespace DAL.Tests
{
    

    [TestFixture]
    public class DALTests
    {
        private DAL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new DAL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new DAL();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanCallHRA()
        {
            var e = new Employee((uint)496346723, 1579386310.92, new House { IsRented = true, Location = Location.Metro, MonthlyRent = (uint)381342987 });
            var result = _testClass.HRA(e);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallHRAWithNullE()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.HRA(default(Employee)));
        }
    }
}