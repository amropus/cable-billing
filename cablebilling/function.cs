using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace cablebilling
{
    class function
    {
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        SqlDataReader dr;
        // SqlConnection con;


        SqlConnection con = new SqlConnection(@"Data Source=RONAK-PC\SQLEXPRESS1;Initial Catalog=cabledb;Integrated Security=True");

        public int executedml(string str)
        {
            try
            {
                con.Close();
                int row = 0;
                cmd = new SqlCommand(str, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return row;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public DataTable filldatatable(string str)
        {
            try
            {
                con.Close(); 
                dt = new DataTable();
                da = new SqlDataAdapter(str, con);
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public SqlDataReader reader(string str)
       {

           try 
       { 
           con.Close();
           cmd = new SqlCommand(str, con);
           con.Open();
           dr = cmd.ExecuteReader();
           return dr;
       } 
       
          catch (Exception)
           {
               throw;
           }
        
        
        }
    }
}
