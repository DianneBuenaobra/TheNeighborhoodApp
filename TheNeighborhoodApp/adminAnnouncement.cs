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
        public int concernid { get; set; }
        public string concernname { get; set; }
        public string concerndescription { get; set; }
        public DateTime date { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string concernstatus { get; set; }

        public void admingetConcernInfo()
        {

            string query = "SELECT ConcernId, Concern, ConcernInfo, photo, date, ConcernStatus FROM Concern";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                concernid = (int)dr.GetValue(0);
                concernname = (string)dr.GetValue(1);
                concerndescription = (string)dr.GetValue(2);
                //image
                date = (DateTime)dr.GetValue(4);
                concernstatus = dr.GetValue(5).ToString();

                adminconcernpanels();
            }
            dr.Close();
        }

        public void adminconcernpanels()
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
            labelTitle.Text = concernname;
            labelTitle.Location = new Point(227, 36);
            labelTitle.ForeColor = Color.White;
            labelTitle.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Bold);
            labelTitle.AutoSize = true;
            labelTitle.Tag = concernid;
            labelTitle.MaximumSize = new Size(140, 20);
            labelTitle.MinimumSize = new Size(140, 20);
            


            Label labeldescription;
            labeldescription = new Label();
            labeldescription.Name = String.Format("LblConcernTitle{0}", concernid);
            labeldescription.Text = concerndescription;
            labeldescription.Location = new Point(227, 65);
            labeldescription.ForeColor = Color.Black;
            labeldescription.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            labeldescription.AutoSize = true;
            labeldescription.Tag = concernid;
            labeldescription.MaximumSize = new Size(200, 120);
            labeldescription.MinimumSize = new Size(200, 120) ;
            labeldescription.BackColor = Color.White;

            Label labeldate;
            labeldate = new Label();
            labeldate.Name = String.Format("LblConcernYear{0}", concernid);
            labeldate.Text = date.ToString();
            labeldate.Location = new Point(227, 12);
            labeldate.ForeColor = Color.WhiteSmoke;
            labeldate.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            labeldate.Tag = concernid;
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
            picBox.Name = String.Format("PbconcernImage{0}", concernid);
            picBox.Size = new Size(218, 185);
            picBox.Location = new Point(3,3);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.BackColor = Color.White;

            Button editbutton;
            editbutton = new Button();
            editbutton.Name = String.Format("PbconcernButton{0}", concernid);
            editbutton.Size = new Size(221, 23);
            editbutton.Text = "Edit";
            editbutton.Location = new Point(0, 194);
            editbutton.ForeColor = Color.White;
            editbutton.Font = new Font("Microsoft Sans Serif", 9.5f, FontStyle.Regular);
            editbutton.Tag = concernid;
            editbutton.Click += new EventHandler(this.button_click);

            Button deletebutton;
            deletebutton = new Button();
            deletebutton.Name = String.Format("PbconcernButton{0}", concernid);
            deletebutton.Size = new Size(221, 23);
            deletebutton.Text = "delete";
            deletebutton.Location = new Point(217, 194);
            deletebutton.ForeColor = Color.White;
            deletebutton.Font = new Font("Microsoft Sans Serif", 9.5f, FontStyle.Regular);
            deletebutton.Tag = concernid;
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
    }
}
