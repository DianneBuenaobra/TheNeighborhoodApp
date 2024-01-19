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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TheNeighborhoodApp
{
    public partial class FrmAdminConcern : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        public FrmAdminConcern()
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();
        }
        public int concernid { get; set; }
        public string concern { get; set; }
        public string concerninfo { get; set; }
        public DateTime date { get; set; }
        public string name { get; set; }
        public string username { get; set; }

        public Image image { get; set; }

        public string status { get; set; }

        public string ResidentName { get; set; }

        public string residentUsername { get; set; }
        public void admingetConcernInfo()
        {

            string query = "SELECT ConcernId, Concern, ConcernInfo, photo, Name, UserName, date, ConcernStatus FROM Concern";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                concernid = (int)dr.GetValue(0);
                concern = (string)dr.GetValue(1);
                concerninfo = (string)dr.GetValue(2);
                //image
                if (dr[3] != DBNull.Value)
                {
                    byte[] img = (byte[])(dr[3]);
                    MemoryStream ms = new MemoryStream(img);
                    image = Image.FromStream(ms);

                }
                ResidentName = dr.GetValue(4).ToString();
                residentUsername = dr.GetValue(5).ToString();
                date = (DateTime)dr.GetValue(6);
                status = (string)dr.GetValue(7);

                concernpanels();
            }
            dr.Close();
        }
        public void concernpanels()
        {

            Panel panel;
            panel = new Panel();
            panel.Name = String.Format("PnlConcern{0}", concernid);
            panel.BackColor = Color.SteelBlue;
            panel.Size = new Size(438, 217);
            panel.Margin = new Padding(20);
            panel.Location = new Point(20, 20);
            panel.Tag = concernid;


            Label labelTitle;
            labelTitle = new Label();
            labelTitle.Name = String.Format("LblConcernTitle{0}", concernid);
            labelTitle.Text = "Title: " + concern;
            labelTitle.Location = new Point(207, 61);
            labelTitle.ForeColor = Color.White;
            labelTitle.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Bold);
            labelTitle.AutoSize = true;
            labelTitle.Tag = concernid;
            labelTitle.MaximumSize = new Size(150, 20);
            labelTitle.MinimumSize = new Size(150, 20);



            Label labeldescription;
            labeldescription = new Label();
            labeldescription.Name = String.Format("LblConcernTitle{0}", concernid);
            labeldescription.Text = concerninfo;
            labeldescription.Location = new Point(213, 84);
            labeldescription.ForeColor = Color.Black;
            labeldescription.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            labeldescription.Tag = concernid;
            labeldescription.MaximumSize = new Size(220, 95);
            labeldescription.MinimumSize = new Size(220, 95);
            labeldescription.BackColor = Color.White;

            Label labeldate;
            labeldate = new Label();
            labeldate.Name = String.Format("LblConcernYear{0}", concernid);
            labeldate.Text = "Date: " + date.ToString();
            labeldate.Location = new Point(207, 29);
            labeldate.ForeColor = Color.WhiteSmoke;
            labeldate.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            labeldate.Tag = concernid;

            Label labelstatus;
            labelstatus = new Label();
            labelstatus.Name = String.Format("LblConcernYear{0}", concernid);
            labelstatus.Text = "Status: " + status.ToString();
            labelstatus.Location = new Point(207, 9);
            labelstatus.ForeColor = Color.WhiteSmoke;
            labelstatus.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            labelstatus.Tag = concernid;
            labeldescription.MaximumSize = new Size(90, 20);
            labeldescription.MinimumSize = new Size(90, 20);


            Label labelid;
            labelid = new Label();
            labelid.Name = String.Format("LblConcernStatus{0}", concernid);
            labelid.Text = "ID: " + concernid.ToString();
            labelid.Location = new Point(368, 9);
            labelid.ForeColor = Color.WhiteSmoke;
            labelid.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            labelid.Tag = concernid;
            labelid.MaximumSize = new Size(60, 20);

            PictureBox picBox;
            picBox = new PictureBox();
            picBox.Name = String.Format("PbconcernImage{0}", concernid);
            picBox.Size = new Size(198, 185);
            picBox.Location = new Point(3, 3);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.BackColor = Color.SteelBlue;
            picBox.Image = image;

            System.Windows.Forms.Button editbutton;
            editbutton = new System.Windows.Forms.Button();
            editbutton.Name = concernid.ToString();
            editbutton.Size = new Size(219, 25);
            editbutton.Text = "View";
            editbutton.Location = new Point(218, 189);
            editbutton.ForeColor = Color.White;
            editbutton.Font = new Font("Microsoft Sans Serif", 9.5f, FontStyle.Regular);
            editbutton.Tag = concernid;
            editbutton.Click += new EventHandler(this.button_click);

            System.Windows.Forms.Button deletebutton;
            deletebutton = new System.Windows.Forms.Button();
            deletebutton.Name = concernid.ToString();
            deletebutton.Size = new Size(219, 25);
            deletebutton.Text = "Contact Resident";
            deletebutton.Location = new Point(1, 189);
            deletebutton.ForeColor = Color.White;
            deletebutton.Font = new Font("Microsoft Sans Serif", 9.5f, FontStyle.Regular);
            deletebutton.Tag = concernid;
            deletebutton.Click += new EventHandler(this.button1_click);
            /*
            Button viewmorebutton;
            viewmorebutton = new Button();
            viewmorebutton.Name = announcementid.ToString();
            viewmorebutton.Size = new Size(146, 25);
            viewmorebutton.Text = "View More";
            viewmorebutton.Location = new Point(291, 189);
            viewmorebutton.ForeColor = Color.White;
            viewmorebutton.Font = new Font("Microsoft Sans Serif", 9.5f, FontStyle.Regular);
            viewmorebutton.Tag = announcementid;
            viewmorebutton.Click += new EventHandler(this.button2_click);
            */
            /*
            if (File.Exists(movie.ImagePath))
                picBox.Image = Image.FromFile(movie.ImagePath);

            picBox.Tag = movie.Id;
            */
            panel.Controls.Add(labelid);
            panel.Controls.Add(labelstatus);
            // panel.Controls.Add(viewmorebutton);
            panel.Controls.Add(editbutton);
            panel.Controls.Add(picBox);
            panel.Controls.Add(deletebutton);
            panel.Controls.Add(labeldate);
            panel.Controls.Add(labelTitle);
            panel.Controls.Add(labeldescription);
            flowLayoutPanel1.Controls.Add(panel);

        }

        public int buttonclickedid { get; set; }

        public void button_click(object sender, EventArgs e)
        {
            //view button
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            buttonclickedid = Convert.ToInt32(btn.Name);
            AdminViewConcern frm = new AdminViewConcern(this);
            frm.ShowDialog();
 
        }
        public void button1_click(object sender, EventArgs e)
        {
            //contact resident button
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            buttonclickedid = Convert.ToInt32(btn.Name);

        }

        private void FrmAdminConcern_Load(object sender, EventArgs e)
        {
            admingetConcernInfo();
        }
    }
}
