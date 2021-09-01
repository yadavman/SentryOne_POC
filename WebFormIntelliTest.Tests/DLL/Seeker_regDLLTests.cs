namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Seeker_regDLLTests
    {
        private Seeker_regDLL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Seeker_regDLL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Seeker_regDLL();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanCallinsert()
        {
            var objectBLL = new Seeker_regBLL();
            _testClass.insert(objectBLL);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallinsertWithNullObjectBLL()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.insert(default(Seeker_regBLL)));
        }
    }
}