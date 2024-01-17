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
            string con = @"Data Source=LAPTOP-SDGJ5NAJ;Initial Catalog=database2;Integrated Security=True;Pooling=False";
            return con;
        }
        /*public string getEventInfo(string eventName, string fromdate, string todate,string desscription)
        {
            string getquery = "SELECT * FROM Events WHERE "
        }*/
        public void getEvents(string eventName,string eventInfo,string image,string date)
        {

        }
    }
}
