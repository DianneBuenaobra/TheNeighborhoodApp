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

       
        public void displayEvent(int year,int month, int day)
        {
            /*cnn.Open();
            cmm = new SqlCommand("SELECT * FROM Events WHERE Date = @date" , cnn);
            cmm.Parameters.AddWithValue("@date", FrmAdminCalendar.selectedDate);
            int d = 1;
            dr = cmm.ExecuteReader();
            while(dr.Read())
            {
                if (d <= day)
                {
                    label1.Text = dr["eventName"].ToString();
                    d++;
                }
            }
            
            cnn.Close();*/


        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
