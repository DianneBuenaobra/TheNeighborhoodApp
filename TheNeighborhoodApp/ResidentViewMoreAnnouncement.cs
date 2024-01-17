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
            txttitle.Text = announcement.announcement;
            txtdescription.Text = announcement.announcementinfo;
            lbldate.Text = announcement.date.ToString();
           lblid.Text = announcement.announcementid.ToString();
            pictureBox1.Image = announcement.image;
            

        }
    
    }
}
