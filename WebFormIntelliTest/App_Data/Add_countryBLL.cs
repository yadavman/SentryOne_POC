using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Add_countryBLL
/// </summary>
namespace WebFormIntelliTest
{
    public class Add_countryBLL
    {
        public Add_countryBLL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        private string country_name;

        public string Country_name
        {
            get { return country_name; }
            set { country_name = value; }
        }
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        Add_countryDLL objectDLL = new Add_countryDLL();
        public void insert(Add_countryBLL objectBLL)
        {
            //  objectDLL.insert(objectBLL);
            objectDLL.insert(objectBLL);
        }
    } 
}