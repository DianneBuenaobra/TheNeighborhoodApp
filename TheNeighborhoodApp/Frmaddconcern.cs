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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TheNeighborhoodApp
{
    public partial class FrmAddConcern : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
                
        private UserInfo _userinfo;
        
        public FrmAddConcern(UserInfo userInfo)
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();
            _userinfo = userInfo;
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (concerntxtbx.Text == "" || concerninfotxtbx.Text == "")
                {
                    MessageBox.Show("Please enter your concern before submitting.");
                }
                else
                {
                    submitConcern();
                }
            }
            catch
            {
                MessageBox.Show("Please summaries your concern shorter.");
            }
           
           
        }
        public int id()
        {
            int idd = 0;
            string query = "SELECT MAX(ConcernId) FROM Concern;";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                idd = (int)dr.GetValue(0);

            }
            dr.Close();
            return idd;
        }

        public void submitConcern()
        {
            int cid = id();
            DateTime Today = DateTime.Now;
           
            String insertInfo = "INSERT INTO Concern VALUES (@concernid, @concern, @concerninfo, @photo, @date, @name, @username, @concernstatus)";
            SqlCommand cmd = new SqlCommand(insertInfo, cnn);
            cmd.Parameters.AddWithValue("@concernid", ++cid);
            cmd.Parameters.AddWithValue("@concern", concerntxtbx.Text);
            cmd.Parameters.AddWithValue("@concerninfo",concerninfotxtbx.Text);
            cmd.Parameters.AddWithValue("@photo", getPhoto());
            cmd.Parameters.AddWithValue("@date", Today);
            cmd.Parameters.AddWithValue("@name", lblName.Text);
            cmd.Parameters.AddWithValue("@username", _userinfo.getUsername().ToString());
            cmd.Parameters.AddWithValue("@concernstatus", "Submitted");

            cmd.ExecuteNonQuery();
            MessageBox.Show("Succesfully submitted! Please wait for our response. Thank you!");
            
        }

        private void FrmAddConcern_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            lblDate.Text = today.ToString();
            lblName.Text = _userinfo.getFirstname() + " " + _userinfo.getLastname();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
    
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                picboxConcern.Image = new Bitmap(openfiledialog.FileName);
            }

        }
        public byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            picboxConcern.Image.Save(stream, picboxConcern.Image.RawFormat);

            return stream.GetBuffer();
        }
    }
}
