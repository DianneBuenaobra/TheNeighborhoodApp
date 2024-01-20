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
    public partial class FrmNotification : Form
    {
        SqlDataReader dr;

        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        private UserInfo _userInfo;
        public FrmNotification(UserInfo userInfo)
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();
            this._userInfo = userInfo;
        }
        /*public void displayChats()
        {
            cnn.Open();
            cmm = new SqlCommand("Select ReceiverName,Message,UserProfile,date from Messages where Username = '"
                + _userInfo.getUsername() + "'", cnn);
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
                UserControlMessages ucmessages = new UserControlMessages();
                ucmessages.display(dr.GetValue(0).ToString(), dr.GetValue(1).ToString());
                flowAdminMessage.Controls.Add(ucmessages);

            }
            cnn.Close();
        }*/

        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }

        public string gender { get; set; }  
        public DateTime DateReg { get; set; }

        public string number {  get; set; }
        public Image image { get; set; }
        public string username { get; set; }


        private void FrmAdminMessages_Load(object sender, EventArgs e)
        {
            //A new user, [Name], has recently signed up and is currently awaiting verification.

                getNotification();
            getNotification2();

        }

        public void 
            getNotification()
        {
            string no = "no";
            string query = "SELECT [First Name], [Last Name], Age, Street, [Home Number], gender,[Date Registered],  [Phone Number], Photo, Username FROM UserInfo WHERE Verified = '" + no + "'";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                    UserControlNotification ucnotif = new UserControlNotification(this);
                    name = dr.GetValue(0).ToString() + " " + dr.GetValue(1).ToString();

                    age = (int)dr.GetValue(2);
                    address = dr.GetValue(3).ToString() + ", " + (int)dr.GetValue(4);

                    gender = dr.GetValue(5).ToString();
                    DateReg = (DateTime)dr.GetValue(6);
                    number = dr.GetValue(7).ToString();

                    if (dr[8] != DBNull.Value)
                    {
                        byte[] img = (byte[])(dr[8]);
                        MemoryStream ms = new MemoryStream(img);
                        image = Image.FromStream(ms);
                    }
                    username = dr.GetValue(9).ToString();


                    ucnotif.Name = username;
                    ucnotif.labels("A new user, " + name + ", has recently signed up and is currently awaiting verification.");
                flowNotif.Controls.Add(ucnotif);
              
            }
            dr.Close();
        }

        public int concernid { get; set; }
        public string concern {  get; set; }    
        public string concerninfo {  get; set; }    
        public string concernStatus{ get; set; }
        public string Cname { get; set; }
        public void getNotification2()
        {
            string statusss = "submitted";
            string query = "SELECT ConcernId, Concern, ConcernInfo, Name, ConcernStatus FROM Concern WHERE ConcernStatus = '" + statusss + "'";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                UserControlNotificationControl ucnotif = new UserControlNotificationControl(this);
                concernid = (int)dr.GetValue(0);
                concern = dr.GetValue(1).ToString();

                concerninfo = dr.GetValue(2).ToString();
                Cname = dr.GetValue(3).ToString();

                concernStatus = dr.GetValue(4).ToString();
              

                ucnotif.Name = concernid.ToString();
                ucnotif.labels( Cname + ": Submitted a new Concern.");
                flowNotif.Controls.Add(ucnotif);

            }
            dr.Close();
        }
        private void flowAdminMessage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowNotif.Controls.Clear();
            getNotification();
        }
    }
}
