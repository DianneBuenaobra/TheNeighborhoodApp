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
    public partial class FrmAdminMessages : Form
    {
        SqlDataReader dr;

        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        private UserInfo _userInfo;
        public FrmAdminMessages(UserInfo userInfo)
        {
            InitializeComponent();
            this._userInfo = userInfo;
        }
        public void displayChats()
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
        }

        private void FrmAdminMessages_Load(object sender, EventArgs e)
        {
            displayChats();
            if (flowAdminMessage.Controls.Count == 0)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void flowAdminMessage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddMessage_Click(object sender, EventArgs e)
        {
            FrmChat chat = new FrmChat();
            chat.Show();
        }
    }
}
