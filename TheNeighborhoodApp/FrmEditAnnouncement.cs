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
    public partial class FrmEditAnnouncement : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        private UserInfo _userInfo;
        private adminAnnouncement adminannouncement;
        public FrmEditAnnouncement(UserInfo userInfo, adminAnnouncement adminannouncementt)
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();

            _userInfo = userInfo;
            this.adminannouncement = adminannouncementt;
        }

        private void FrmEditAnnouncement_Load(object sender, EventArgs e)
        {
            lbldate.Text = adminannouncement.date.ToString();
            lblid.Text = adminannouncement.buttonclickedid.ToString();
            lblstatus.Text = adminannouncement.status.ToString();

            txttitle.Text = adminannouncement.announcementname.ToString();
            txtdescription.Text = adminannouncement.announcementdescription.ToString();
            pictureBox1.Image = adminannouncement.image;
        }

        public void updateAnnouncement()
        {
            string query = "UPDATE Announcement SET Announcement = @announcement, AnnouncementInfo = @info, Image = @image WHERE AnnouncementId = '"+adminannouncement.buttonclickedid+"'";
            SqlCommand cmd = new SqlCommand(query, cnn);

            cmd.Parameters.AddWithValue("@announcement", txttitle.Text);
            cmd.Parameters.AddWithValue("@info", txtdescription.Text);
            cmd.Parameters.AddWithValue("@image", getPhoto());
            cmd.ExecuteNonQuery();
        }
        public byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);

            return stream.GetBuffer();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            updateAnnouncement();
            MessageBox.Show("Announcement Edited!");
        }

        private void btnphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openfiledialog.FileName);
            }
        }
    }
}
