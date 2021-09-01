namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;
    using System.Web.Optimization;

    [TestFixture]
    public class BundleConfigTests
    {
        private BundleConfig _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new BundleConfig();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new BundleConfig();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanCallRegisterBundles()
        {
            var bundles = new BundleCollection();
            BundleConfig.RegisterBundles(bundles);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallRegisterBundlesWithNullBundles()
        {
            Assert.Throws<ArgumentNullException>(() => BundleConfig.RegisterBundles(default(BundleCollection)));
        }
    }
}