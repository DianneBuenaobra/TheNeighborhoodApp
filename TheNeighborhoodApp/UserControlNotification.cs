using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNeighborhoodApp
{
    public partial class UserControlNotification : UserControl
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        private FrmNotification notifInfo;
        public UserControlNotification(FrmNotification notifInfo)
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();

            this.notifInfo =notifInfo;
            Username = this.Name;
            
        }

        public void labels(string Details)
        {
            txtDetails.Text = Details;
        }
       

        private void txtDetails_Click_1(object sender, EventArgs e)
        {

            AdminNotificationDetail frm = new AdminNotificationDetail(this);
            getUserInfo();
            frm.ShowDialog();
        }

        private void UserControlNotification_Click(object sender, EventArgs e)
        {
            AdminNotificationDetail frm = new AdminNotificationDetail(this);
            getUserInfo();
            frm.ShowDialog();
        }

        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string number { get; set; }
        public string gender { get; set; }
        public Image image { get; set; }

        public string Username { get; set; }
        public void getUserInfo()
        {
            string query = "SELECT [First Name], [Last Name], Age, Street, [Home Number], gender,  [Phone Number], Photo FROM UserInfo WHERE Username = '" + this.Name + "'";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                name = dr.GetValue(0).ToString() + " " + dr.GetValue(1).ToString();

                age = (int)dr.GetValue(2);
                address = dr.GetValue(3).ToString() + ", " + (int)dr.GetValue(4);

               gender = dr.GetValue(5).ToString();

                number= dr.GetValue(6).ToString();

                if (dr[7] != DBNull.Value)
                {
                    byte[] img = (byte[])(dr[7]);
                    MemoryStream ms = new MemoryStream(img);
                    image = Image.FromStream(ms);
                }

            }
            dr.Close();
        }
       
    }
}
