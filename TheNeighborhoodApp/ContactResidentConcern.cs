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
    public partial class ContactResidentConcern : Form
    {

        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        private AdminViewConcern view;
        private UserInfo user;

        public ContactResidentConcern(AdminViewConcern view, UserInfo user)
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();
            this.view = view;
            this.user = user;
        }

        private void ContactResidentConcern_Load(object sender, EventArgs e)
        {
            lblconcern.Text = view.concern;
            lbldate.Text = view.date.ToString();
            lblid.Text = view.id.ToString();
            lblname.Text = view.name.ToString();
            

        }

        private void sendbtn_Click(object sender, EventArgs e)
        {

        }

        public void insertMessagetoAdmin()
        {
            DateTime today = DateTime.Today;
            string fullname = user.getFirstname() + " " + user.getLastname();
            int idd = id();
            string concernMessage = "Concern Id: " + view.id + " \nConcern: " + lblconcern.Text  + "\n" + txtmessage.Text;
            string query = "INSERT INTO Messages VALUES (@messageid,@sendername,@message,@date,@rname, @userprofile, @username)";

            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@messageid", idd++);
            cmd.Parameters.AddWithValue("@sendername", "Admin: " +fullname);
            cmd.Parameters.AddWithValue("@message", concernMessage);
            cmd.Parameters.AddWithValue("@date", today);
            cmd.Parameters.AddWithValue("@rname", view.name);
            cmd.Parameters.AddWithValue("@userprofile", "");
            cmd.Parameters.AddWithValue("@username", view.username);


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
