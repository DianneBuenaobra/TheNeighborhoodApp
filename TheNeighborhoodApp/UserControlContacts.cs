using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNeighborhoodApp
{
    public partial class UserControlContacts : UserControl
    {
        private UserInfo uc;
        public UserControlContacts(UserInfo uc)
        {
            InitializeComponent();
            this.uc = uc;
        }
        public void Labels(string name, string username)
        {
            lblName.Text = name + ""; lblUsername.Text = username + "";
            //MessageBox.Show( name + "-" + lblName.Text);
        }

        private void UserControlContacts_Click(object sender, EventArgs e)
        {
            //FrmCreateMessage create = new FrmCreateMessage();
            //create.getContact(lblName.Text,lblUsername.Text);
            NewMessage newmessage = new NewMessage(uc);
            newmessage.getReceiver(lblUsername.Text,lblName.Text);
            newmessage.ShowDialog();
        }
        
    }
}
