namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ViewSwitcherTests1
    {
        private ViewSwitcher _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new ViewSwitcher();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new ViewSwitcher();
            Assert.IsNotNull(instance);
        }
    }
}