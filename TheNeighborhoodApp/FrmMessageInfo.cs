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
    public partial class FrmMessageInfo : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection(); SqlDataReader dr;
        public FrmMessageInfo()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
        }
        public void showDetails(int id)
        {
            con.Open();
            cmm = new SqlCommand("Select SenderName, Message,Date,ReceiverName from messages where messageID = " + id, con);
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
                lblDateSent.Text = dr.GetValue(2).ToString();
                lblSender.Text = dr.GetValue(0).ToString();
                lblReceiver.Text = dr.GetValue(3).ToString();
                lblMessage.Text = dr.GetValue(1).ToString();
            }
            dr.Close();
            con.Close();
        }
    }
}
