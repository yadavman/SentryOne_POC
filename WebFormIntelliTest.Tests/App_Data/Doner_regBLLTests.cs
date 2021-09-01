namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Doner_regBLLTests
    {
        private Doner_regBLL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Doner_regBLL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Doner_regBLL();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanCallinsert()
        {
            var objectBLL = new Doner_regBLL();
            _testClass.insert(objectBLL);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallinsertWithNullObjectBLL()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.insert(default(Doner_regBLL)));
        }

        [Test]
        public void CanSetAndGetSelect_organization()
        {
            var testValue = "TestValue737920146";
            _testClass.Select_organization = testValue;
            Assert.That(_testClass.Select_organization, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetD_id()
        {
            var testValue = "TestValue1462700883";
            _testClass.D_id = testValue;
            Assert.That(_testClass.D_id, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetD_user_name()
        {
            var testValue = "TestValue835172908";
            _testClass.D_user_name = testValue;
            Assert.That(_testClass.D_user_name, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetGender()
        {
            var testValue = "TestValue1683145567";
            _testClass.Gender = testValue;
            Assert.That(_testClass.Gender, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetWeight()
        {
            var testValue = "TestValue1011206971";
            _testClass.Weight = testValue;
            Assert.That(_testClass.Weight, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetDob()
        {
            var testValue = "TestValue1493028576";
            _testClass.Dob = testValue;
            Assert.That(_testClass.Dob, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetBlood_group()
        {
            var testValue = "TestValue275129301";
            _testClass.Blood_group = testValue;
            Assert.That(_testClass.Blood_group, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetEmail()
        {
            var testValue = "TestValue1591565584";
            _testClass.Email = testValue;
            Assert.That(_testClass.Email, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetCountry()
        {
            var testValue = "TestValue1132328616";
            _testClass.Country = testValue;
            Assert.That(_testClass.Country, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetState()
        {
            var testValue = "TestValue1289798358";
            _testClass.State = testValue;
            Assert.That(_testClass.State, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetCity()
        {
            var testValue = "TestValue1024551906";
            _testClass.City = testValue;
            Assert.That(_testClass.City, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetMo_no()
        {
            var testValue = "TestValue687678384";
            _testClass.Mo_no = testValue;
            Assert.That(_testClass.Mo_no, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetAddress()
        {
            var testValue = "TestValue1297170560";
            _testClass.Address = testValue;
            Assert.That(_testClass.Address, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetD_user_id()
        {
            var testValue = "TestValue651857863";
            _testClass.D_user_id = testValue;
            Assert.That(_testClass.D_user_id, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetD_password()
        {
            var testValue = "TestValue2107191567";
            _testClass.D_password = testValue;
            Assert.That(_testClass.D_password, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetHint_que()
        {
            var testValue = "TestValue1874531001";
            _testClass.Hint_que = testValue;
            Assert.That(_testClass.Hint_que, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetHint_ans()
        {
            var testValue = "TestValue1473244632";
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