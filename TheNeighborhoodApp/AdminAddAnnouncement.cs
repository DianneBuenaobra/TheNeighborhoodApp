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

namespace TheNeighborhoodApp
{
    public partial class AdminAddAnnouncement : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        public AdminAddAnnouncement()
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                picboxAnnouncement.Image = new Bitmap(openfiledialog.FileName);
            }
        }
        public byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            picboxAnnouncement.Image.Save(stream, picboxAnnouncement.Image.RawFormat);

            return stream.GetBuffer();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            AddAnnouncemnet();
        }

       

        public void AddAnnouncemnet()
        {
            int idd = id();
            String insertInfo = "INSERT INTO Announcement VALUES (@announcemenid, @announcement, @announcementinfo, @image, @date, @status)";
            SqlCommand cmd = new SqlCommand(insertInfo, cnn);
            cmd.Parameters.AddWithValue("@announcemenid", ++idd);
            cmd.Parameters.AddWithValue("@announcement", txtannouncement.Text);
            cmd.Parameters.AddWithValue("@announcementinfo", txtannouncementinfo.Text);
            cmd.Parameters.AddWithValue("@image", getPhoto());
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@status", "Pending");

            cmd.ExecuteNonQuery();
            MessageBox.Show("Succesfully added");

        }
        public int id()
        {
            int idd = 0;
            string query = "SELECT MAX(AnnouncementId) FROM Announcement;";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                idd = (int)dr.GetValue(0);

            }
            dr.Close();
            return idd;
        }

        private void AdminAddAnnouncement_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
