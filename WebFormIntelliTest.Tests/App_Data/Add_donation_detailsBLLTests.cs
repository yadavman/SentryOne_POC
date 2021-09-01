namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Add_donation_detailsBLLTests
    {
        private Add_donation_detailsBLL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Add_donation_detailsBLL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Add_donation_detailsBLL();
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

        [Test]
        public void CanSetAndGetSelect_org()
        {
            var testValue = "TestValue1576980881";
            _testClass.Select_org = testValue;
            Assert.That(_testClass.Select_org, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetD_id()
        {
            var testValue = "TestValue135587816";
            _testClass.D_id = testValue;
            Assert.That(_testClass.D_id, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetD_name()
        {
            var testValue = "TestValue1650334411";
            _testClass.D_name = testValue;
            Assert.That(_testClass.D_name, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetBlood_group()
        {
            var testValue = "TestValue1505051432";
            _testClass.Blood_group = testValue;
            Assert.That(_testClass.Blood_group, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetBlood_quantity()
        {
            var testValue = "TestValue207382445";
            _testClass.Blood_quantity = testValue;
            Assert.That(_testClass.Blood_quantity, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetStatus()
        {
            var testValue = false;
            _testClass.Status = testValue;
            Assert.That(_testClass.Status, Is.EqualTo(testValue));
        }
    }
}