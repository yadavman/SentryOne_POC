using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Ad_cityDLL
/// </summary>
namespace WebFormIntelliTest
{
    public class Ad_cityDLL
    {
        SqlConnection con = new SqlConnection("Data Source=.\\mssqlserver;Initial Catalog=Blood_Donation_Mgmt;Integrated Security=True");
        public Ad_cityDLL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public void insert(Add_cityBLL objectBLL)
        {
            try
            {
                int var = 0;
                SqlCommand cmd = new SqlCommand("insert_city", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@country", objectBLL.Country);
                cmd.Parameters.AddWithValue("@state", objectBLL.State);
                cmd.Parameters.AddWithValue("@city_name", objectBLL.City_name);


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