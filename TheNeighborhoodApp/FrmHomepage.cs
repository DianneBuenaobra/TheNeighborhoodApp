using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNeighborhoodApp
{
    public partial class FrmHomepage : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        private UserInfo _userInfo;
        public FrmHomepage(UserInfo userInfo)
        {
            this._userInfo = userInfo;

            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            lineHome.Visible = false;slctHome.Visible = false;
            lineNotif.Visible = false; slctNotif.Visible = false;
            lineMessage.Visible = true;slctMessage.Visible = true;
        }

        private void btnNotif_Click(object sender, EventArgs e)
        {
            lineMessage.Visible = false;slctMessage.Visible = false;
            lineHome.Visible = false; slctHome.Visible = false;
            lineNotif.Visible = true; slctNotif.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lineMessage.Visible = false; slctMessage.Visible = false;
            lineHome.Visible = true; slctHome.Visible = true;
            lineNotif.Visible = false; slctNotif.Visible = false;
        }

        private void FrmHomepage_Load(object sender, EventArgs e)
        {
            
            usernamelbl.Text = _userInfo.getFirstname() + " " + _userInfo.getLastname();

        }

        private void concernBtn_Click(object sender, EventArgs e)
        {
           
            homepnl.Visible = true;
            homepnl.BringToFront();
            FrmConcernResident frm = new FrmConcernResident(_userInfo);
            frm.TopLevel = false;
            homepnl.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
