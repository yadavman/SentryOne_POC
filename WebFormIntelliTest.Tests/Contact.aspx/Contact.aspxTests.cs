namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ContactTests
    {
        private Contact _testClass1;

        [SetUp]
        public void SetUp()
        {
            _testClass1 = new Contact();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Contact();
            Assert.IsNotNull(instance);
        }
    }
}