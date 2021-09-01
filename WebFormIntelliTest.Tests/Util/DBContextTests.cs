//namespace WebFormIntelliTest.Tests.Util
//{
//    using WebFormIntelliTest.Util;
//    using System;
//    using NUnit.Framework;
//    using System.Collections.Generic;
//    using System.Drawing;

//    [TestFixture]
//    public class IssueTests
//    {
//        private Issue _testClass;

//        [SetUp]
//        public void SetUp()
//        {
//            _testClass = new Issue();
//        }

//        [Test]
//        public void CanConstruct()
//        {
//            var instance = new Issue();
//            Assert.IsNotNull(instance);
//        }

//        [Test]
//        public void CanCallSetCustomer()
//        {
//            var value = new Contact { Id = 1400247462L, FirstName = "TestValue601751970", LastName = "TestValue1646516075", AddressBook = "TestValue1564675083", Email = "TestValue717177816", PhotoFileName = "TestValue1143485194", Country = "TestValue1237285060", City = "TestValue1896907343", Address = "TestValue1562096307", Phone = "TestValue1592605603", Birthday = new DateTime(453114338) };
//            _testClass.SetCustomer(value);
//            Assert.Fail("Create or modify test");
//        }

//        [Test]
//        public void CannotCallSetCustomerWithNullValue()
//        {
//            Assert.Throws<ArgumentNullException>(() => _testClass.SetCustomer(default(Contact)));
//        }

//        [Test]
//        public void CanCallAssign()
//        {
//            var src = new Issue();
//            _testClass.Assign(src);
//            Assert.Fail("Create or modify test");
//        }

//        [Test]
//        public void CannotCallAssignWithNullSrc()
//        {
//            Assert.Throws<ArgumentNullException>(() => _testClass.Assign(default(Issue)));
//        }

//        [Test]
//        public void CanSetAndGetId()
//        {
//            var testValue = 1129229933L;
//            _testClass.Id = testValue;
//            Assert.That(_testClass.Id, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetSubject()
//        {
//            var testValue = "TestValue451513155";
//            _testClass.Subject = testValue;
//            Assert.That(_testClass.Subject, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanGetCustomer()
//        {
//            Assert.That(_testClass.Customer, Is.InstanceOf<Contact>());
//            Assert.Fail("Create or modify test");
//        }

//        [Test]
//        public void CanSetAndGetCustomerId()
//        {
//            var testValue = 798881374L;
//            _testClass.CustomerId = testValue;
//            Assert.That(_testClass.CustomerId, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetCreated()
//        {
//            var testValue = new DateTime(210183132);
//            _testClass.Created = testValue;
//            Assert.That(_testClass.Created, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetUpdated()
//        {
//            var testValue = new DateTime(549387712);
//            _testClass.Updated = testValue;
//            Assert.That(_testClass.Updated, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetNotes()
//        {
//            var testValue = "TestValue282066110";
//            _testClass.Notes = testValue;
//            Assert.That(_testClass.Notes, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetUnread()
//        {
//            var testValue = true;
//            _testClass.Unread = testValue;
//            Assert.That(_testClass.Unread, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetIsDraft()
//        {
//            var testValue = true;
//            _testClass.IsDraft = testValue;
//            Assert.That(_testClass.IsDraft, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetIsArchived()
//        {
//            var testValue = false;
//            _testClass.IsArchived = testValue;
//            Assert.That(_testClass.IsArchived, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetKind()
//        {
//            var testValue = 356922917;
//            _testClass.Kind = testValue;
//            Assert.That(_testClass.Kind, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetPriority()
//        {
//            var testValue = 1715818344;
//            _testClass.Priority = testValue;
//            Assert.That(_testClass.Priority, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetStatus()
//        {
//            var testValue = 1293590084;
//            _testClass.Status = testValue;
//            Assert.That(_testClass.Status, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetVotes()
//        {
//            var testValue = 1042410685;
//            _testClass.Votes = testValue;
//            Assert.That(_testClass.Votes, Is.EqualTo(testValue));
//        }
//    }

//    [TestFixture]
//    public class ContactTests
//    {
//        private Contact _testClass;

//        [SetUp]
//        public void SetUp()
//        {
//            _testClass = new Contact();
//        }

//        [Test]
//        public void CanConstruct()
//        {
//            var instance = new Contact();
//            Assert.IsNotNull(instance);
//        }

//        [Test]
//        public void CanSetAndGetId()
//        {
//            var testValue = 922383077L;
//            _testClass.Id = testValue;
//            Assert.That(_testClass.Id, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetFirstName()
//        {
//            var testValue = "TestValue286782079";
//            _testClass.FirstName = testValue;
//            Assert.That(_testClass.FirstName, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetLastName()
//        {
//            var testValue = "TestValue76571099";
//            _testClass.LastName = testValue;
//            Assert.That(_testClass.LastName, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanGetFullName()
//        {
//            Assert.That(_testClass.FullName, Is.InstanceOf<string>());
//            Assert.Fail("Create or modify test");
//        }

//        [Test]
//        public void CanSetAndGetAddressBook()
//        {
//            var testValue = "TestValue1902058087";
//            _testClass.AddressBook = testValue;
//            Assert.That(_testClass.AddressBook, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetEmail()
//        {
//            var testValue = "TestValue2096119485";
//            _testClass.Email = testValue;
//            Assert.That(_testClass.Email, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetPhotoFileName()
//        {
//            var testValue = "TestValue1724008475";
//            _testClass.PhotoFileName = testValue;
//            Assert.That(_testClass.PhotoFileName, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanGetPhotoUrl()
//        {
//            Assert.That(_testClass.PhotoUrl, Is.InstanceOf<string>());
//            Assert.Fail("Create or modify test");
//        }

//        [Test]
//        public void CanSetAndGetCountry()
//        {
//            var testValue = "TestValue2016145032";
//            _testClass.Country = testValue;
//            Assert.That(_testClass.Country, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetCity()
//        {
//            var testValue = "TestValue1926786315";
//            _testClass.City = testValue;
//            Assert.That(_testClass.City, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetAddress()
//        {
//            var testValue = "TestValue1637798017";
//            _testClass.Address = testValue;
//            Assert.That(_testClass.Address, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetPhone()
//        {
//            var testValue = "TestValue403671416";
//            _testClass.Phone = testValue;
//            Assert.That(_testClass.Phone, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetBirthday()
//        {
//            var testValue = new DateTime(1787530550);
//            _testClass.Birthday = testValue;
//            Assert.That(_testClass.Birthday, Is.EqualTo(testValue));
//        }
//    }

//    [TestFixture]
//    public class DataProviderTests
//    {
//        private DataProvider _testClass;

//        [SetUp]
//        public void SetUp()
//        {
//            _testClass = new DataProvider();
//        }

//        [Test]
//        public void CanConstruct()
//        {
//            var instance = new DataProvider();
//            Assert.IsNotNull(instance);
//        }

//        [Test]
//        public void CanCallGetContacts()
//        {
//            var result = _testClass.GetContacts();
//            Assert.Fail("Create or modify test");
//        }

//        [Test]
//        public void CanCallGetIssues()
//        {
//            var result = _testClass.GetIssues();
//            Assert.Fail("Create or modify test");
//        }

//        [Test]
//        public void CanCallAddNewIssue()
//        {
//            var issue = new Issue();
//            _testClass.AddNewIssue(issue);
//            Assert.Fail("Create or modify test");
//        }

//        [Test]
//        public void CannotCallAddNewIssueWithNullIssue()
//        {
//            Assert.Throws<ArgumentNullException>(() => _testClass.AddNewIssue(default(Issue)));
//        }

//        [Test]
//        public void CanCallUpdateIssue()
//        {
//            var issue = new Issue();
//            _testClass.UpdateIssue(issue);
//            Assert.Fail("Create or modify test");
//        }

//        [Test]
//        public void CannotCallUpdateIssueWithNullIssue()
//        {
//            Assert.Throws<ArgumentNullException>(() => _testClass.UpdateIssue(default(Issue)));
//        }

//        [Test]
//        public void CanCallDeleteIssues()
//        {
//            var ids = new List<long>();
//            _testClass.DeleteIssues(ids);
//            Assert.Fail("Create or modify test");
//        }

//        [Test]
//        public void CannotCallDeleteIssuesWithNullIds()
//        {
//            Assert.Throws<ArgumentNullException>(() => _testClass.DeleteIssues(default(List<long>)));
//        }
//    }

//    [TestFixture]
//    public class SchedulerLabelTests
//    {
//        private SchedulerLabel _testClass;

//        [SetUp]
//        public void SetUp()
//        {
//            _testClass = new SchedulerLabel();
//        }

//        [Test]
//        public void CanConstruct()
//        {
//            var instance = new SchedulerLabel();
//            Assert.IsNotNull(instance);
//        }

//        [Test]
//        public void CanSetAndGetId()
//        {
//            var testValue = 1347420864L;
//            _testClass.Id = testValue;
//            Assert.That(_testClass.Id, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetName()
//        {
//            var testValue = "TestValue351627294";
//            _testClass.Name = testValue;
//            Assert.That(_testClass.Name, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetColor()
//        {
//            var testValue = Color.Cyan;
//            _testClass.Color = testValue;
//            Assert.That(_testClass.Color, Is.EqualTo(testValue));
//        }
//    }

//    [TestFixture]
//    public class SchedulerAppointmentTests
//    {
//        private SchedulerAppointment _testClass;

//        [SetUp]
//        public void SetUp()
//        {
//            _testClass = new SchedulerAppointment();
//        }

//        [Test]
//        public void CanConstruct()
//        {
//            var instance = new SchedulerAppointment();
//            Assert.IsNotNull(instance);
//        }

//        [Test]
//        public void CanSetAndGetId()
//        {
//            var testValue = 323437655L;
//            _testClass.Id = testValue;
//            Assert.That(_testClass.Id, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetSubject()
//        {
//            var testValue = "TestValue1412078543";
//            _testClass.Subject = testValue;
//            Assert.That(_testClass.Subject, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetLocation()
//        {
//            var testValue = "TestValue1325130255";
//            _testClass.Location = testValue;
//            Assert.That(_testClass.Location, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetStartDate()
//        {
//            var testValue = new DateTime(1149645669);
//            _testClass.StartDate = testValue;
//            Assert.That(_testClass.StartDate, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetEndDate()
//        {
//            var testValue = new DateTime(1307431672);
//            _testClass.EndDate = testValue;
//            Assert.That(_testClass.EndDate, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetAllDay()
//        {
//            var testValue = false;
//            _testClass.AllDay = testValue;
//            Assert.That(_testClass.AllDay, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetDescription()
//        {
//            var testValue = "TestValue2034547656";
//            _testClass.Description = testValue;
//            Assert.That(_testClass.Description, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetRecurrenceInfo()
//        {
//            var testValue = "TestValue492316255";
//            _testClass.RecurrenceInfo = testValue;
//            Assert.That(_testClass.RecurrenceInfo, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetEventType()
//        {
//            var testValue = 1381235787;
//            _testClass.EventType = testValue;
//            Assert.That(_testClass.EventType, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetLabelId()
//        {
//            var testValue = 1585866416L;
//            _testClass.LabelId = testValue;
//            Assert.That(_testClass.LabelId, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetStatus()
//        {
//            var testValue = 784896751;
//            _testClass.Status = testValue;
//            Assert.That(_testClass.Status, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetResourceId()
//        {
//            var testValue = 396832617L;
//            _testClass.ResourceId = testValue;
//            Assert.That(_testClass.ResourceId, Is.EqualTo(testValue));
//        }
//    }

//    [TestFixture]
//    public class SchedulerResourceTests
//    {
//        private SchedulerResource _testClass;

//        [SetUp]
//        public void SetUp()
//        {
//            _testClass = new SchedulerResource();
//        }

//        [Test]
//        public void CanConstruct()
//        {
//            var instance = new SchedulerResource();
//            Assert.IsNotNull(instance);
//        }

//        [Test]
//        public void CanSetAndGetId()
//        {
//            var testValue = 1821564608L;
//            _testClass.Id = testValue;
//            Assert.That(_testClass.Id, Is.EqualTo(testValue));
//        }

//        [Test]
//        public void CanSetAndGetName()
//        {
//            var testValue = "TestValue1100254107";
//            _testClass.Name = testValue;
//            Assert.That(_testClass.Name, Is.EqualTo(testValue));
//        }
//    }

//    [TestFixture]
//    public class SchedulerLabelsHelperTests
//    {
//        private SchedulerLabelsHelper _testClass;

//        [SetUp]
//        public void SetUp()
//        {
//            _testClass = new SchedulerLabelsHelper();
//        }

//        [Test]
//        public void CanCallGetItems()
//        {
//            var result = _testClass.GetItems();
//            Assert.Fail("Create or modify test");
//        }
//    }

//    [TestFixture]
//    public class AppointmentDataSourceHelperTests
//    {
//        private AppointmentDataSourceHelper _testClass;

//        [SetUp]
//        public void SetUp()
//        {
//            _testClass = new AppointmentDataSourceHelper();
//        }

//        [Test]
//        public void CanConstruct()
//        {
//            var instance = new AppointmentDataSourceHelper();
//            Assert.IsNotNull(instance);
//        }

//        [Test]
//        public void CanCallSelectMethodHandler()
//        {
//            var result = _testClass.SelectMethodHandler();
//            Assert.Fail("Create or modify test");
//        }

//        [Test]
//        public void CanCallInsertMethodHandler()
//        {
//            var newAppointment = new SchedulerAppointment { Id = 1103862479L, Subject = "TestValue756659324", Location = "TestValue18298401", StartDate = new DateTime(1831912765), EndDate = new DateTime(1455645533), AllDay = false, Description = "TestValue642292006", RecurrenceInfo = "TestValue430395737", EventType = 1066914095, LabelId = 1482710620L, Status = 1948271505, ResourceId = 1985571479L };
//            var result = _testClass.InsertMethodHandler(newAppointment);
//            Assert.Fail("Create or modify test");
//        }

//        [Test]
//        public void CannotCallInsertMethodHandlerWithNullNewAppointment()
//        {
//            Assert.Throws<ArgumentNullException>(() => _testClass.InsertMethodHandler(default(SchedulerAppointment)));
//        }

//        [Test]
//        public void CanCallDeleteMethodHandler()
//        {
//            var deletedAppointment = new SchedulerAppointment { Id = 1723944218L, Subject = "TestValue673811670", Location = "TestValue1638915563", StartDate = new DateTime(47841739), EndDate = new DateTime(1158834471), AllDay = true, Description = "TestValue197760418", RecurrenceInfo = "TestValue1249693596", EventType = 78141766, LabelId = 1297086519L, Status = 1450204880, ResourceId = 1354760895L };
//            _testClass.DeleteMethodHandler(deletedAppointment);
//            Assert.Fail("Create or modify test");
//        }

//        [Test]
//        public void CannotCallDeleteMethodHandlerWithNullDeletedAppointment()
//        {
//            Assert.Throws<ArgumentNullException>(() => _testClass.DeleteMethodHandler(default(SchedulerAppointment)));
//        }

//        [Test]
//        public void CanCallUpdateMethodHandler()
//        {
//            var updatedAppointment = new SchedulerAppointment { Id = 408386672L, Subject = "TestValue856050016", Location = "TestValue1155346676", StartDate = new DateTime(430066822), EndDate = new DateTime(1053029939), AllDay = false, Description = "TestValue1117161336", RecurrenceInfo = "TestValue1699286868", EventType = 2049927514, LabelId = 915890925L, Status = 822923836, ResourceId = 881138693L };
//            _testClass.UpdateMethodHandler(updatedAppointment);
//            Assert.Fail("Create or modify test");
//        }

//        [Test]
//        public void CannotCallUpdateMethodHandlerWithNullUpdatedAppointment()
//        {
//            Assert.Throws<ArgumentNullException>(() => _testClass.UpdateMethodHandler(default(SchedulerAppointment)));
//        }
//    }

//    [TestFixture]
//    public class ResourceDataSourceHelperTests
//    {
//        private ResourceDataSourceHelper _testClass;

//        [SetUp]
//        public void SetUp()
//        {
//            _testClass = new ResourceDataSourceHelper();
//        }

//        [Test]
//        public void CanCallGetItemsWithNoParameters()
//        {
//            var result = _testClass.GetItems();
//            Assert.Fail("Create or modify test");
//        }

//        [Test]
//        public void CanCallGetItemsWithIds()
//        {
//            var ids = new List<long>();
//            var result = _testClass.GetItems(ids);
//            Assert.Fail("Create or modify test");
//        }

//        [Test]
//        public void CannotCallGetItemsWithIdsWithNullIds()
//        {
//            Assert.Throws<ArgumentNullException>(() => _testClass.GetItems(default(List<long>)));
//        }

//        [Test]
//        public void GetItemsWithIdsPerformsMapping()
//        {
//            var ids = new List<long>();
//            var result = _testClass.GetItems(ids);
//            Assert.That(result.Capacity, Is.EqualTo(ids.Capacity));
//            Assert.That(result.Count, Is.EqualTo(ids.Count));
//            //Assert.That(result.System.Collections.IList.IsFixedSize, Is.EqualTo(ids.System.Collections.IList.IsFixedSize));
//            //Assert.That(result.System.Collections.Generic.ICollection<T>.IsReadOnly, Is.EqualTo(ids.System.Collections.Generic.ICollection<T>.IsReadOnly));
//            //Assert.That(result.System.Collections.IList.IsReadOnly, Is.EqualTo(ids.System.Collections.IList.IsReadOnly));
//            //Assert.That(result.System.Collections.ICollection.IsSynchronized, Is.EqualTo(ids.System.Collections.ICollection.IsSynchronized));
//            //Assert.That(result.System.Collections.ICollection.SyncRoot, Is.EqualTo(ids.System.Collections.ICollection.SyncRoot));
//            //Assert.That(result.System.Collections.IList.Item, Is.EqualTo(ids.System.Collections.IList.Item));
//        }
//    }
//}