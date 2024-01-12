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
    public partial class FrmAdminEditRListVerification : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        UserInfo userInfo = new UserInfo();
        public FrmAdminEditRListVerification()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            con.Open();
            int i = 0;
            string pass = txtPass.Text;
            cmm = new SqlCommand("SELECT * FROM UserInfo WHERE Username = '" + userInfo.getUsername() + "' AND Password = '" + userInfo.getPassword() + "'", con);
            da.SelectCommand = cmm;
            da.Fill(ds, "UserInfo");
            if (ds.Tables[i].Rows.Count > 0)
            {
                if(pass == ds.Tables[i].Rows[i]["Password"].ToString())
                {
                    MessageBox.Show("Access Granted", "Verification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Access Denied. Incorrect Password", "Verification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid Credentials","Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            con.Close();

        }
    }
}
