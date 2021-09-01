namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Seeker_request_for_bloodDLLTests
    {
        private Seeker_request_for_bloodDLL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Seeker_request_for_bloodDLL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Seeker_request_for_bloodDLL();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanCallinsert()
        {
            var objectBLL = new Seeker_request_for_bloodBLL();
            _testClass.insert(objectBLL);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallinsertWithNullObjectBLL()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.insert(default(Seeker_request_for_bloodBLL)));
        }
    }
}