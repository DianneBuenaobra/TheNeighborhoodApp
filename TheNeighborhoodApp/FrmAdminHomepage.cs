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
        FrmAdminMenu menu = new FrmAdminMenu();
        FrmAdminResidentsList rlist = new FrmAdminResidentsList();
        public FrmAdminHomepage()
        {
            InitializeComponent();
        }

        private void FrmAdminHomepage_Load(object sender, EventArgs e)
        {







          
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuList.Visible = true;
            btnBack.Visible = true;
         
            
            menu.TopLevel = false;
            menuList.Controls.Add(menu);
            menu.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminNF.Visible = false;
        }
        public void residentsListClick()
        {
            menuList.Visible = false;menu.Close();
            rlist.TopLevel = false;
            AdminNF.Controls.Add(rlist);rlist.Show();
            
        }
    }
}
