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
    public partial class adminAnnouncement : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        private UserInfo _userInfo;
        public adminAnnouncement(UserInfo userinfo)
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();

            _userInfo = userinfo;
        }
        public int announcementid { get; set; }
        public string announcementname { get; set; }
        public string announcementdescription { get; set; }
        public DateTime date { get; set; }
        public string name { get; set; }
        public string username { get; set; }
       
        public Image image { get; set; }
        public void admingetConcernInfo()
        {

            string query = "SELECT AnnouncementId, Announcement, AnnouncementInfo, Image, Date FROM Announcement";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                announcementid = (int)dr.GetValue(0);
                announcementname = (string)dr.GetValue(1);
                announcementdescription = (string)dr.GetValue(2);
                //image
                if (dr[3] != DBNull.Value)
                {
                    byte[] img = (byte[])(dr[3]);
                    MemoryStream ms = new MemoryStream(img);
                    image = Image.FromStream(ms);
                }
                date = (DateTime)dr.GetValue(4);
             

                adminannouncementpanels();
            }
            dr.Close();
        }

        public void adminannouncementpanels()
        {

            Panel panel;
            panel = new Panel();
            panel.Name = String.Format("PnlConcern{0}", announcementid);
            panel.BackColor = Color.SteelBlue;
            panel.Size = new Size(438, 217); 
            panel.Margin = new Padding(20);
            panel.Location = new Point(20, 20);
            panel.Tag = announcementid;

            
            Label labelTitle;
            labelTitle = new Label();
            labelTitle.Name = String.Format("LblConcernTitle{0}", announcementid);
            labelTitle.Text = announcementname;
            labelTitle.Location = new Point(227, 36);
            labelTitle.ForeColor = Color.White;
            labelTitle.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Bold);
            labelTitle.AutoSize = true;
            labelTitle.Tag = announcementid;
            labelTitle.MaximumSize = new Size(140, 20);
            labelTitle.MinimumSize = new Size(140, 20);
            


            Label labeldescription;
            labeldescription = new Label();
            labeldescription.Name = String.Format("LblConcernTitle{0}", announcementid);
            labeldescription.Text = announcementdescription;
            labeldescription.Location = new Point(227, 65);
            labeldescription.ForeColor = Color.Black;
            labeldescription.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            labeldescription.AutoSize = true;
            labeldescription.Tag = announcementid;
            labeldescription.MaximumSize = new Size(200, 120);
            labeldescription.MinimumSize = new Size(200, 120) ;
            labeldescription.BackColor = Color.White;

            Label labeldate;
            labeldate = new Label();
            labeldate.Name = String.Format("LblConcernYear{0}", announcementid);
            labeldate.Text = date.ToString();
            labeldate.Location = new Point(227, 12);
            labeldate.ForeColor = Color.WhiteSmoke;
            labeldate.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            labeldate.Tag = announcementid;
            /*
            Label labelstatus;
            labelstatus = new Label();
            labelstatus.Name = String.Format("LblConcernStatus{0}", concernid);
            labelstatus.Text = concernstatus;
            labelstatus.Location = new Point(187, 10);
            labelstatus.ForeColor = Color.WhiteSmoke;
            labelstatus.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            labelstatus.Tag = concernid;
            */
            PictureBox picBox;
            picBox = new PictureBox();
            picBox.Name = String.Format("PbconcernImage{0}", announcementid);
            picBox.Size = new Size(218, 185);
            picBox.Location = new Point(3,3);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.BackColor = Color.White;
            picBox.Image = image;

            Button editbutton;
            editbutton = new Button();
            editbutton.Name = String.Format("PbconcernButton{0}", announcementid);
            editbutton.Size = new Size(221, 23);
            editbutton.Text = "Edit";
            editbutton.Location = new Point(0, 194);
            editbutton.ForeColor = Color.White;
            editbutton.Font = new Font("Microsoft Sans Serif", 9.5f, FontStyle.Regular);
            editbutton.Tag = announcementid;
            editbutton.Click += new EventHandler(this.button_click);

            Button deletebutton;
            deletebutton = new Button();
            deletebutton.Name = String.Format("PbconcernButton{0}", announcementid);
            deletebutton.Size = new Size(221, 23);
            deletebutton.Text = "delete";
            deletebutton.Location = new Point(217, 194);
            deletebutton.ForeColor = Color.White;
            deletebutton.Font = new Font("Microsoft Sans Serif", 9.5f, FontStyle.Regular);
            deletebutton.Tag = announcementid;
            deletebutton.Click += new EventHandler(this.button_click);
            /*
            if (File.Exists(movie.ImagePath))
                picBox.Image = Image.FromFile(movie.ImagePath);

            picBox.Tag = movie.Id;
            */

            panel.Controls.Add(editbutton);
            panel.Controls.Add(picBox);
            panel.Controls.Add(deletebutton);
            panel.Controls.Add(labeldate);
            panel.Controls.Add(labelTitle);
            panel.Controls.Add(labeldescription);
            flowLayoutPanel1.Controls.Add(panel);

        }

        public void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show("Clicked");
        }

        private void adminAnnouncement_Load(object sender, EventArgs e)
        {
            admingetConcernInfo();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminAddAnnouncement frm = new AdminAddAnnouncement();
            frm.ShowDialog();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            admingetConcernInfo();

        }
    }
}
