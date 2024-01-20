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
    public partial class UserControlNotificationControl : UserControl
    {

        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

       

        FrmNotification notification;
        public UserControlNotificationControl(FrmNotification notification)
        {
            InitializeComponent();
            this.notification = notification;
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();
            
        }

        public void labels(string Details)
        {
            txtDetails.Text = Details;
        }

        private void txtDetails_Click(object sender, EventArgs e)
        {
            iddd = Convert.ToInt16(this.Name);
            AdminNotificationConcernInfo frm = new AdminNotificationConcernInfo(this);
           getUserInfo();
            frm.ShowDialog();
        }

        private void UserControlNotificationControl_Click(object sender, EventArgs e)
        {
            iddd = Convert.ToInt16(this.Name);
            AdminNotificationConcernInfo frm = new AdminNotificationConcernInfo(this);
            getUserInfo();
            frm.ShowDialog();
            
        }

        public string concern { get; set; }
        public int concernid { get; set; }
        public string concerninfo { get; set; }
        public string concernstatus { get; set; }
        public string cname { get; set; }
       
public int iddd {  get; set; }
        public void getUserInfo()
        {
           
            string query = "SELECT ConcernId, Concern, ConcernInfo, ConcernStatus, Name FROM Concern WHERE ConcernId = '" + iddd + "'";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                concernid = (int)dr.GetValue(0);

                concern = dr.GetValue(1).ToString();
                concerninfo = dr.GetValue(2).ToString();

                concernstatus = dr.GetValue(3).ToString();

                cname = dr.GetValue(4).ToString();

             

            }
            dr.Close();
        }

    
}
}
