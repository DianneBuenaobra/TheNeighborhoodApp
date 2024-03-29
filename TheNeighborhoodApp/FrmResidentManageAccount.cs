﻿using System;
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
            pictureBox1.Image = _UserInfo.image;

        }

        private void FrmResidentManageAccount_Load(object sender, EventArgs e)
        {
            BtnCancel.Visible = false;
            BtnSubmit.Visible = false;
            BtnEdit.Visible = true;
            displayPersonalInfo();
            

            enableTxt(false, false, false);
            button1.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            BtnCancel.Visible = true;
            BtnSubmit.Visible = true;
            BtnEdit.Visible = false;

            button1.Enabled = true;
            enableTxt(true, true, true);
        }

        private void enableTxt(bool age, bool contact, bool password)
        {
            AgeTxt.Enabled = age;
            numTxt.Enabled = contact;
            passwordTxt.Enabled = password;

            usernameTxt.Enabled = false;
            addressTxt.Enabled = false;
            gendertxt.Enabled = false;
            NameTxt.Enabled = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            BtnCancel.Visible = false;
            BtnSubmit.Visible = false;
            BtnEdit.Visible = true;

            enableTxt(false, false, false);
            button1.Enabled = false;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt16(AgeTxt.Text);
            if (IsValidPhoneNumber(numTxt.Text) && age >= 15 && passwordTxt.Text.Length >= 5)
            {
                updatePersonalInfo();
                BtnCancel.Visible = false;
                BtnSubmit.Visible = false;
                BtnEdit.Visible = true;
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
           
            string query = "UPDATE UserInfo SET Age = @age, [Phone Number] = @number, Password = @password, Photo = @image WHERE Username = '"+ _UserInfo.getUsername() + "';";

            SqlCommand cmd = new SqlCommand(query, cnn);
          
            cmd.Parameters.AddWithValue("@Age", int.Parse(AgeTxt.Text));
         
            cmd.Parameters.AddWithValue("@Username", usernameTxt.Text);
           
            cmd.Parameters.AddWithValue("@Password", passwordTxt.Text);
          
            cmd.Parameters.AddWithValue("@number", numTxt.Text);

            cmd.Parameters.AddWithValue("@image", getPhoto());
          
            cmd.ExecuteNonQuery();
            MessageBox.Show("Succesfully updated");

            _UserInfo.setAge(Convert.ToInt32(AgeTxt.Text));
            _UserInfo.setPassword(passwordTxt.Text);
            _UserInfo.setPhonenumber(numTxt.Text);
            _UserInfo.image = pictureBox1.Image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
