namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class testBLLTests
    {
        private testBLL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new testBLL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new testBLL();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanCallinsert()
        {
            var objectBLL = new testBLL();
            _testClass.insert(objectBLL);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallinsertWithNullObjectBLL()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.insert(default(testBLL)));
        }

        [Test]
        public void CanSetAndGetName1()
        {
            var testValue = "TestValue815616869";
            _testClass.Name1 = testValue;
            Assert.That(_testClass.Name1, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetName()
        {
            var testValue = "TestValue1897960900";
            _testClass.Name = testValue;
            Assert.That(_testClass.Name, Is.EqualTo(testValue));
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