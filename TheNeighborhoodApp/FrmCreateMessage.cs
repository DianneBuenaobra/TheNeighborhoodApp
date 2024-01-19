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

                UserControlContacts uccontacts = new UserControlContacts();
                uccontacts.Labels(dr.GetValue(0).ToString() + " " + dr.GetValue(1).ToString(), dr.GetValue(2).ToString());
                flowContacts.Controls.Add(uccontacts);
            }
            cnn.Close();


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

        
       
    }
}
