namespace WebFormIntelliTest.Tests.Util
{
    using WebFormIntelliTest.Util;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ApplicationUserTests
    {
        private ApplicationUser _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new ApplicationUser();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new ApplicationUser();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanSetAndGetUserName()
        {
            var testValue = "TestValue1832748942";
            _testClass.UserName = testValue;
            Assert.That(_testClass.UserName, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetFirstName()
        {
            var testValue = "TestValue237264143";
            _testClass.FirstName = testValue;
            Assert.That(_testClass.FirstName, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetLastName()
        {
            var testValue = "TestValue995079883";
            _testClass.LastName = testValue;
            Assert.That(_testClass.LastName, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetEmail()
        {
            var testValue = "TestValue946220329";
            _testClass.Email = testValue;
            Assert.That(_testClass.Email, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetAvatarUrl()
        {
            var testValue = "TestValue2103630718";
            _testClass.AvatarUrl = testValue;
            Assert.That(_testClass.AvatarUrl, Is.EqualTo(testValue));
        }
    }

    [TestFixture]
    public class AuthHelperTests
    {
        private AuthHelper _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new AuthHelper();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new AuthHelper();
            Assert.IsNotNull(instance);
        }

        [Test]
        public void CanCallSignIn()
        {
            var userName = "TestValue1501833528";
            var password = "TestValue1665543894";
            var result = _testClass.SignIn(userName, password);
            Assert.Fail("Create or modify test");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void CannotCallSignInWithInvalidUserName(string value)
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.SignIn(value, "TestValue1384510812"));
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void CannotCallSignInWithInvalidPassword(string value)
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.SignIn("TestValue375221318", value));
        }

        [Test]
        public void CanCallSignOut()
        {
            _testClass.SignOut();
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanCallIsAuthenticated()
        {
            var result = _testClass.IsAuthenticated();
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanCallGetLoggedInUserInfo()
        {
            var result = _testClass.GetLoggedInUserInfo();
            Assert.Fail("Create or modify test");
        }
    }
}