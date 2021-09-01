namespace Models.Tests
{
    using Models;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class InvalidRentExceptionTests
    {
        private InvalidRentException _testClass;
        private string _message;

        [SetUp]
        public void SetUp()
        {
            _message = "TestValue446877013";
            _testClass = new InvalidRentException(_message);
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new InvalidRentException();
            Assert.IsNotNull(instance);
            instance = new InvalidRentException(_message);
            Assert.IsNotNull(instance);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void CannotConstructWithInvalidMessage(string value)
        {
            Assert.Throws<ArgumentNullException>(() => new InvalidRentException(value));
        }
    }
}