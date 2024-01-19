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
    public partial class ResidentViewMoreAnnouncement : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

   
        private FrmAnnouncement announcement;
        public ResidentViewMoreAnnouncement(FrmAnnouncement announcement)
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();

            this.announcement = announcement;
        }

        private void ResidentViewMoreAnnouncement_Load(object sender, EventArgs e)
        {
          //title, info, id, image, 
            displayFormView(announcement.announcement, announcement.announcementinfo, announcement.date.ToString(), announcement.announcementid.ToString(), announcement.image);
        }

        private void displayFormView(string title, string info, string date, string id, Image image)
        {
            txttitle.Text = title;
            txtdescription.Text = info;
            lbldate.Text = date;
            lblid.Text = id;
            pictureBox1.Image = image;
        }
    
    }
}
