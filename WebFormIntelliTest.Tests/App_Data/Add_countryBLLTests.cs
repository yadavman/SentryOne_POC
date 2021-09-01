namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Add_countryBLLTests
    {
        private Add_countryBLL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Add_countryBLL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Add_countryBLL();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanCallinsert()
        {
            var objectBLL = new Add_countryBLL();
            _testClass.insert(objectBLL);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallinsertWithNullObjectBLL()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.insert(default(Add_countryBLL)));
        }

        [Test]
        public void CanSetAndGetCountry_name()
        {
            var testValue = "TestValue1821096679";
            _testClass.Country_name = testValue;
            Assert.That(_testClass.Country_name, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetStatus()
        {
            var testValue = false;
            _testClass.Status = testValue;
            Assert.That(_testClass.Status, Is.EqualTo(testValue));
        }
    }
}