using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using WebFormIntelliTest;


/// <summary>
/// Summary description for Add_stateDLL
/// </summary>
public class Add_stateDLL
{
    SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Blood_Donation_Mgmt;Integrated Security=True");
	public Add_stateDLL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public void insert(Add_stateBLL objectBLL)
    {
        try
        {
            int var = 0;
            SqlCommand cmd = new SqlCommand("add_state", con);
             
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@country", objectBLL.Country);
            cmd.Parameters.AddWithValue("@state_name", objectBLL.State_name);
         


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