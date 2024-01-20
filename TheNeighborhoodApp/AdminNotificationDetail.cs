using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace TheNeighborhoodApp
{
    public partial class AdminNotificationDetail : Form
    {

        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        UserInfo user;
        UserControlNotification uc;
        public AdminNotificationDetail(UserControlNotification uc)
        {
            InitializeComponent();
            this.uc = uc;
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();
        }

        private void AdminNotificationDetail_Load(object sender, EventArgs e)
        {
            lblname.Text = uc.name;
            lblage.Text = uc.age.ToString();
            lblgender.Text = uc.gender;
            lblnumber.Text = uc.number;
            pictureBox1.Image = uc.image;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //verify
            DialogResult result =MessageBox.Show("Are you sure you want to verify the user?", "Verify User?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                VerifyUser();
            }
            this.Close();
           
        }

        public void VerifyUser()
        {
            string query = "UPDATE UserInfo SET Verified = 'yes' WHERE Username = '"+uc.Name+"'";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Verified!");

        }

        public void DeleteUser()
        {
            string query = "DELETE FROM UserInfo WHERE  Username = '" + uc.Name + "'";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Declined and deleted!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //decline

            DialogResult result = MessageBox.Show("Are you sure you want to decline the user? User will be permanently removed from the system after declining.", "Decline User?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DeleteUser();
            }
            this.Close();

        }

    }
}
