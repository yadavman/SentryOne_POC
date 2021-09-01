using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Seeker_regDLL
/// </summary>
namespace WebFormIntelliTest
{
    public class Seeker_regDLL
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Blood_Donation_Mgmt;Integrated Security=True");
        public Seeker_regDLL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public void insert(Seeker_regBLL objectBLL)
        {
            try
            {
                int var = 0;
                SqlCommand cmd = new SqlCommand("insert_seeker", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@s_user_name", objectBLL.S_user_name);
                cmd.Parameters.AddWithValue("@gender", objectBLL.Gender);
                cmd.Parameters.AddWithValue("@weight", objectBLL.Weight);
                cmd.Parameters.AddWithValue("@dob", objectBLL.Dob);
                cmd.Parameters.AddWithValue("@blood_group", objectBLL.Blood_group);
                cmd.Parameters.AddWithValue("@email", objectBLL.Email);
                cmd.Parameters.AddWithValue("@country", objectBLL.Country);
                cmd.Parameters.AddWithValue("@state", objectBLL.State);
                cmd.Parameters.AddWithValue("@city", objectBLL.City);
                cmd.Parameters.AddWithValue("@mo_no", objectBLL.Mo_no);
                cmd.Parameters.AddWithValue("@address", objectBLL.Address);
                cmd.Parameters.AddWithValue("@s_user_id", objectBLL.S_user_id);
                cmd.Parameters.AddWithValue("@s_password", objectBLL.S_password);
                cmd.Parameters.AddWithValue("@hint_que", objectBLL.Hint_que);
                cmd.Parameters.AddWithValue("@hint_ans", objectBLL.Hint_ans);


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