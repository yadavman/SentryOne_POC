namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Ad_cityDLLTests
    {
        private Ad_cityDLL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Ad_cityDLL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Ad_cityDLL();
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
    }
}