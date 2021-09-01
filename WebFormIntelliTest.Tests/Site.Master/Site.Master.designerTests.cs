namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class SiteMasterTests
    {
        private SiteMaster _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new SiteMaster();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new SiteMaster();
            Assert.IsNotNull(instance);
        }
    }
}