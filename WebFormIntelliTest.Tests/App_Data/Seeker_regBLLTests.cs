namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Seeker_regBLLTests
    {
        private Seeker_regBLL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Seeker_regBLL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Seeker_regBLL();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanCallinsert()
        {
            var objectBLL = new Seeker_regBLL();
            _testClass.insert(objectBLL);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallinsertWithNullObjectBLL()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.insert(default(Seeker_regBLL)));
        }

        [Test]
        public void CanSetAndGetS_user_name()
        {
            var testValue = "TestValue1865400526";
            _testClass.S_user_name = testValue;
            Assert.That(_testClass.S_user_name, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetGender()
        {
            var testValue = "TestValue254387404";
            _testClass.Gender = testValue;
            Assert.That(_testClass.Gender, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetWeight()
        {
            var testValue = "TestValue1543349228";
            _testClass.Weight = testValue;
            Assert.That(_testClass.Weight, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetDob()
        {
            var testValue = "TestValue1816812538";
            _testClass.Dob = testValue;
            Assert.That(_testClass.Dob, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetBlood_group()
        {
            var testValue = "TestValue698278893";
            _testClass.Blood_group = testValue;
            Assert.That(_testClass.Blood_group, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetEmail()
        {
            var testValue = "TestValue90655600";
            _testClass.Email = testValue;
            Assert.That(_testClass.Email, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetCountry()
        {
            var testValue = "TestValue1478117656";
            _testClass.Country = testValue;
            Assert.That(_testClass.Country, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetState()
        {
            var testValue = "TestValue915671184";
            _testClass.State = testValue;
            Assert.That(_testClass.State, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetCity()
        {
            var testValue = "TestValue2076439882";
            _testClass.City = testValue;
            Assert.That(_testClass.City, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetMo_no()
        {
            var testValue = "TestValue1006952202";
            _testClass.Mo_no = testValue;
            Assert.That(_testClass.Mo_no, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetAddress()
        {
            var testValue = "TestValue1346267763";
            _testClass.Address = testValue;
            Assert.That(_testClass.Address, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetS_user_id()
        {
            var testValue = "TestValue835260778";
            _testClass.S_user_id = testValue;
            Assert.That(_testClass.S_user_id, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetS_password()
        {
            var testValue = "TestValue796544773";
            _testClass.S_password = testValue;
            Assert.That(_testClass.S_password, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetHint_que()
        {
            var testValue = "TestValue487821752";
            _testClass.Hint_que = testValue;
            Assert.That(_testClass.Hint_que, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetHint_ans()
        {
            var testValue = "TestValue279810321";
            _testClass.Hint_ans = testValue;
            Assert.That(_testClass.Hint_ans, Is.EqualTo(testValue));
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