namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class OrganizationBLLTests
    {
        private OrganizationBLL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new OrganizationBLL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new OrganizationBLL();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanCallinsert()
        {
            var objectBLL = new OrganizationBLL();
            _testClass.insert(objectBLL);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallinsertWithNullObjectBLL()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.insert(default(OrganizationBLL)));
        }

        [Test]
        public void CanSetAndGetOrg_name()
        {
            var testValue = "TestValue887718558";
            _testClass.Org_name = testValue;
            Assert.That(_testClass.Org_name, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetOrg_type()
        {
            var testValue = "TestValue242791477";
            _testClass.Org_type = testValue;
            Assert.That(_testClass.Org_type, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetEid()
        {
            var testValue = "TestValue1756606525";
            _testClass.Eid = testValue;
            Assert.That(_testClass.Eid, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetCountry()
        {
            var testValue = "TestValue93640283";
            _testClass.Country = testValue;
            Assert.That(_testClass.Country, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetState()
        {
            var testValue = "TestValue367932677";
            _testClass.State = testValue;
            Assert.That(_testClass.State, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetCity()
        {
            var testValue = "TestValue19556039";
            _testClass.City = testValue;
            Assert.That(_testClass.City, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetPhone_no()
        {
            var testValue = "TestValue1932668314";
            _testClass.Phone_no = testValue;
            Assert.That(_testClass.Phone_no, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetMobile_no()
        {
            var testValue = "TestValue1154635503";
            _testClass.Mobile_no = testValue;
            Assert.That(_testClass.Mobile_no, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetAddress()
        {
            var testValue = "TestValue262622687";
            _testClass.Address = testValue;
            Assert.That(_testClass.Address, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetUser_name()
        {
            var testValue = "TestValue583437209";
            _testClass.User_name = testValue;
            Assert.That(_testClass.User_name, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetPassword()
        {
            var testValue = "TestValue1579693265";
            _testClass.Password = testValue;
            Assert.That(_testClass.Password, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetHint_que()
        {
            var testValue = "TestValue732281182";
            _testClass.Hint_que = testValue;
            Assert.That(_testClass.Hint_que, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetHint_ans()
        {
            var testValue = "TestValue410684651";
            _testClass.Hint_ans = testValue;
            Assert.That(_testClass.Hint_ans, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetStatus()
        {
            var testValue = true;
            _testClass.Status = testValue;
            Assert.That(_testClass.Status, Is.EqualTo(testValue));
        }
    }
}