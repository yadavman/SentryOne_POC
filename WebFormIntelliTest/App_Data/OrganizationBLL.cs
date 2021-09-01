using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Organization
/// </summary>
namespace WebFormIntelliTest
{
    public class OrganizationBLL
    {
        public OrganizationBLL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        private String org_name;

        public String Org_name
        {
            get { return org_name; }
            set { org_name = value; }
        }
        private String org_type;

        public String Org_type
        {
            get { return org_type; }
            set { org_type = value; }
        }
        private String eid;

        public String Eid
        {
            get { return eid; }
            set { eid = value; }
        }
        private String country;

        public String Country
        {
            get { return country; }
            set { country = value; }
        }
        private String state;

        public String State
        {
            get { return state; }
            set { state = value; }
        }
        private String city;

        public String City
        {
            get { return city; }
            set { city = value; }
        }
        private String phone_no;

        public String Phone_no
        {
            get { return phone_no; }
            set { phone_no = value; }
        }
        private String mobile_no;

        public String Mobile_no
        {
            get { return mobile_no; }
            set { mobile_no = value; }
        }
        private String address;

        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        private String user_name;

        public String User_name
        {
            get { return user_name; }
            set { user_name = value; }
        }
        private String password;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        private String hint_que;

        public String Hint_que
        {
            get { return hint_que; }
            set { hint_que = value; }
        }
        private String hint_ans;

        public String Hint_ans
        {
            get { return hint_ans; }
            set { hint_ans = value; }
        }
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        OrganizationDLL objectDLL = new OrganizationDLL();
        public void insert(OrganizationBLL objectBLL)
        {
            objectDLL.insert(objectBLL);
        }


    }


}