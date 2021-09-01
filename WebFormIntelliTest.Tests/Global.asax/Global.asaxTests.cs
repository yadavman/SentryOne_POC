namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class GlobalTests
    {
        private Global _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Global();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Global();
            Assert.IsNotNull(instance);
        }
    }
}