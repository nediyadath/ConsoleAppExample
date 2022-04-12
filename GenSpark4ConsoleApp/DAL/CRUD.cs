using GenSpark4ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenSpark4ConsoleApp.DAL
{
   public class CRUD
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString());
        public DataTable FetchPatients()
        {
            SqlDataAdapter db = new SqlDataAdapter("select * from patients", con);
            DataTable dt = new DataTable();
            db.Fill(dt);
            return dt;
        }
    }
}
