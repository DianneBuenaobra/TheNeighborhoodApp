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
        public UserControlContacts()
        {
            InitializeComponent();
        }
        public void Labels(string name, string username)
        {
            lblName.Text = name + ""; lblUsername.Text = username + "";
            //MessageBox.Show( name + "-" + lblName.Text);
        }

    }
}
