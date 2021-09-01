namespace Models.Tests
{
    using Models;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class InvalidLocationExceptionTests
    {
        private InvalidLocationException _testClass;
        private string _message;

        [SetUp]
        public void SetUp()
        {
            _message = "TestValue1148934671";
            _testClass = new InvalidLocationException(_message);
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new InvalidLocationException();
            Assert.IsNotNull(instance);
            instance = new InvalidLocationException(_message);
            Assert.IsNotNull(instance);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void CannotConstructWithInvalidMessage(string value)
        {
            Assert.Throws<ArgumentNullException>(() => new InvalidLocationException(value));
        }
    }
}