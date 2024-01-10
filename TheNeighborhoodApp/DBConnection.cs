using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TheNeighborhoodApp
{
    public class DBConnection
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        SqlDataReader dr;
        public string MyConnection()
        {
            string con = @"Data Source=DESKTOP-09ORH5O\MSSQLSERVER01;Initial Catalog=neighborhoodDB;Integrated Security=True;Pooling=False";
            return con;
        }

    }
}
