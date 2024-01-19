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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace TheNeighborhoodApp
{
    public partial class ContactResidentConcern : Form
    {

        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        FrmAdminConcern concernfrm;
        private UserInfo user;

        public ContactResidentConcern(FrmAdminConcern concernfrm, UserInfo user)
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();
            this.concernfrm = concernfrm;
            this.user = user;
        }

        private void ContactResidentConcern_Load(object sender, EventArgs e)
        {
            getConcernInfo();
            lblconcern.Text = concern;
            lbldate.Text = date.ToString();
            lblid.Text = idd.ToString();
            lblname.Text = name.ToString();
           
            

        }

        public string name { get; set; }
        public string username { get; set; }
        public string status { get; set; }
        public int idd { get; set; }
        public string concern { get; set; }
        public string info { get; set; }
        public Image image { get; set; }
        public DateTime date { get; set; }
        public void getConcernInfo()
        {
            string query = "SELECT ConcernId, Concern, ConcernInfo, photo, Date, Name, UserName, ConcernStatus FROM Concern WHERE ConcernId = '" + concernfrm.buttonclickedid + "'";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                idd = (int)dr.GetValue(0);
                concern = (string)dr.GetValue(1);
                info = (string)dr.GetValue(2);
                //image
                if (dr[3] != DBNull.Value)
                {
                    byte[] img = (byte[])(dr[3]);
                    MemoryStream ms = new MemoryStream(img);
                    image = Image.FromStream(ms);

                }
                date = (DateTime)dr.GetValue(4);
                name = dr.GetValue(5).ToString();
                username = dr.GetValue(6).ToString();
                status = (string)dr.GetValue(7);
            }
            dr.Close();
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            insertMessagetoAdmin();
        }

        public void insertMessagetoAdmin()
        {
            DateTime today = DateTime.Today;
            string fullname = user.getFirstname() + " " + user.getLastname();
            int iddd = id();
            string concernMessage = "Concern Id: " + idd.ToString() + " \nConcern: " + lblconcern.Text  + "\n" + txtmessage.Text;
            string query = "INSERT INTO Messages VALUES (@messageid,@sendername,@message,@date,@rname, @userprofile, @susername, @rusername, @mimage)";

            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@messageid", ++iddd);
            cmd.Parameters.AddWithValue("@sendername", "Admin: " + fullname); ;
            cmd.Parameters.AddWithValue("@message", concernMessage);
            cmd.Parameters.AddWithValue("@date", today);
            cmd.Parameters.AddWithValue("@rname", name);
            cmd.Parameters.AddWithValue("@userprofile", getPhoto());
            cmd.Parameters.AddWithValue("@susername", user.getUsername());
            cmd.Parameters.AddWithValue("@rusername", username);
            cmd.Parameters.AddWithValue("@mimage", getPhotonull());



            cmd.ExecuteNonQuery();
            MessageBox.Show("Sent! Please check your inbox for confirmation.");
            this.Close();
        }

        public byte[] getPhotonull()
        {
            MemoryStream stream = new MemoryStream();
            if (pictureBox1 != null && pictureBox1.Image != null)
            {
                pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
            }


            return stream.GetBuffer();
        }
        public byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            if (user.image != null && user.image != null)
            {
                user.image.Save(stream, user.image.RawFormat);
            }


            return stream.GetBuffer();
        }

        public int id()
        {
            int idd = 0;
            string query = "SELECT MAX(MessageID) FROM Messages";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (!Convert.IsDBNull(dr[0]))
                {
                    idd = Convert.ToInt32(dr[0]);
                }
            }

            dr.Close();
            return idd;
        }
    }
}
