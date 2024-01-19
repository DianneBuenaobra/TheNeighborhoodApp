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
        FrmCreateMessage create = new FrmCreateMessage();
     
        public FrmMessages(UserInfo userinfo)
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            _userInfo = userinfo;
           
        }

        private void FrmMessages_Load(object sender, EventArgs e)
        {
            btnAddMessage.BringToFront();
            displayChats();
            if(flowLayoutPanel1.Controls.Count == 0)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
            
          
        }
        public void displayMessages()
        {
            panelMessage.Visible = true;flowLayoutPanel1.Visible = false; btnAddMessage.Visible = false;
            create.TopLevel = false; panelMessage.Controls.Add(create);
            create.Show();
        }

        private void btnAddMessage_Click(object sender, EventArgs e)
        {
            displayMessages();
        }
        public void displayChats()
        {
            flowLayoutPanel1.Visible = true; btnAddMessage.Visible = true;
            btnAddMessage.BringToFront();
            
            cnn.Open();
            cmm = new SqlCommand("Select ReceiverName,Message,UserProfile,Date from Messages where Username = '"
                + _userInfo.getUsername() + "'", cnn);
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
                UserControlMessages ucmessages = new UserControlMessages();
                ucmessages.display(dr.GetValue(0).ToString(),dr.GetValue(1).ToString());
                flowLayoutPanel1.Controls.Add(ucmessages);

            }
            MessageBox.Show("lol");
            cnn.Close();
        }
    }
}
