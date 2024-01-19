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
    public partial class AdminViewConcern : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        FrmAdminConcern concernfrm;
        public AdminViewConcern(FrmAdminConcern concernfrm)
        {
            InitializeComponent();
            this.concernfrm = concernfrm;
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();
        }
        public string name { get; set; }
        public string username {  get; set; }
        public string status {  get; set; }
        public int id { get; set; }
        public string concern { get; set; }
        public string info { get; set; }
        public Image image { get; set; }
        public DateTime date { get; set; }  

        private void AdminViewConcern_Load(object sender, EventArgs e)
        {
            getConcernInfo();
            lbldate.Text = date.ToString();
            lblid.Text = id.ToString();
            lblname.Text = name.ToString();
            comboBox1.SelectedItem = status;
            txttitle.Text = concern;
            txtdescription.Text = info;
            pictureBox1.Image = image;
            lblusername.Text = username;
            donebtn.Text = "Done";

        }

        public void getConcernInfo()
        {
            string query = "SELECT ConcernId, Concern, ConcernInfo, photo, Date, Name, UserName, ConcernStatus FROM Concern WHERE ConcernId = '"+concernfrm.buttonclickedid+"'";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                id = (int)dr.GetValue(0);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            donebtn.Text = "Update";
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Submitted" || comboBox1.SelectedItem == null)
            {
                this.Close();
            }
            else
            {
                updateconcernStatus();
                MessageBox.Show("Successfully updated!");
            }
        }

        public void updateconcernStatus()
        {
            string query = "UPDATE Concern SET ConcernStatus = @status WHERE ConcernId = '"+concernfrm.buttonclickedid +"'";
            SqlCommand cmd = new SqlCommand(query, cnn);

            cmd.Parameters.AddWithValue("@status", comboBox1.SelectedItem);
            
            cmd.ExecuteNonQuery();
        }
    }
}
