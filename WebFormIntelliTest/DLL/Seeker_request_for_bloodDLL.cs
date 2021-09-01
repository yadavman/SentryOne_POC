using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Seeker_request_for_bloodDLL
/// </summary>
namespace WebFormIntelliTest
{
    public class Seeker_request_for_bloodDLL
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Blood_Donation_Mgmt;Integrated Security=True");

        public Seeker_request_for_bloodDLL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public void insert(Seeker_request_for_bloodBLL objectBLL)
        {
            try
            {
                int var = 0;
                SqlCommand cmd = new SqlCommand("s_request_for_blood", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@s_name", objectBLL.S_name);
                cmd.Parameters.AddWithValue("@s_id", objectBLL.S_id);
                cmd.Parameters.AddWithValue("@mo_no", objectBLL.Mo_no);
                cmd.Parameters.AddWithValue("@org_name", objectBLL.Org_name);
                cmd.Parameters.AddWithValue("@blood_group", objectBLL.Blood_group);
                cmd.Parameters.AddWithValue("@blood_quantity", objectBLL.Blood_quantity);
                cmd.Parameters.AddWithValue("@request", objectBLL.Request);
                //  cmd.Parameters.AddWithValue("@remark", objectBLL.Remark);



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