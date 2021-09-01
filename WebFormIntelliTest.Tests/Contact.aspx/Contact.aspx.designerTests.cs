namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ContactTests1
    {
        private Contact _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Contact();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Contact();
            Assert.IsNotNull(instance);
        }
    }
}