namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class SiteMasterTests1
    {
        private SiteMaster _testClass1;

        [SetUp]
        public void SetUp()
        {
            _testClass1 = new SiteMaster();
        }

        [Test]
        public void CanConstruct1()
        {
            var instance = new SiteMaster();
            Assert.IsNotNull(instance);
        }
    }
}