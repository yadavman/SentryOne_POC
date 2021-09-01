namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Doner_regDLLTests
    {
        private Doner_regDLL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Doner_regDLL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Doner_regDLL();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanCallinsert()
        {
            var objectBLL = new Doner_regBLL();
            _testClass.insert(objectBLL);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallinsertWithNullObjectBLL()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.insert(default(Doner_regBLL)));
        }
    }
}