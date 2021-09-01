using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for Add_stateBLL
/// </summary>
namespace WebFormIntelliTest
{
    public class Add_stateBLL
    {
        public Add_stateBLL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        private string state_name;

        public string State_name
        {
            get { return state_name; }
            set { state_name = value; }
        }
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        Add_stateDLL objectDLL = new Add_stateDLL();
        public void insert(Add_stateBLL objectBLL)
        {
            objectDLL.insert(objectBLL);
        }
    } 
}