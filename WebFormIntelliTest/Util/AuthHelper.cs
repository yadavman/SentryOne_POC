using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormIntelliTest.Util
{

    public class ApplicationUser
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string AvatarUrl { get; set; }
    }

    public class AuthHelper
    {
        public bool SignIn(string userName, string password)
        {
            HttpContext.Current.Session["User"] = CreateDefualtUser();  // Mock user data
            return true;
        }
        public void SignOut()
        {
            HttpContext.Current.Session["User"] = null;
        }
        public bool IsAuthenticated()
        {
            return GetLoggedInUserInfo() != null;
        }

        public ApplicationUser GetLoggedInUserInfo()
        {
            return HttpContext.Current.Session["User"] as ApplicationUser;
        }
        private static ApplicationUser CreateDefualtUser()
        {
            return new ApplicationUser
            {
                UserName = "JBell",
                FirstName = "Julia",
                LastName = "Bell",
                Email = "julia.bell@example.com",
                AvatarUrl = "~/Content/Photo/Julia_Bell.jpg"
            };
        }
    }
}