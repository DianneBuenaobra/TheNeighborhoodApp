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
    public partial class displayfrm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-09ORH5O\MSSQLSERVER01;Initial Catalog=neighborhoodDB;Integrated Security=True;Pooling=False");
        private UserInfo _userInfo;
        public displayfrm(UserInfo userinfo)
        {
            _userInfo = userinfo;
            InitializeComponent();
            
        }

        private void displayfrm_Load(object sender, EventArgs e)
        {
            signuptoppnl.Visible = false;
            loginpnl.Visible = true;
            contentpnl.Visible = false;
/*
            contentpnl.BringToFront();
            loginfrm login = new loginfrm();

            login.TopLevel = false;
            contentpnl.Controls.Add(login);
            login.BringToFront();
            login.Show();
*/
        }

        private void useradminbtn_Click(object sender, EventArgs e)
        {
            Userbtn.BackColor = Color.SteelBlue;
            adminbtn.BackColor = Color.White;
            usergroup.Visible = true;
            admingroup.Visible = false;
        }

        private void adminadminbtn_Click(object sender, EventArgs e)
        {
            Userbtn.BackColor = Color.White;
            adminbtn.BackColor = Color.SteelBlue;
            admingroup.Visible = true;
            usergroup.Visible = false;
        }

        private void Userbtn_Click(object sender, EventArgs e)
        {
            Userbtn.BackColor = Color.SteelBlue;
            adminbtn.BackColor = Color.White;
            usergroup.Visible = true;
            admingroup.Visible = false;
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            Userbtn.BackColor = Color.White;
            adminadminbtn.BackColor = Color.SteelBlue;
            usergroup.Visible = false;
            admingroup.Visible = true;
        }
        

        private void signupbtn_Click(object sender, EventArgs e)
        {
            toppnl.Visible = true;
            signuptoppnl.Visible = true;
            contentpnl.Visible = true;

            contentpnl.BringToFront();
            signinfrm signin = new signinfrm();
            signin.TopLevel = false;
            contentpnl.Controls.Add(signin);
            signin.BringToFront();
            signin.Show();
        }

        private void backpb_Click(object sender, EventArgs e)
        {

            contentpnl.Visible = false;
            loginpnl.Visible = true;
            signuptoppnl.Visible = false;
        }

        private void admingroup_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            adminpasswordtxt.PasswordChar = checkBox2.Checked ? '\0' : '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            userpasswordtxt.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private string verify()
        {
            string verifyy = "";
            con.Open();
            string query = "SELECT Verified FROM userInfo where username = @username";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", usertxt.Text);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                verifyy = da.GetValue(0).ToString();

             
            }
             con.Close();
            return verifyy;
           
        }
        private void resident()
        {
            string usertype = "Resident";
            string query = "SELECT * FROM userInfo WHERE Username = '" + usertxt.Text + "' AND password = '" + userpasswordtxt.Text + "' AND UserType = '" + usertype + "'";

            SqlDataAdapter ad = new SqlDataAdapter(query, con);

            DataTable dtable = new DataTable();
            ad.Fill(dtable);

           // MessageBox.Show(verify());
            if (dtable.Rows.Count > 0 && verify() == "yes")
            {
                MessageBox.Show("You're logged in and verified!");
                FrmHomepage frm = new FrmHomepage(_userInfo);
                setInfoResident();
                frm.ShowDialog();
            }
            else if (dtable.Rows.Count > 0 && verify() == "no")
            {
                MessageBox.Show("You're logged in and not yet  verified!");
                
                FrmHomepage frm = new FrmHomepage(_userInfo);
                setInfoResident();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }

            con.Close( );
        }

        private void admin()
        {
            string usertype = "Admin";
            string query = "SELECT * FROM userInfo WHERE Username = '" + admintxt.Text + "' AND password = '" + adminpasswordtxt.Text + "' AND UserType = '" + usertype + "'";

            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataTable dtable = new DataTable();
            ad.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                MessageBox.Show("you're now logged in as an ADMIN");
                getInfoAdmin();
                
                FrmAdminHomepage frm = new FrmAdminHomepage();
                frm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("invalid credentials");
            }
        }

        public void setInfoResident()
        {
            
            con.Open();
            string query = "SELECT [First Name], [Last Name], Age, Street, [Home Number], gender, Username, Password, UserType, [Phone Number], Verified FROM UserInfo WHERE Username = '" + usertxt.Text + "' AND Password = '" + userpasswordtxt.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con); 
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _userInfo.setFirstname(dr.GetValue(0).ToString());
                _userInfo.setLastname(dr.GetValue(1).ToString());
                _userInfo.setAge((int)dr.GetValue(2));
                _userInfo.setStreet(dr.GetValue(3).ToString());
                _userInfo.setHomenumber((int)dr.GetValue(4));
                _userInfo.setGender(dr.GetValue(5).ToString());
                _userInfo.setUsername(dr.GetValue(6).ToString());
                _userInfo.setPassword(dr.GetValue(7).ToString());
                _userInfo.setUserType(dr.GetValue(8).ToString());
                _userInfo.setPhonenumber(dr.GetValue(9).ToString());
                _userInfo.setVerified(dr.GetValue(10).ToString()); ;
            }

            con.Close();
        }
        /*
        public void getInfoResident()
        {
            _userInfo.getFirstname();
            _userInfo.getLastname();
            _userInfo.getAge();
            _userInfo.getStreet();
            _userInfo.getHomenumber();
            _userInfo.getGender();
            _userInfo.getUsername();
            _userInfo.getPassword();
            _userInfo.getUserType();
            _userInfo.getPhonenumber();
            _userInfo.getVerified(); ;

        }
        */

        public void getInfoAdmin()
        {

            con.Open();
            string query = "SELECT [First Name], [Last Name], Age, Street, [Home Number], gender, Username, Password, UserType, [Phone Number] FROM UserInfo WHERE Username = '" + admintxt.Text + "' AND Password = '" + adminpasswordtxt.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _userInfo.setFirstname(dr.GetValue(0).ToString());
                _userInfo.setLastname(dr.GetValue(1).ToString());
                _userInfo.setAge((int)dr.GetValue(2));
                _userInfo.setStreet(dr.GetValue(3).ToString());
                _userInfo.setHomenumber((int)dr.GetValue(4));
                _userInfo.setGender(dr.GetValue(5).ToString());
                _userInfo.setUsername(dr.GetValue(6).ToString());
                _userInfo.setPassword(dr.GetValue(7).ToString());
                _userInfo.setUserType(dr.GetValue(8).ToString());
                _userInfo.setPhonenumber(dr.GetValue(9).ToString());
            
            }
            con.Close() ;
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (usergroup.Visible == true)
            {
                resident(); 
            }
            else
            {
                admin();
            }
        }
    }
}
