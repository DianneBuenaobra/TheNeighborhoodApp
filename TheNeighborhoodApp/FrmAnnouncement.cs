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
    public partial class FrmAnnouncement : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        private UserInfo _userInfo;
        public FrmAnnouncement(UserInfo userinfo)
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();
            _userInfo = userinfo;
        }
        public int announcementid { get; set; }
        public string announcement { get; set; }
        public string announcementinfo { get; set; }
        public DateTime date { get; set; }
        public string image { get; set; }

        public void getAnnouncement()
        {

            string query = "SELECT AnnouncementId, Announcement, AnnouncementInfo, Image, Date FROM Announcement";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                announcementid = (int)dr.GetValue(0);
                announcement = (string)dr.GetValue(1);
                announcementinfo = (string)dr.GetValue(2);
                //image
                date = (DateTime)dr.GetValue(4);
                announcementPanel();
            }
            dr.Close();
        }
        public void announcementPanel()
        {
            Panel panel;
            panel = new Panel();
            panel.Name = String.Format("PnlConcern{0}", announcementid);
            panel.BackColor = Color.SteelBlue;
            panel.Size = new Size(452, 163); //125, 205
            panel.Margin = new Padding(15);
            panel.Location = new Point(15, 15);
            panel.Tag = announcementid;

            Label labeldescription;
            labeldescription = new Label();
            labeldescription.Name = String.Format("LblConcernTitle{0}", announcementid);
            labeldescription.Text = announcementinfo;
            labeldescription.Location = new Point(318, 12);
            labeldescription.ForeColor = Color.Black;
            labeldescription.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
            labeldescription.AutoSize = true;
            labeldescription.Tag = announcementid;
            labeldescription.MaximumSize = new Size(120, 120);
            labeldescription.MinimumSize = new Size(120, 120);
            labeldescription.BackColor = Color.White;

            PictureBox picBox;
            picBox = new PictureBox();
            picBox.Name = String.Format("PbconcernImage{0}", announcementid);
            picBox.Size = new Size(304, 140);
            picBox.Location = new Point(0,0);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.BackColor = Color.White;

            Button button;
            button = new Button();
            button.Name = String.Format("PbconcernButton{0}", announcementid);
            button.Size = new Size(452, 21);
            button.Text = "View More";
            button.Location = new Point(0, 142);
            button.ForeColor = Color.Black;
            button.BackColor = Color.White;
            button.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
            button.Tag = announcementid;
            /*
            if (File.Exists(movie.ImagePath))
                picBox.Image = Image.FromFile(movie.ImagePath);

            picBox.Tag = movie.Id;
            */
            panel.Controls.Add(button);
            panel.Controls.Add(picBox);
       
            panel.Controls.Add(labeldescription);
            flowLayoutPanel1.Controls.Add(panel);

        }

        private void FrmAnnouncement_Load(object sender, EventArgs e)
        {
            getAnnouncement();
        }
    }
}
