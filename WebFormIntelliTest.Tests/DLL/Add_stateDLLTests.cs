namespace WebFormIntelliTest.Tests
{
    using System;
    using NUnit.Framework;
    using WebFormIntelliTest;

    [TestFixture]
    public class Add_stateDLLTests
    {
        private Add_stateDLL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Add_stateDLL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Add_stateDLL();
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
    }
}