using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Seeker_request_for_bloodBLL
/// </summary>
namespace WebFormIntelliTest
{
    public class Seeker_request_for_bloodBLL
    {
        public Seeker_request_for_bloodBLL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        private string s_name;

        public string S_name
        {
            get { return s_name; }
            set { s_name = value; }
        }
        private string s_id;

        public string S_id
        {
            get { return s_id; }
            set { s_id = value; }
        }
        private string mo_no;

        public string Mo_no
        {
            get { return mo_no; }
            set { mo_no = value; }
        }
        private string org_name;

        public string Org_name
        {
            get { return org_name; }
            set { org_name = value; }
        }
        private string blood_group;

        public string Blood_group
        {
            get { return blood_group; }
            set { blood_group = value; }
        }
        private string blood_quantity;

        public string Blood_quantity
        {
            get { return blood_quantity; }
            set { blood_quantity = value; }
        }
        private string request;

        public string Request
        {
            get { return request; }
            set { request = value; }
        }
        private string remark;

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }


        Seeker_request_for_bloodDLL objectDLL = new Seeker_request_for_bloodDLL();
        public void insert(Seeker_request_for_bloodBLL objectBLL)
        {
            objectDLL.insert(objectBLL);
        }
    } 
}