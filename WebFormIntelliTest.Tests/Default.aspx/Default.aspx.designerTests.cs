namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class _DefaultTests1
    {
        private _Default _testClass1;

        [SetUp]
        public void SetUp()
        {
            _testClass1 = new _Default();
        }

        [Test]
        public void CanConstruct1()
        {
            var instance = new _Default();
            Assert.IsNotNull(instance);
        }
    }
}