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
    public partial class FrmMessages : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        private UserInfo _userInfo;
        FrmCreateMessage create;
     
        public FrmMessages(UserInfo userinfo)
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            _userInfo = userinfo;
            create = new FrmCreateMessage(_userInfo);

        }

        private void FrmMessages_Load(object sender, EventArgs e)
        {
            btnAddMessage.BringToFront();
            btnSent.BackColor = Color.FromKnownColor(KnownColor.GradientActiveCaption);
            displayChatsSent();
            
            
          
        }
        public void displayMessages()
        {
            panelMessage.Visible = true;flowLayoutPanel1.Visible = false; btnAddMessage.Visible = false;
            create.TopLevel = false; panelMessage.Controls.Add(create);
            create.Show();
           
        }

        private void btnAddMessage_Click(object sender, EventArgs e)
        {
            label1.Visible = false;btnReceived.Visible = false; btnSent.Visible = false;

            displayMessages();
        }
        public void displayChatsSent()
        {
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                label1.Visible = false;
            }
            else
            {
                label1.Visible = true;
            }
            flowLayoutPanel1.Visible = true; btnAddMessage.Visible = true;
            flowLayoutPanel1.Controls.Clear();
            btnAddMessage.BringToFront();
           
            cnn.Open();
            cmm = new SqlCommand("Select MessageID,ReceiverName,Message,UserProfile,Date,SenderUsername,ReceiverUsername from Messages where SenderUsername = '"
                + _userInfo.getUsername() + "'", cnn);
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
                UserControlMessages ucmessages = new UserControlMessages();
                ucmessages.display((int)dr.GetValue(0),dr.GetValue(1).ToString(), dr.GetValue(2).ToString());
                flowLayoutPanel1.Controls.Add(ucmessages);

            }
            
            cnn.Close();
        }
        public void displayChatsReceived()
        {
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                label1.Visible = false;
            }
            else
            {
                label1.Visible = true;
            }
            flowLayoutPanel1.Visible = true; btnAddMessage.Visible = true;
            flowLayoutPanel1.Controls.Clear();
            btnAddMessage.BringToFront();

            cnn.Open();
            cmm = new SqlCommand("Select MessageID,ReceiverName,Message,UserProfile,Date,SenderUsername,ReceiverUsername from Messages where ReceiverUsername = '" + _userInfo.getUsername() + "'", cnn);
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
                UserControlMessages ucmessages = new UserControlMessages();
                ucmessages.display((int)dr.GetValue(0), dr.GetValue(1).ToString(), dr.GetValue(2).ToString());
                flowLayoutPanel1.Controls.Add(ucmessages);

            }

            cnn.Close();
        }
        public  void closeContacts()
        {
            panelMessage.Controls.Remove(create);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnReceived.BackColor = Color.FromKnownColor(KnownColor.GradientInactiveCaption);
            btnSent.BackColor = Color.FromKnownColor(KnownColor.GradientActiveCaption);
            displayChatsSent();

        }

        private void btnReceived_Click(object sender, EventArgs e)
        {
            btnSent.BackColor = Color.FromKnownColor(KnownColor.GradientInactiveCaption);
            btnReceived.BackColor = Color.FromKnownColor(KnownColor.GradientActiveCaption);
            displayChatsReceived();
        }
    }
}
