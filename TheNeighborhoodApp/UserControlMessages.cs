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
    public partial class UserControlMessages : UserControl
    {
        public UserControlMessages()
        {
            InitializeComponent();
        }
        public void display(string name,string message)
        {
            txtName.Text = name;txtMessage.Text = message;
            //proflepic.Image = image;
        }
        public void setMessageInfo(string message,string sender,string receiver,DateTime date)
        {

        }

        private void UserControlMessages_Click(object sender, EventArgs e)
        {
            FrmChat details = new FrmChat();
            
            details.ShowDialog();
        }

        private void UserControlMessages_Load(object sender, EventArgs e)
        {

        }
    }
}
