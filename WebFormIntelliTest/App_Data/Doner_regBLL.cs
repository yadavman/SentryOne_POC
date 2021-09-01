using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Doner_regBLL
/// </summary>
namespace WebFormIntelliTest
{
    public class Doner_regBLL
    {
        public Doner_regBLL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        private string select_organization;

        public string Select_organization
        {
            get { return select_organization; }
            set { select_organization = value; }
        }
        private string d_id;

        public string D_id
        {
            get { return d_id; }
            set { d_id = value; }
        }
        private string d_user_name;

        public string D_user_name
        {
            get { return d_user_name; }
            set { d_user_name = value; }
        }


        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private string weight;

        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private string dob;

        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        private string blood_group;

        public string Blood_group
        {
            get { return blood_group; }
            set { blood_group = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string mo_no;

        public string Mo_no
        {
            get { return mo_no; }
            set { mo_no = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string d_user_id;

        public string D_user_id
        {
            get { return d_user_id; }
            set { d_user_id = value; }
        }
        private string d_password;

        public string D_password
        {
            get { return d_password; }
            set { d_password = value; }
        }
        private string hint_que;

        public string Hint_que
        {
            get { return hint_que; }
            set { hint_que = value; }
        }
        private string hint_ans;

        public string Hint_ans
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
        Doner_regDLL objectDLL = new Doner_regDLL();
        public void insert(Doner_regBLL objectBLL)
        {
            objectDLL.insert(objectBLL);
        }

    } 
}