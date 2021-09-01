namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class testDLLTests
    {
        private testDLL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new testDLL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new testDLL();
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
    }
}