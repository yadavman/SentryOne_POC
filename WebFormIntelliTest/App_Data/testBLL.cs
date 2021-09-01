using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for testBLL
/// </summary>
namespace WebFormIntelliTest
{
    public class testBLL
    {
        public testBLL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        private string name;

        public string Name1
        {
            get { return name; }
            set { name = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        testDLL objectDLL = new testDLL();
        public void insert(testBLL objectBLL)
        {
            objectDLL.insert(objectBLL);
        }
    } 
}