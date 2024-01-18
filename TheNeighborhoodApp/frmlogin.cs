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
    public partial class frmlogin : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        private UserInfo _userInfo;
        public frmlogin(UserInfo userinfo)
        {
            con = new SqlConnection(dbcon.MyConnection());
            con.Open();
            _userInfo = userinfo;
            InitializeComponent();

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            signuptoppnl.Visible = false;
            loginpnl.Visible = true;
            contentpnl.Visible = false;
            g.BackColor = Color.SteelBlue;
        }

        private void backpb_Click(object sender, EventArgs e)
        {
            contentpnl.Visible = false;
            loginpnl.Visible = true;
            signuptoppnl.Visible = false;
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
        private string verify()
        {
            string verifyy = "";

            string query = "SELECT Verified FROM userInfo where username = @username";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", usertxt.Text);
            SqlDataReader da = cmd.ExecuteReader();
            
            while (da.Read())
            {
                verifyy = da.GetValue(0).ToString();

            }
       da.Close();

            return verifyy;

        }
        private void resident()
        {

            string usertype = "resident";
            string query = "SELECT * FROM dbo.UserInfo WHERE Username = '" + usertxt.Text + "' AND password = '" + userpasswordtxt.Text + "' AND UserType = '" + usertype + "'";

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
                usertxt.Clear();
                userpasswordtxt.Clear();
            }
            else if (dtable.Rows.Count > 0 && verify() == "no")
            {
                MessageBox.Show("You're logged in and not yet verified!");

                FrmHomepage frm = new FrmHomepage(_userInfo);
                setInfoResident();
                frm.ShowDialog();
                usertxt.Clear();
                userpasswordtxt.Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
         
           
        }

        private void admin()
        {

            string usertype = "admin";
            string query = "SELECT * FROM dbo.userInfo WHERE Username = '" + admintxt.Text + "' AND password = '" + adminpasswordtxt.Text + "' AND UserType = '" + usertype + "'";

            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataTable dtable = new DataTable();
            ad.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                MessageBox.Show("you're now logged in as an ADMIN");
                setInfoAdmin();

                FrmAdminHomepage frm = new FrmAdminHomepage(_userInfo);
                frm.ShowDialog();
                adminpasswordtxt.Clear();
                admintxt.Clear();
                this.Close();

            }
            else
            {
                MessageBox.Show("invalid credentials");
            }
        }

        public void setInfoResident()
        {


            string query = "SELECT [First Name], [Last Name], Age, Street, [Home Number], gender, Username, Password, UserType, [Phone Number], Verified, Photo FROM UserInfo WHERE Username = '" + usertxt.Text + "' AND Password = '" + userpasswordtxt.Text + "'";
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
                if (dr[11] != DBNull.Value)
                {
                    byte[] img = (byte[])(dr[11]);
                    MemoryStream ms = new MemoryStream(img);
                    _userInfo.image = Image.FromStream(ms);
                }
            }
            dr.Close();

            

        }


        public void setInfoAdmin()
        {


            string query = "SELECT [First Name], [Last Name], Age, Street, [Home Number], gender, Username, Password, UserType, [Phone Number], Photo FROM UserInfo WHERE Username = '" + admintxt.Text + "' AND Password = '" + adminpasswordtxt.Text + "'";
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
                if (dr[10] != DBNull.Value)
                {
                    byte[] img = (byte[])(dr[10]);
                    MemoryStream ms = new MemoryStream(img);
                    _userInfo.image = Image.FromStream(ms);
                }

            }

            dr.Close();
           

        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Userbtn.BackColor = Color.White;
            adminbtn.BackColor = Color.SteelBlue;
            admingroup.Visible = true;
            usergroup.Visible = false;

        }

        private void g_Click(object sender, EventArgs e)
        {
            Userbtn.BackColor = Color.SteelBlue;
            adminbtn.BackColor = Color.White;
            usergroup.Visible = true;
            admingroup.Visible = false;
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.SteelBlue;
            Userbtn.BackColor = Color.White;
            adminbtn.BackColor = Color.SteelBlue;
            admingroup.Visible = true;
            usergroup.Visible = false;
        }

        private void Userbtn_Click(object sender, EventArgs e)
        {
          
            g.BackColor = Color.SteelBlue;
            Userbtn.BackColor = Color.SteelBlue;
            adminbtn.BackColor = Color.White;
            usergroup.Visible = true;
            admingroup.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click_1(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            userpasswordtxt.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            adminpasswordtxt.PasswordChar = checkBox2.Checked ? '\0' : '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please reach out to our barangay officials.");
        }
    }
}
