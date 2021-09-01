namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Add_donation_detailsDLLTests
    {
        private Add_donation_detailsDLL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Add_donation_detailsDLL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Add_donation_detailsDLL();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanCallinsert()
        {
            var objectBLL = new Add_donation_detailsBLL();
            _testClass.insert(objectBLL);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallinsertWithNullObjectBLL()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.insert(default(Add_donation_detailsBLL)));
        }
    }
}