using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNeighborhoodApp
{
    public partial class NewMessage : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm;
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        private UserInfo _userInfo;

        string receivername;
        public NewMessage(UserInfo userInfo)
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            _userInfo = userInfo;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewMessage_Load(object sender, EventArgs e)
        {
            MessageBox.Show(_userInfo.getUsername());
        }
        public void getReceiver(string username,string name)
        {
            tbReceiver.Text = username; this.receivername = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbMessage.Equals(""))
            {   
                MessageBox.Show("Message field cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FrmMessages mss = new FrmMessages(_userInfo);
                
                cnn.Open();
                SqlCommand cmm = new SqlCommand("INSERT INTO Messages VALUES (@MessageID,@SenderName,@Message,@Date,@ReceiverName,@UserProfile,@SenderUsername," +
                    "@ReceiverUsername,@MessagePhoto)", cnn);
                cmm.Parameters.AddWithValue("@MessageID", getMessageID());
                cmm.Parameters.AddWithValue("@SenderName", _userInfo.getFirstname() + " " + _userInfo.getLastname());
                cmm.Parameters.AddWithValue("@Message", tbMessage.Text);
                cmm.Parameters.AddWithValue("@Date", DateTime.Now);
                cmm.Parameters.AddWithValue("@ReceiverName", this.receivername);
                cmm.Parameters.AddWithValue("@UserProfile", getPhoto()) ;
                cmm.Parameters.AddWithValue("@SenderUsername", _userInfo.getUsername());
                cmm.Parameters.AddWithValue("@ReceiverUsername", tbReceiver.Text);
                cmm.Parameters.AddWithValue("@MessagePhoto", getPhoto());
                cmm.ExecuteNonQuery();
                
                cnn.Close();

                MessageBox.Show("Successfully Sent!", "Message Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mss.closeContacts();
                mss.displayChatsSent();
                this.Close();
            }
        }
       
        public int getMessageID()
        {
            int messID = 0;
            
            cmm = new SqlCommand("SELECT COUNT(*) FROM Messages", cnn);
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
                messID = (int)dr.GetValue(0);
            }
            dr.Close();
            if(messID == 0)
            {
                return messID = 1;
            }
            else
            {
                return messID++;
            }
            
        }
        public byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            if(_userInfo.image != null && _userInfo.image != null)
            {
                _userInfo.image.Save(stream, _userInfo.image.RawFormat);
            }
            return stream.GetBuffer();
        }
    }
}
