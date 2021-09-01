namespace WebFormIntelliTest.Tests
{
    using WebFormIntelliTest;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class OrganizationDLLTests
    {
        private OrganizationDLL _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new OrganizationDLL();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new OrganizationDLL();
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
        public void CanCallUpdate()
        {
            var objectBLL = new OrganizationBLL();
            _testClass.Update(objectBLL);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallUpdateWithNullObjectBLL()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.Update(default(OrganizationBLL)));
        }

        [Test]
        public void CanCallDelete()
        {
            var objectBLL = new OrganizationBLL();
            _testClass.Delete(objectBLL);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallDeleteWithNullObjectBLL()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.Delete(default(OrganizationBLL)));
        }
    }
}