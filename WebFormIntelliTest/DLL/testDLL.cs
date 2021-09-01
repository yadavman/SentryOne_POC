using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for testDLL
/// </summary>
namespace WebFormIntelliTest
{
    public class testDLL
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Blood_Donation_Mgmt;Integrated Security=True");
        public testDLL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public void insert(testBLL objectBLL)
        {
            try
            {
                int var = 0;
                SqlCommand cmd = new SqlCommand("insert_nm", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", objectBLL.Name);



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