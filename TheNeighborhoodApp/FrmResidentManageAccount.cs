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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace TheNeighborhoodApp
{
    public partial class FrmResidentManageAccount : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        UserInfo _UserInfo;
        public FrmResidentManageAccount(UserInfo userinfo)
        {
            InitializeComponent();
            _UserInfo = userinfo;
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();

        }

        public void displayPersonalInfo()
        {
            NameTxt.Text = _UserInfo.getFirstname() + " " + _UserInfo.getLastname();
            AgeTxt.Text = _UserInfo.getAge().ToString();
            addressTxt.Text = _UserInfo.getStreet() + ", " + _UserInfo.getHomenumber();
            numTxt.Text = _UserInfo.getPhonenumber();
            gendertxt.Text = _UserInfo.getGender();
            usernameTxt.Text = _UserInfo.getUsername();
            passwordTxt.Text = _UserInfo.getPassword();

        }

        private void FrmResidentManageAccount_Load(object sender, EventArgs e)
        {
            BtnCancel.Visible = false;
            BtnSubmit.Visible = false;
            BtnEdit.Visible = true;
            displayPersonalInfo();
            panel1.Enabled = false;

            addressTxt.Enabled = false;
            gendertxt.Enabled = false;
            NameTxt.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            BtnCancel.Visible = true;
            BtnSubmit.Visible = true;
            BtnEdit.Visible = false;

            usernameTxt.Enabled = false;
            addressTxt.Enabled = false;
            gendertxt.Enabled = false;
            NameTxt.Enabled = false;
            panel1.Enabled = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            BtnCancel.Visible = false;
            BtnSubmit.Visible = false;
            BtnEdit.Visible = true;

            panel1.Enabled = false;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt16(AgeTxt.Text);
            if (IsValidPhoneNumber(numTxt.Text) && age >= 15 && passwordTxt.Text.Length >= 5)
            {
                updatePersonalInfo();
            }
            else if(!IsValidPhoneNumber(numTxt.Text))
            {
                MessageBox.Show("Please enter a valid phone number that starts with 09");
            }
            else if (age < 15)
            {
                MessageBox.Show("Age should be 15 or higher");
            }
            else if (passwordTxt.Text.Length <= 5)
            {
                MessageBox.Show("Make sure your password is more than 5 letters");
            }
           
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

        public void updatePersonalInfo()
        {
            string n = "Resident1";
            string query = "UPDATE UserInfo SET Age = @age, [Phone Number] = @number, Password = @password WHERE Username = '"+ n + "';";

            SqlCommand cmd = new SqlCommand(query, cnn);
          
            cmd.Parameters.AddWithValue("@Age", int.Parse(AgeTxt.Text));
         
            cmd.Parameters.AddWithValue("@Username", usernameTxt.Text);
           
            cmd.Parameters.AddWithValue("@Password", passwordTxt.Text);
          
            cmd.Parameters.AddWithValue("@number", numTxt.Text);
          
            cmd.ExecuteNonQuery();
            MessageBox.Show("Succesfully updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
