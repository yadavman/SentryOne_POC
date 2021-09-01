namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Seeker_request_for_bloodBLLTests
    {
        private Seeker_request_for_bloodBLL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Seeker_request_for_bloodBLL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Seeker_request_for_bloodBLL();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanCallinsert()
        {
            var objectBLL = new Seeker_request_for_bloodBLL();
            _testClass.insert(objectBLL);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallinsertWithNullObjectBLL()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.insert(default(Seeker_request_for_bloodBLL)));
        }

        [Test]
        public void CanSetAndGetS_name()
        {
            var testValue = "TestValue1690626491";
            _testClass.S_name = testValue;
            Assert.That(_testClass.S_name, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetS_id()
        {
            var testValue = "TestValue1778004078";
            _testClass.S_id = testValue;
            Assert.That(_testClass.S_id, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetMo_no()
        {
            var testValue = "TestValue881621460";
            _testClass.Mo_no = testValue;
            Assert.That(_testClass.Mo_no, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetOrg_name()
        {
            var testValue = "TestValue1961120701";
            _testClass.Org_name = testValue;
            Assert.That(_testClass.Org_name, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetBlood_group()
        {
            var testValue = "TestValue689225190";
            _testClass.Blood_group = testValue;
            Assert.That(_testClass.Blood_group, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetBlood_quantity()
        {
            var testValue = "TestValue1457320436";
            _testClass.Blood_quantity = testValue;
            Assert.That(_testClass.Blood_quantity, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetRequest()
        {
            var testValue = "TestValue1986939383";
            _testClass.Request = testValue;
            Assert.That(_testClass.Request, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetRemark()
        {
            var testValue = "TestValue644279863";
            _testClass.Remark = testValue;
            Assert.That(_testClass.Remark, Is.EqualTo(testValue));
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