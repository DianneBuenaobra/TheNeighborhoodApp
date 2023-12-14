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
    public partial class FrmAdminHomepage : Form
    {
        public FrmAdminHomepage()
        {
            InitializeComponent();
        }

        private void FrmAdminHomepage_Load(object sender, EventArgs e)
        {







          
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            btnBack.Visible = true;
         
            FrmAdminMenu frm = new FrmAdminMenu();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
