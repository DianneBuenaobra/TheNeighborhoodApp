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
            insertMessage();
        }

        public void insertMessage()
        {
            DateTime today = DateTime.Today;
            string fullname = _userinfo.getFirstname() + " " + _userinfo.getLastname();
            string concernMessage = "Concern Id: "+ frm.buttonclickedid.ToString() +" \nConcern: " + lblconcern.Text + "\nStatus: " + lblConcernStatus.Text + "\n" + txtmessage.Text;
            string query = "INSERT INTO Messages VALUES (@messageid,@sendername,@message,@date,@rname, @userprofile, @username)";

            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@messageid", id());
            cmd.Parameters.AddWithValue("@sendername", fullname);
            cmd.Parameters.AddWithValue("@message", concernMessage);
            cmd.Parameters.AddWithValue("@date", today);
            cmd.Parameters.AddWithValue("@rname", "Admin");
            cmd.Parameters.AddWithValue("@userprofile", "");
            cmd.Parameters.AddWithValue("@username", _userinfo.getUsername());
           

            cmd.ExecuteNonQuery();
            MessageBox.Show("Sent! Please check your inbox for confirmation.");
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
