using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Add_cityBLL
/// </summary>
namespace WebFormIntelliTest
{
    public class Add_cityBLL
    {
        public Add_cityBLL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        private string city_name;

        public string City_name
        {
            get { return city_name; }
            set { city_name = value; }
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

        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        Ad_cityDLL objectDLL = new Ad_cityDLL();
        // Add_cityDLL objectDLL = new Add_cityDLL();
        public void insert(Add_cityBLL objectBLL)
        {
            objectDLL.insert(objectBLL);
        }
    } 
}