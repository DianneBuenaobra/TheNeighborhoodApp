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

        public string status { get; set; }
        public void admingetConcernInfo()
        {

            string query = "SELECT AnnouncementId, Announcement, AnnouncementInfo, Image, Date, Status FROM Announcement";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                announcementid = (int)dr.GetValue(0);
                announcementname = (string)dr.GetValue(1);
                announcementdescription = (string)dr.GetValue(2);
                //image
                if (dr[3] != DBNull.Value && dr[5] != DBNull.Value)
                {
                    byte[] img = (byte[])(dr[3]);
                    MemoryStream ms = new MemoryStream(img);
                    image = Image.FromStream(ms);

                    status = (string)dr.GetValue(5);
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
            labelTitle.Location = new Point(207, 61);
            labelTitle.ForeColor = Color.White;
            labelTitle.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Bold);
            labelTitle.AutoSize = true;
            labelTitle.Tag = announcementid;
            labelTitle.MaximumSize = new Size(150, 20);
            labelTitle.MinimumSize = new Size(150, 20);
            


            Label labeldescription;
            labeldescription = new Label();
            labeldescription.Name = String.Format("LblConcernTitle{0}", announcementid);
            labeldescription.Text = announcementdescription;
            labeldescription.Location = new Point(206, 84);
            labeldescription.ForeColor = Color.Black;
            labeldescription.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            labeldescription.AutoSize = true;
            labeldescription.Tag = announcementid;
            labeldescription.MaximumSize = new Size(225, 100);
            labeldescription.MinimumSize = new Size(225, 100);
            labeldescription.BackColor = Color.White;

            Label labeldate;
            labeldate = new Label();
            labeldate.Name = String.Format("LblConcernYear{0}", announcementid);
            labeldate.Text = date.ToString();
            labeldate.Location = new Point(207, 29);
            labeldate.ForeColor = Color.WhiteSmoke;
            labeldate.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            labeldate.Tag = announcementid;

            Label labelstatus;
            labelstatus = new Label();
            labelstatus.Name = String.Format("LblConcernYear{0}", announcementid);
            labelstatus.Text = status;
            labelstatus.Location = new Point(207, 9);
            labelstatus.ForeColor = Color.WhiteSmoke;
            labelstatus.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            labelstatus.Tag = announcementid;
            labeldescription.MaximumSize = new Size(90, 20);
            labeldescription.MinimumSize = new Size(90, 20);
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
            picBox.Size = new Size(198, 185);
            picBox.Location = new Point(3,3);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.BackColor = Color.SteelBlue;
            picBox.Image = image;

            Button editbutton;
            editbutton = new Button();
            editbutton.Name = announcementid.ToString();
            editbutton.Size = new Size(146, 25);
            editbutton.Text = "Edit";
            editbutton.Location = new Point(146, 189);
            editbutton.ForeColor = Color.White;
            editbutton.Font = new Font("Microsoft Sans Serif", 9.5f, FontStyle.Regular);
            editbutton.Tag = announcementid;
            editbutton.Click += new EventHandler(this.button_click);

            Button deletebutton;
            deletebutton = new Button();
            deletebutton.Name = announcementid.ToString();
            deletebutton.Size = new Size(146, 25);
            deletebutton.Text = "delete";
            deletebutton.Location = new Point(1, 189);
            deletebutton.ForeColor = Color.White;
            deletebutton.Font = new Font("Microsoft Sans Serif", 9.5f, FontStyle.Regular);
            deletebutton.Tag = announcementid;
            deletebutton.Click += new EventHandler(this.button1_click);

            Button viewmorebutton;
            viewmorebutton = new Button();
            viewmorebutton.Name = announcementid.ToString();
            viewmorebutton.Size = new Size(146, 25);
            viewmorebutton.Text = "delete";
            viewmorebutton.Location = new Point(291, 189);
            viewmorebutton.ForeColor = Color.White;
            viewmorebutton.Font = new Font("Microsoft Sans Serif", 9.5f, FontStyle.Regular);
            viewmorebutton.Tag = announcementid;
            viewmorebutton.Click += new EventHandler(this.button1_click);
            /*
            if (File.Exists(movie.ImagePath))
                picBox.Image = Image.FromFile(movie.ImagePath);

            picBox.Tag = movie.Id;
            */
            panel.Controls.Add(labelstatus);
            panel.Controls.Add(viewmorebutton);
            panel.Controls.Add(editbutton);
            panel.Controls.Add(picBox);
            panel.Controls.Add(deletebutton);
            panel.Controls.Add(labeldate);
            panel.Controls.Add(labelTitle);
            panel.Controls.Add(labeldescription);
            flowLayoutPanel1.Controls.Add(panel);

        }

        public int buttonclickedid {  get; set; }

        public void button_click(object sender, EventArgs e)
        {
            //edit button
            getAnnouncement();
            Button btn = sender as Button;
            buttonclickedid = Convert.ToInt32(btn.Name);
            if (getstatus() == "Pending")
            {
                FrmEditAnnouncement f = new FrmEditAnnouncement(_userInfo, this);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("You can not edit this Announcement since it is already posted. You can delete it if you have any mistake.");
            }
           
        }
        public void button2_click(object sender, EventArgs e)
        {
            //view more button
            Button btn = sender as Button;
            buttonclickedid = Convert.ToInt32(btn.Name);
            MessageBox.Show("Clicked");
        }
        public void button1_click(object sender, EventArgs e)
        {
            //delete button
            Button btn = sender as Button;
            buttonclickedid = Convert.ToInt32(btn.Name);
            MessageBox.Show("Clicked");
        }

        public void getAnnouncement()
        {
            string query = "SELECT Announcement, AnnouncementInfo, Image, Date, Status FROM Announcement WHERE AnnouncementId = '"+buttonclickedid+"'";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                announcementname = (string)dr.GetValue(0);
                announcementdescription = (string)dr.GetValue(1);
                //image
                if (dr[2] != DBNull.Value && dr[4] != DBNull.Value)
                {
                    byte[] img = (byte[])(dr[2]);
                    MemoryStream ms = new MemoryStream(img);
                    image = Image.FromStream(ms);
                    status = (string)dr.GetValue(4);
                }
                date = (DateTime)dr.GetValue(3);
               
            }
            dr.Close();
        }

        public string getstatus()
        {
            string value = "";
            string query = "SELECT Status FROM Announcement WHERE AnnouncementId = '"+buttonclickedid+"'";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
              
               value = dr.GetValue(0).ToString();
            }
            dr.Close();
            return value;

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
