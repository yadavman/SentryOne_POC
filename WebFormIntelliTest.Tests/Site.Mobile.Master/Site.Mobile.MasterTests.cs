namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Site_MobileTests1
    {
        private Site_Mobile _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Site_Mobile();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Site_Mobile();
            Assert.IsNotNull(instance);
        }
    }
}