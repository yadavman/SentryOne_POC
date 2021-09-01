using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Add_donation_detailsBLL
/// </summary>
namespace WebFormIntelliTest
{
    public class Add_donation_detailsBLL
    {
        public Add_donation_detailsBLL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #region Properties
        private string select_org;

        public string Select_org
        {
            get { return select_org; }
            set { select_org = value; }
        }
        private string d_id;

        public string D_id
        {
            get { return d_id; }
            set { d_id = value; }
        }
        private string d_name;

        public string D_name
        {
            get { return d_name; }
            set { d_name = value; }
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
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        #endregion

        Add_donation_detailsDLL objectDLL = new Add_donation_detailsDLL();
        public void insert(Add_donation_detailsBLL objectBLL)
        {
            objectDLL.insert(objectBLL);
        }

    } 
}