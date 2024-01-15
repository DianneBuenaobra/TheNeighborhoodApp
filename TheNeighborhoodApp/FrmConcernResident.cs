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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Input;

namespace TheNeighborhoodApp
{
    public partial class FrmConcernResident : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        private UserInfo _userInfo;
        public FrmConcernResident(UserInfo userinfo)
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();

            _userInfo = userinfo;
        }

        private void Edit_DoubleClick(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            getConcernInfo();
            comboBox1.SelectedItem = "All";
        }

        public int concernid { get; set;}
        public string concernname{get; set;}
        public string concerndescription{get; set;}
        public DateTime date{get; set;}
        public string name{get; set;}
        public string username{get; set;}
        public string concernstatus { get; set; }
        public Image image { get; set; }

        public int buttonclickedid { get; set;}
        public void getConcernInfo()
        {
            

            string query = "SELECT ConcernId, Concern, ConcernInfo, photo, date, ConcernStatus FROM Concern WHERE Username = '" + _userInfo.getUsername().ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                concernid = (int)dr.GetValue(0);
                concernname = (string)dr.GetValue(1);
                concerndescription = (string)dr.GetValue (2);
                //image
                byte[] img = (byte[])(dr[3]);
                MemoryStream ms = new MemoryStream(img);
                image = Image.FromStream(ms);

                date = (DateTime)dr.GetValue(4);
                concernstatus = dr.GetValue(5).ToString();

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
            panel.Size = new Size(400, 162); //125, 205
            panel.Margin = new Padding(15);
            panel.Location = new Point(15, 50);
            panel.Tag = concernid;

          
            Label labelTitle;
            labelTitle = new Label();
            labelTitle.Name = String.Format("LblConcernTitle{0}", concernid);
            labelTitle.Text = concernname;
            labelTitle.Location = new Point(11, 40);
            labelTitle.ForeColor = Color.White;
            labelTitle.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Bold);
            labelTitle.AutoSize = true;
            labelTitle.Tag = concernid;
            labelTitle.MaximumSize = new Size(240, 40);
            labelTitle.MinimumSize = new Size(230, 30);
          

            Label labeldescription;
            labeldescription = new Label();
            labeldescription.Name = String.Format("LblConcernTitle{0}", concernid);
            labeldescription.Text = concerndescription;
            labeldescription.Location = new Point(10, 75);
            labeldescription.ForeColor = Color.Black;
            labeldescription.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            labeldescription.AutoSize = true;
            labeldescription.Tag = concernid;
            labeldescription.MaximumSize = new Size(230, 75);
            labeldescription.MinimumSize = new Size(230, 75);
            labeldescription.BackColor = Color.White;

            Label labeldate;
            labeldate = new Label();
            labeldate.Name = String.Format("LblConcernYear{0}", concernid);
            labeldate.Text = date.ToString();
            labeldate.Location = new Point(10, 11);
            labeldate.ForeColor = Color.WhiteSmoke;
            labeldate.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            labeldate.Tag = concernid;

            Label labelstatus;
            labelstatus = new Label();
            labelstatus.Name = String.Format("LblConcernStatus{0}", concernid);
            labelstatus.Text = concernstatus;
            labelstatus.Location = new Point(187, 10);
            labelstatus.ForeColor = Color.WhiteSmoke;
            labelstatus.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            labelstatus.Tag = concernid;

            PictureBox picBox;
            picBox = new PictureBox();
            picBox.Name = String.Format("PbconcernImage{0}", concernid);
            picBox.Size = new Size(145, 139);
            picBox.Location = new Point(255, -1);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.BackColor = Color.SteelBlue;
            picBox.Image = image;

            Button button;
            button = new Button();
            button.Name = concernid.ToString();
            button.Size = new Size(145, 26);
            button.Text = "Contact Admin";
            button.Location = new Point(255, 136);
            button.ForeColor = Color.White;
            button.Font = new Font("Microsoft Sans Serif", 9.5f, FontStyle.Regular);
            button.Tag = concernid;
            button.Click += new EventHandler(this.button_click);
            /*
            if (File.Exists(movie.ImagePath))
                picBox.Image = Image.FromFile(movie.ImagePath);

            picBox.Tag = movie.Id;
            */
            
            panel.Controls.Add(button);
            panel.Controls.Add(picBox);
            panel.Controls.Add(labelstatus);
            panel.Controls.Add(labeldate);
            panel.Controls.Add(labelTitle);
            panel.Controls.Add(labeldescription);
            flowLayoutPanel1.Controls.Add(panel);

        }

        public void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            buttonclickedid = Convert.ToInt32(btn.Name);
            MessageBox.Show(buttonclickedid.ToString());
            ConcernContactAdmin c = new ConcernContactAdmin(this, _userInfo);
            c.ShowDialog();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddConcern frm = new FrmAddConcern(_userInfo);
            frm.ShowDialog();
        }

        private void FrmConcernResident_Load(object sender, EventArgs e)
        {
          
            getConcernInfo();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if ((string)comboBox1.SelectedItem == "All")
            {
                getConcernInfo();
            }
            else
            {
                getfilterConcern();
            }
            
            
        }
       public string filterValue { get; set; }
        public void getfilterConcern()
        {
            filterValue = comboBox1.SelectedItem.ToString();
            string query = "Select ConcernId, Concern, ConcernInfo, photo, date, ConcernStatus FROM Concern WHERE ConcernStatus = '" + filterValue + "'";

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

                concernpanels();
            }
            dr.Close();


        }
        /*
        private void timer1_Tick(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            getConcernInfo();
        }
        */
    }
}
