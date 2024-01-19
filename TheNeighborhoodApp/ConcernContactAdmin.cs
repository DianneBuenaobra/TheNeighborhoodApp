using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace TheNeighborhoodApp
{
    public partial class ConcernContactAdmin : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        FrmConcernResident frm;
        UserInfo _userinfo;
        public ConcernContactAdmin(FrmConcernResident form, UserInfo userinfo)
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();

            frm = form;
            _userinfo = userinfo;
        }

        private void ConcernContactAdmin_Load(object sender, EventArgs e)
        {
            getConcern();
        }

        public void getConcern()
        {
            string query = "SELECT Concern, ConcernStatus FROM Concern WHERE ConcernId = '"+ frm.buttonclickedid+"'";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblconcern.Text = dr.GetValue(0).ToString();
                lblConcernStatus.Text = dr.GetValue(1).ToString();
             
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertMessagetoAdmin();
        }

        public void insertMessagetoAdmin()
        {
            int idd = id();
            Image image = _userinfo.image;
            DateTime today = DateTime.Today;
            string fullname = _userinfo.getFirstname() + " " + _userinfo.getLastname();
            string concernMessage = "Concern Id: "+ frm.buttonclickedid.ToString() +" \nConcern: " + lblconcern.Text + "\nStatus: " + lblConcernStatus.Text + "\n" + txtmessage.Text;
            string query = "INSERT INTO Messages VALUES (@messageid,@sendername,@message,@date,@rname, @userprofile, @susername, @rusername, @mimage)";

            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@messageid", ++idd);
            cmd.Parameters.AddWithValue("@sendername", fullname);
            cmd.Parameters.AddWithValue("@message", concernMessage);
            cmd.Parameters.AddWithValue("@date", today);
            cmd.Parameters.AddWithValue("@rname", "Admin");
            cmd.Parameters.AddWithValue("@userprofile", getPhoto());
            cmd.Parameters.AddWithValue("@susername", _userinfo.getUsername());
            cmd.Parameters.AddWithValue("@rusername", "Admin");
            cmd.Parameters.AddWithValue("@mimage", getPhotonull());


            cmd.ExecuteNonQuery();
            MessageBox.Show("Sent! Please check your inbox for confirmation.");
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
            if (_userinfo.image != null && _userinfo.image != null)
            {
                _userinfo.image.Save(stream, _userinfo.image.RawFormat);
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
