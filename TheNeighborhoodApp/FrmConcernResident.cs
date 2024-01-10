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
            getConcernInfo();
            
        }
        public int concernid
        {
            get; set;
        }
        public string concernname
        {
            get; set;
        }
        public string concerndescription
        {
            get; set;
        }
        public DateTime date
        {
            get; set;
        }
        public string name
        {
            get; set;
        }

        public string username
        {
            get; set;
        }
        public string concernstatus { get; set; }
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

                date = (DateTime)dr.GetValue(4);
                concernstatus = dr.GetValue(5).ToString();

                concernpanels();
            }
            
            MessageBox.Show(concernid.ToString());
            
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
            panel.Tag = concernid;

          
            Label labelTitle;
            labelTitle = new Label();
            labelTitle.Name = String.Format("LblConcernTitle{0}", concernid);
            labelTitle.Text = concernname;
            labelTitle.Location = new Point(14, 40);
            labelTitle.ForeColor = Color.White;
            labelTitle.Font = new Font(this.Font.FontFamily, 9.5f, FontStyle.Bold);
            labelTitle.AutoSize = true;
            labelTitle.Tag = concernid;

            Label labeldescription;
            labeldescription = new Label();
            labeldescription.Name = String.Format("LblConcernTitle{0}", concernid);
            labeldescription.Text = concerndescription;
            labeldescription.Location = new Point(14, 74);
            labeldescription.ForeColor = Color.White;
            labeldescription.Font = new Font(this.Font.FontFamily, 9.5f, FontStyle.Regular);
            labeldescription.AutoSize = true;
            labeldescription.Tag = concernid;

            Label labeldate;
            labeldate = new Label();
            labeldate.Name = String.Format("LblConcernYear{0}", concernid);
            labeldate.Text = date.ToString();
            labeldate.Location = new Point(14, 11);
            labeldate.ForeColor = Color.White;
            labeldate.Font = new Font(this.Font.FontFamily, 9.5f, FontStyle.Regular);
            labeldate.Tag = concernid;

            Label labelstatus;
            labelstatus = new Label();
            labelstatus.Name = String.Format("LblConcernYear{0}", concernid);
            labelstatus.Text = concernstatus;
            labelstatus.Location = new Point(179, 11);
            labelstatus.ForeColor = Color.White;
            labelstatus.Font = new Font(this.Font.FontFamily, 9.5f, FontStyle.Regular);
            labelstatus.Tag = concernid;

            PictureBox picBox;
            picBox = new PictureBox();
            picBox.Name = String.Format("PbconcernImage{0}", concernid);
            picBox.Size = new Size(144, 127);
            picBox.Location = new Point(253, 2);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.BackColor = Color.White;

            Button button;
            button = new Button();
            button.Name=String.Format("PbconcernButton{0}", concernid);
            button.Size = new Size(147, 35);
            button.Text = "Contact Admin";
            button.Location = new Point(253, 127);
            button.ForeColor = Color.White;
            button.Font = new Font(this.Font.FontFamily, 9.5f, FontStyle.Regular);
            button.Tag = concernid;
            /*
            if (File.Exists(movie.ImagePath))
                picBox.Image = Image.FromFile(movie.ImagePath);

            picBox.Tag = movie.Id;
            */
            panel.Controls.Add(button);
            panel.Controls.Add(picBox);
            panel.Controls.Add(labeldate);
            panel.Controls.Add(labelTitle);
            panel.Controls.Add(labeldescription);
            flowLayoutPanel1.Controls.Add(panel);

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
    }
}
