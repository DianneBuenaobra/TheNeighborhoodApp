using System;
using System.Collections;
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
    public partial class FrmCreateMessage : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        

        ArrayList contactNames = new ArrayList();
        ArrayList contactusernames = new ArrayList();
        public FrmCreateMessage()
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
        }
        private void FrmCreateMessage_Load(object sender, EventArgs e)
        {
            getContacts();
        }
        //public string getName { set; get; }
        //public string getUsername { set; get; }
       
        public void getContacts()
        {
            
            contactusernames.Clear();contactNames.Clear();
            cnn.Open();
            cmm = new SqlCommand("Select [First Name],[Last Name], Username from UserInfo where UserType = 'admin'", cnn);
            dr = cmm.ExecuteReader();
            while (dr.Read())
            { 
                contactNames.Add(dr.GetValue(0).ToString() + " " + dr.GetValue(1).ToString());
                contactusernames.Add(dr.GetValue(2).ToString());
                //MessageBox.Show(dr.GetValue(0).ToString() + " " + dr.GetValue(1).ToString());
                //ContactsPanel();
                //ucmessages.Labels(dr.GetValue(0).ToString() + " " + dr.GetValue(1).ToString(), dr.GetValue(2).ToString());
                //flowContacts.Controls.Add(ucmessages);
            }
            cnn.Close();

           for(int i = 0; i < contactNames.Count; i++)
            {
                UserControlMessages ucmessages = new UserControlMessages();
                ucmessages.Labels(contactNames[i].ToString(), contactusernames[i].ToString());

                flowContacts.Controls.Add(ucmessages);
                
            }
        }
/*public void sortContacts(string tb)
        {
            UserControlMessages ucmessages = new UserControlMessages();
            cnn.Open();
            cmm = new SqlCommand("Select [First Name],[Last Name], Username from UserInfo where CONCAT([First Name],[Last Name],username)"
                + "LIKE '%" + tb + "%'", cnn);
            dr = cmm.ExecuteReader();
            while (dr.Read()) {

                ucmessages.Labels(dr.GetValue(0).ToString() + " " + dr.GetValue(1).ToString(), dr.GetValue(2).ToString());
                //ContactsPanel();
            }
        }*/

        private void panel_Click(object sender, EventArgs e)
        {
            //tbContact.Text = flowLayoutPanel1.Click
        }
        /*public void ContactsPanel()
        {
            flowLayoutPanel1.Controls.Clear();
            Panel panel;
            panel = new Panel();
            panel.Name = String.Format("PnlContact{0}", getUsername);
            panel.BackColor = Color.FromKnownColor(KnownColor.GradientInactiveCaption);
            panel.Size = new Size(433, 48); //125, 205
            panel.Margin = new Padding(15);
            panel.Location = new Point(-5, 45);
            panel.Tag = getUsername;
            
            Label labelName;
            labelName = new Label();
            labelName.Name = String.Format("LblName{0}", getUsername);
            labelName.Text = getName;
            labelName.Location = new Point(16, 9);
            labelName.ForeColor = Color.Black;
            labelName.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            labelName.AutoSize = true;
            labelName.Tag = getUsername;
            labelName.MaximumSize = new Size(120, 120);
            labelName.MinimumSize = new Size(120, 120);
            labelName.BackColor = Color.FromKnownColor(KnownColor.GradientInactiveCaption);
            
            

            Label labelUsername;
            labelName = new Label();
            labelName.Name = String.Format("LblUsername{0}", getUsername);
            labelName.Text = getUsername;
            labelName.Location = new Point(16, 20);
            labelName.ForeColor = Color.DarkGray;
            labelName.Font = new Font("Segoe UI", 8.5f, FontStyle.Regular);
            labelName.AutoSize = true;
            labelName.Tag = getUsername;
            labelName.MaximumSize = new Size(120, 120);
            labelName.MinimumSize = new Size(120, 120);
            labelName.BackColor = Color.FromKnownColor(KnownColor.GradientInactiveCaption);

            /*PictureBox picBox;
            picBox = new PictureBox();
            picBox.Name = String.Format("PbconcernImage{0}", announcementid);
            picBox.Size = new Size(304, 140);
            picBox.Location = new Point(0, 0);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.BackColor = Color.SteelBlue;
            picBox.Image = image;

            Button button;
            button = new Button();
            button.Name = announcementid.ToString();
            button.Size = new Size(452, 21);
            button.Text = "View More";
            button.Location = new Point(0, 142);
            button.ForeColor = Color.Black;
            button.BackColor = Color.White;
            button.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
            button.Tag = announcementid;
            button.Click += new EventHandler(this.button_click);
            /*
            if (File.Exists(movie.ImagePath))
                picBox.Image = Image.FromFile(movie.ImagePath);

            picBox.Tag = movie.Id;
            
            
            panel.Controls.Add(labelName);

            
            flowLayoutPanel1.Controls.Add(panel);

        }*/


       
    }
}
