using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Add_donation_detailsDLL
/// </summary>
namespace WebFormIntelliTest
{
    public class Add_donation_detailsDLL
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Blood_Donation_Mgmt;Integrated Security=True");
        public Add_donation_detailsDLL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public void insert(Add_donation_detailsBLL objectBLL)
        {
            try
            {
                int var = 0;
                SqlCommand cmd = new SqlCommand("insert_donation_details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@select_org", objectBLL.Select_org);
                cmd.Parameters.AddWithValue("@d_id", objectBLL.D_id);
                cmd.Parameters.AddWithValue("@d_name", objectBLL.D_name);
                cmd.Parameters.AddWithValue("@blood_group", objectBLL.Blood_group);
                cmd.Parameters.AddWithValue("@blood_quantity", objectBLL.Blood_quantity);

                con.Open();

                var = cmd.ExecuteNonQuery();
                if (var > 0)
                    objectBLL.Status = true;

            }
            catch (Exception ex)
            {
                String msg = ex.Message;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    } 
}