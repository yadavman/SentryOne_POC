namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class _DefaultTests
    {
        private _Default _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new _Default();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new _Default();
            Assert.IsNotNull(instance);
        }
    }
}