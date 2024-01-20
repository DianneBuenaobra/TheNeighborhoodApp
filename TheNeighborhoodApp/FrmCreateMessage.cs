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

        private UserInfo _userinfo;
        private string contactName, contactUsername;
        ArrayList contactNames = new ArrayList();
        ArrayList contactusernames = new ArrayList();
        public FrmCreateMessage(UserInfo userinfo)
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            this._userinfo = userinfo;
        }
        private void FrmCreateMessage_Load(object sender, EventArgs e)
        {
            if (_userinfo.getUserType().Equals("admin"))
            {
                getContactsAdmin();
            }
            else
            {
                getContacts();
            }
            getContacts();
            
        }
        //public string getName { set; get; }
        //public string getUsername { set; get; }

        public void getContacts()
        {
            contactusernames.Clear(); contactNames.Clear();
            cnn.Open();
            cmm = new SqlCommand("Select [First Name],[Last Name], Username from UserInfo where UserType = 'admin'", cnn);
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {

                UserControlContacts uccontacts = new UserControlContacts(_userinfo);
                uccontacts.Labels(dr.GetValue(0).ToString() + " " + dr.GetValue(1).ToString(), dr.GetValue(2).ToString());
                flowContacts.Controls.Add(uccontacts);
            }
            cnn.Close();


        }
        public void getContactsAdmin()
        {
            contactusernames.Clear(); contactNames.Clear();
            cnn.Open();
            cmm = new SqlCommand("Select [First Name],[Last Name], Username from UserInfo", cnn);
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {

                UserControlContacts uccontacts = new UserControlContacts(_userinfo);
                uccontacts.Labels(dr.GetValue(0).ToString() + " " + dr.GetValue(1).ToString(), dr.GetValue(2).ToString());
                flowContacts.Controls.Add(uccontacts);
            }
            cnn.Close();


        }


        private void tbContact_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void getContact(string name, string username)
        {
            UserControlContacts contacts = new UserControlContacts(_userinfo);

            this.contactUsername = username;
            

            //.getName(contactName);contacts.getUsername(contactUsername);
           
            //tbContact.Text = contactUsername;
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
