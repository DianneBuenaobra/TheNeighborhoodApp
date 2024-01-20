using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TheNeighborhoodApp
{
    public partial class UserControlMessages : UserControl
    {
        public UserControlMessages()
        {
            InitializeComponent();
        }
        public void display(int id, string name,string message)
        {
            txtName.Text = name;txtMessage.Text = message;lblmssID.Text = id.ToString();
            //proflepic.Image = image;
        }
        public void setMessageInfo(string message,string sender,string receiver,DateTime date)
        {

        }

        private void UserControlMessages_Click(object sender, EventArgs e)
        {

            FrmMessageInfo info = new FrmMessageInfo();
            info.showDetails(Int32.Parse(lblmssID.Text));
            info.ShowDialog();

            
        }
        

        private void UserControlMessages_Load(object sender, EventArgs e)
        {

        }
    }
}
