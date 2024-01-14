using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNeighborhoodApp
{
    public partial class UserControlDays : UserControl
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        SqlDataReader dr;
        DBConnection db = new DBConnection();
       
        public UserControlDays()
        {
            InitializeComponent();
            cnn = new SqlConnection(db.MyConnection());

            

          
        }

        public void Dates(int num)
        {
            txtDate.Text = num + "";
        }
        public string setEvent { get; set;}
        public void displayEvent(string date)
        {
            cnn.Open();
            cmm = new SqlCommand("SELECT * FROM Events WHERE Date = " + date, cnn);
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
                label1.Text = (string)dr.GetValue(1);

            }
            cnn.Close();
            /*cnn.Open();
            cmm = new SqlCommand("SELECT * FROM Events WHERE Date = @date" , cnn);
            cmm.Parameters.AddWithValue("@date", year + "-" + month + "-" + day);
            //int d = 1;
            dr = cmm.ExecuteReader();
            while(dr.Read())
            {

                setEvent = (string)dr.GetValue(1);
                    //d++;
                
            }
            
            cnn.Close();

            label1.Text = setEvent;*/
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
