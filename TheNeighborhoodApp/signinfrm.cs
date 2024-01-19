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
    public partial class signinfrm : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        //  SqlConnection con = new SqlConnection();
        public signinfrm()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection()); 
        }

        private void signinfrm_Load(object sender, EventArgs e)
        {

        }

 
        public string genderr()
        {
            string gender;
            if (female.Checked)
            {
                gender = "Female";
            }
            else if (male.Checked)
            {
                gender = "Male";
            }
            else if (other.Checked)
            {
                gender = "Other";
            }
            else
            {
                gender = "";
            }
            return gender;
        }

        static bool IsValidPhoneNumber(string number)
        {

            if (number != null && number.Length == 11)
            {

                if (number.StartsWith("09"))
                {
                    foreach (char c in number)
                    {
                        if (!char.IsDigit(c))
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string gender = genderr();
            int age = 0;
            if (signupagetxt.Text != "")
            {
                 Convert.ToInt32(signupagetxt.Text);
            }
          

            if (signupfnametxt.Text == "" || signuplnametxt.Text == ""  || gender =="" ||  signupStreettxt.Text == "" || signupStreettxt.Text == "" || signuphomenumtxt.Text == "" ||   (signupagetxt.Text == ""|| age <=14 ))
            {
                MessageBox.Show("Please fill all the fields correctly.");
            }
            else if (signupfnametxt.Text.Length <= 2 || signupfnametxt.Text.Length <=2)
            {
                MessageBox.Show("Please enter your valid name");
            }
            else if (!IsValidPhoneNumber(signupnumtxt.Text))
            {
                MessageBox.Show("Please enter a valid phone number. Make sure it starts with 09 and has 11 digits");
            }
            else
            {
                
                con.Open();

                string check = "Select Username FROM UserInfo WHERE Username = '"+signupusernametxt.Text+"'";

                SqlCommand cmd1 = new SqlCommand(check, con);
                string un = (string)cmd1.ExecuteScalar();
                if (un == signupusernametxt.Text)
                {
                    MessageBox.Show("Username already exist.");
                }
                else
                {
                    DateTime Today = DateTime.Today;

                    String insertInfo = "INSERT INTO UserInfo VALUES (@firstname, @lastname, @Age, @Street, @Homenumber, @gender, @Username, @Password, @UserType, @Dateregistered, @phonenumber, @verified, @photo)";
                    SqlCommand cmd = new SqlCommand(insertInfo, con);
                    cmd.Parameters.AddWithValue("@firstname", signupfnametxt.Text);
                    cmd.Parameters.AddWithValue("@lastname", signuplnametxt.Text);
                    cmd.Parameters.AddWithValue("@Age", int.Parse(signupagetxt.Text));
                    cmd.Parameters.AddWithValue("@Street", signupStreettxt.Text);
                    cmd.Parameters.AddWithValue("@Homenumber", int.Parse(signuphomenumtxt.Text));
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@Username", signupusernametxt.Text);
                    cmd.Parameters.AddWithValue("@UserType", "Resident");
                    cmd.Parameters.AddWithValue("@Password", signuppasswordtxt.Text);
                    cmd.Parameters.AddWithValue("@Dateregistered", Today);
                    cmd.Parameters.AddWithValue("@phonenumber", signupnumtxt.Text);
                    cmd.Parameters.AddWithValue("@verified", "no");
                    cmd.Parameters.AddWithValue("@photo", getPhoto());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succesfully registered! You can now log in your account.");

                    signupfnametxt.Clear();
                    signuplnametxt.Clear();
                    signupusernametxt.Clear();
                    signuppasswordtxt.Clear();
                    signupagetxt.Clear();
                    signupStreettxt.Clear();
                    signuphomenumtxt.Clear();
                    signupagetxt.Clear();
                    signupnumtxt.Clear();
                    
                }
               
                con.Close();
               

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openfiledialog.FileName);
            }
        }

        public byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);

            return stream.GetBuffer();
        }
    }
}
