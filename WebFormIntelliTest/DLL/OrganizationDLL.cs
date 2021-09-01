using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for OrganizationDLL
/// </summary>
namespace WebFormIntelliTest
{
    public class OrganizationDLL
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Blood_Donation_Mgmt;Integrated Security=True");
        public OrganizationDLL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public void insert(OrganizationBLL objectBLL)
        {
            try
            {
                int var = 0;
                SqlCommand cmd = new SqlCommand("insert_org", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@org_name", objectBLL.Org_name);
                cmd.Parameters.AddWithValue("@org_type", objectBLL.Org_type);
                cmd.Parameters.AddWithValue("@eid", objectBLL.Eid);
                cmd.Parameters.AddWithValue("@country", objectBLL.Country);
                cmd.Parameters.AddWithValue("@state", objectBLL.State);
                cmd.Parameters.AddWithValue("@city", objectBLL.City);
                cmd.Parameters.AddWithValue("@phone_no", objectBLL.Phone_no);
                cmd.Parameters.AddWithValue("@mobile_no", objectBLL.Mobile_no);
                cmd.Parameters.AddWithValue("@address", objectBLL.Address);
                cmd.Parameters.AddWithValue("@user_name", objectBLL.User_name);
                cmd.Parameters.AddWithValue("@password", objectBLL.Password);
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


        public void Update(OrganizationBLL objectBLL)
        {
            try
            {
                int var = 0;
                SqlCommand cmd = new SqlCommand("update_org", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@org_name", objectBLL.Org_name);
                cmd.Parameters.AddWithValue("@org_type", objectBLL.Org_type);
                cmd.Parameters.AddWithValue("@eid", objectBLL.Eid);
                cmd.Parameters.AddWithValue("@country", objectBLL.Country);
                cmd.Parameters.AddWithValue("@state", objectBLL.State);
                cmd.Parameters.AddWithValue("@city", objectBLL.City);
                cmd.Parameters.AddWithValue("@phone_no", objectBLL.Phone_no);
                cmd.Parameters.AddWithValue("@mobile_no", objectBLL.Mobile_no);
                cmd.Parameters.AddWithValue("@address", objectBLL.Address);
                cmd.Parameters.AddWithValue("@user_name", objectBLL.User_name);
                cmd.Parameters.AddWithValue("@password", objectBLL.Password);
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

        public void Delete(OrganizationBLL objectBLL)
        {
            try
            {
                int var = 0;
                SqlCommand cmd = new SqlCommand("delete_org", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid", objectBLL.Eid);

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