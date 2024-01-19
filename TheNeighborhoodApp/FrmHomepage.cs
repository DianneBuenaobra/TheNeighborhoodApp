using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

      
        FrmCalendar calendar = new FrmCalendar();
        public FrmHomepage(UserInfo userInfo)
        {
            
            this._userInfo = userInfo;
           

            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
             FrmMessages messages = new FrmMessages(_userInfo);
            lineHome.Visible = false;slctHome.Visible = false;
            lineNotif.Visible = false; slctNotif.Visible = false;
            lineMessage.Visible = true;slctMessage.Visible = true;
            messages.TopLevel = false; panelHomepage.Controls.Add(messages);
            displayMessages();
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

            displayHome();
        }

        private void FrmHomepage_Load(object sender, EventArgs e)
        {
            Pnllogout.Visible = false;
            PnlmanageAcc.Visible = false;
            usernamelbl.Text = _userInfo.getFirstname() + " " + _userInfo.getLastname();
            displayHome();
        }

        public void displayHome()
        {
            panelHomepage.Visible = true;
            panelHomepage.BringToFront();
            DisplayHome frm = new DisplayHome(_userInfo);
            frm.TopLevel = false;
            panelHomepage.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        public void displayMessages()
        {
            FrmMessages messages = new FrmMessages(_userInfo);
            panelHomepage.Visible = true;
            panelHomepage.BringToFront();
            messages.TopLevel = false;
            panelHomepage.Controls.Clear();
            panelHomepage.Controls.Add(messages);
            messages.BringToFront();
            messages.Show();
        }
        public void displayCalendar()
        {
            panelHomepage.Visible = true;
            panelHomepage.BringToFront();
            calendar.TopLevel = false;
            panelHomepage.Controls.Add(calendar);
            calendar.BringToFront();
            calendar.Show();
        }

        public int clickcount { get; set; }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            clickcount = clickcount + 1;
            
            if (clickcount / 2 == 0)
            {
                Pnllogout.BringToFront();
                Pnllogout.Visible = true;
            }
            else {
                Pnllogout.Visible = false;
               
                clickcount = 0;
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnManageAcc_Click(object sender, EventArgs e)
        {
            Pnllogout.Visible = false;
            PnlmanageAcc.Visible = true;
            displayManageAcc();
        }

        public void displayManageAcc()
        {
            panelHomepage.Visible = true;
            panelHomepage.BringToFront();
            FrmResidentManageAccount frm = new FrmResidentManageAccount(_userInfo);
            frm.TopLevel = false;
            panelHomepage.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            displayHome();
            PnlmanageAcc.Visible = false;
        }

      

        private void Pnllogout_MouseEnter(object sender, EventArgs e)
        {
            //Pnllogout.Visible = true;
        }

        private void Pnllogout_MouseLeave(object sender, EventArgs e)
        {
            //Pnllogout.Visible= false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
          //  Pnllogout.Visible = false;
        }

        private void panelHomepage_MouseClick(object sender, MouseEventArgs e)
        {
           // Pnllogout.Visible = false;
        }

        private void panelHomepage_Paint(object sender, PaintEventArgs e)
        {
           // Pnllogout.Visible = false;
        }

        private void slctNotif_Click(object sender, EventArgs e)
        {
           // Pnllogout.Visible = false;
        }

        private void slctMessage_Click(object sender, EventArgs e)
        {
           // Pnllogout.Visible = false;
        }

        private void lineNotif_Click(object sender, EventArgs e)
        {
         //   Pnllogout.Visible = false;
        }

        private void lineMessage_Click(object sender, EventArgs e)
        {
            //Pnllogout.Visible = false;
        }

        private void slctHome_Click(object sender, EventArgs e)
        {
            //Pnllogout.Visible = false;
        }

        private void usernamelbl_Click(object sender, EventArgs e)
        {
           // Pnllogout.Visible = false;
        }

        private void lineHome_Click(object sender, EventArgs e)
        {
            //Pnllogout.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            displayCalendar();
        }
    }
}
