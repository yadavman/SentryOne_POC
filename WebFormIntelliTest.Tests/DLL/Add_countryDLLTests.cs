namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Add_countryDLLTests
    {
        private Add_countryDLL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Add_countryDLL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Add_countryDLL();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanCallinsert()
        {
            var objectBLL = new Add_countryBLL();
            _testClass.insert(objectBLL);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallinsertWithNullObjectBLL()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.insert(default(Add_countryBLL)));
        }
    }
}