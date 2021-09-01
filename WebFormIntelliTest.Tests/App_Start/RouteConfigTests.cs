//namespace WebFormIntelliTest.Tests
//{
//    using WebFormIntelliTest;
//    using System;
//    using NUnit.Framework;
//    using System.Web.Routing;

//    [TestFixture]
//    public static class RouteConfigTests
//    {
//        [Test]
//        public static void CanCallRegisterRoutes()
//        {
//            var routes = new RouteCollection();
//            RouteConfig.RegisterRoutes(routes);
//            Assert.Fail("Create or modify test");
//        }

//        [Test]
//        public static void CannotCallRegisterRoutesWithNullRoutes()
//        {
//            Assert.Throws<ArgumentNullException>(() => RouteConfig.RegisterRoutes(default(RouteCollection)));
//        }
//    }
//}