namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Add_cityBLLTests
    {
        private Add_cityBLL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Add_cityBLL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Add_cityBLL();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanCallinsert()
        {
            var objectBLL = new Add_cityBLL();
            _testClass.insert(objectBLL);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallinsertWithNullObjectBLL()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.insert(default(Add_cityBLL)));
        }

        [Test]
        public void CanSetAndGetCity_name()
        {
            var testValue = "TestValue204085535";
            _testClass.City_name = testValue;
            Assert.That(_testClass.City_name, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetCountry()
        {
            var testValue = "TestValue451034139";
            _testClass.Country = testValue;
            Assert.That(_testClass.Country, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetState()
        {
            var testValue = "TestValue331112732";
            _testClass.State = testValue;
            Assert.That(_testClass.State, Is.EqualTo(testValue));
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