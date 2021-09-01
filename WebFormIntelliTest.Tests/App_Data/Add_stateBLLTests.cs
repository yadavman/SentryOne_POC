namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Add_stateBLLTests
    {
        private Add_stateBLL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Add_stateBLL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Add_stateBLL();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanCallinsert()
        {
            var objectBLL = new Add_stateBLL();
            _testClass.insert(objectBLL);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallinsertWithNullObjectBLL()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.insert(default(Add_stateBLL)));
        }

        [Test]
        public void CanSetAndGetState_name()
        {
            var testValue = "TestValue1576943748";
            _testClass.State_name = testValue;
            Assert.That(_testClass.State_name, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetCountry()
        {
            var testValue = "TestValue1700111913";
            _testClass.Country = testValue;
            Assert.That(_testClass.Country, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetStatus()
        {
            var testValue = true;
            _testClass.Status = testValue;
            Assert.That(_testClass.Status, Is.EqualTo(testValue));
        }
    }
}