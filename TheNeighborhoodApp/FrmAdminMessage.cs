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
    public partial class FrmAdminMessage : Form
    {

        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public FrmAdminMessage()
        {
            cnn = new SqlConnection(dbcon.MyConnection());
            InitializeComponent();
        }

        private void FrmAdminMessage_Load(object sender, EventArgs e)
        {
            getMessage();
        }
        public string SenderName { get; set; }
        public string UserMessage { get; set; }
        public string DateSent { get; set; }
        public string UserProfile { get; set; }public string Username { get; set; }

        public void getMessage()
        {
            cnn.Open();
            cmm = new SqlCommand("Select * from Messages",cnn);
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
                Username = (string)dr.GetValue(6);
                SenderName = (string)dr.GetValue(1);
                UserMessage = (string)dr.GetValue(2);
                DateSent = dr.GetValue(3).ToString() ;
                //UserProfile = (string)dr.GetValue(5);
                Messagepanels();
            }
            dr.Close();
            cnn.Close();
        }
        public void Messagepanels()
        {

            Panel panel;
            panel = new Panel();
            panel.Name = String.Format("PanelMessage{0}", Username);
            panel.BackColor = Color.SteelBlue;
            panel.Size = new Size(484, 65); //125, 205
            panel.Margin = new Padding(15);
            panel.Location = new Point(8, 45);
            panel.Tag = Username;


            Label LabelName;
            LabelName = new Label();
            LabelName.Name = String.Format("LblName{0}", Username);
            LabelName.Text = SenderName;
            LabelName.Location = new Point(72, 5);
            LabelName.ForeColor = Color.White;
            LabelName.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            LabelName.AutoSize = false;
            LabelName.Size = new Size(321, 17);
            LabelName.Tag = Username;
            LabelName.MaximumSize = new Size(240, 40);
            LabelName.MinimumSize = new Size(230, 30);


            Label labelmessage;
            labelmessage = new Label();
            labelmessage.Name = String.Format("lblMessage{0}", Username);
            labelmessage.Text = UserMessage;
            labelmessage.Location = new Point(78, 24);
            labelmessage.ForeColor = Color.Black;
            labelmessage.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            labelmessage.AutoSize = false;
            labelmessage.Size = new Size(396, 33);
            labelmessage.Tag = Username;
            labelmessage.MaximumSize = new Size(230, 75);
            labelmessage.MinimumSize = new Size(230, 75);
            labelmessage.BackColor = Color.White;

            Label labeldate;
            labeldate = new Label();
            labeldate.Name = String.Format("lblDate{0}", Username);
            labeldate.Text = DateSent.ToString();
            labeldate.Location = new Point(411, 3);
            labelmessage.AutoSize = false;
            labelmessage.Size = new Size(70, 19);
            labeldate.ForeColor = Color.WhiteSmoke;
            labeldate.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            labeldate.Tag = Username;

            PictureBox picBox;
            picBox = new PictureBox();
            picBox.Name = String.Format("ProfilePic{0}", Username);
            picBox.Size = new Size(63, 59);
            picBox.Location = new Point(3, 3);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.BackColor = Color.White;

          
            /*
            if (File.Exists(movie.ImagePath))
                picBox.Image = Image.FromFile(movie.ImagePath);

            picBox.Tag = movie.Id;
            */
            panel.Controls.Add(picBox);
            panel.Controls.Add(labelmessage);
            panel.Controls.Add(labeldate);
            panel.Controls.Add(LabelName);
            flowLayoutPanel1.Controls.Add(panel);

        }

        
    }
}
