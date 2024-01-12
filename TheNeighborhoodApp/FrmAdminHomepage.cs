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
    public partial class FrmAdminHomepage : Form
    {
        FrmAdminResidentsList rlist = new FrmAdminResidentsList();
        FrmAdminCalendar calendar = new FrmAdminCalendar();
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        private UserInfo _userInfo;
        public FrmAdminHomepage(UserInfo userInfo)
        {
            this._userInfo = userInfo;

            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();
        }

        private void FrmAdminHomepage_Load(object sender, EventArgs e)
        {
            displayHome();
        }
        public void displayHome()
        {
            AdminNF.Visible = true;
            AdminNF.BringToFront();
            adminAnnouncement frm = new adminAnnouncement(_userInfo);
            frm.TopLevel = false;
            AdminNF.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuList.Visible = true;
            btnMenu.Visible = false;
            btnBack.Visible = true;
            rlist.eventclickSearch();

        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            menuList.Visible = false;
            btnMenu.Visible = true; rlist.eventclickSearch();
        }
        /*public void showResidentList()
        {
            FrmAdminResidentsList rlist = new FrmAdminResidentsList();
            rlist.BringToFront();
            rlist.TopLevel = false;
            AdminNF.Controls.Add(rlist);
            rlist.Show();
        }*/

        private void btnRList_Click(object sender, EventArgs e)
        {
            menuList.Visible = false;
            btnMenu.Visible = true;
            rlist.TopLevel = false;
            AdminNF.Controls.Clear();
            AdminNF.Controls.Add(rlist);rlist.Show(); rlist.eventclickSearch();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            menuList.Visible = false;
            btnMenu.Visible = true;
            calendar.TopLevel = false;
            AdminNF.Controls.Clear();
            AdminNF.Controls.Add(calendar); calendar.Show(); rlist.eventclickSearch();


        }

        private void btnNewsfeed_Click(object sender, EventArgs e)
        {
            menuList.Visible = false;
            btnMenu.Visible = true; rlist.eventclickSearch();
        }
    }
}
