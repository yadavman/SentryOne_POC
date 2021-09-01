using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Add_countryDLL
/// </summary>
namespace WebFormIntelliTest
{
    public class Add_countryDLL
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Blood_Donation_Mgmt;Integrated Security=True");
        public Add_countryDLL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public void insert(Add_countryBLL objectBLL)
        {
            try
            {
                int var = 0;
                SqlCommand cmd = new SqlCommand("add_country", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@country_name", objectBLL.Country_name);


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