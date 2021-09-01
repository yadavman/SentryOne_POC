namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class AboutTests
    {
        private About _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new About();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new About();
            Assert.IsNotNull(instance);
        }
    }
}