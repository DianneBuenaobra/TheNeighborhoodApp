﻿using System;
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
            btnMenu.Visible = false;
            btnBack.Visible = true;

        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            menuList.Visible = false;
            btnMenu.Visible = true; 
        }
        /*public void showResidentList()
        {
            FrmAdminResidentsList rlist = new FrmAdminResidentsList();
            rlist.BringToFront();
            rlist.TopLevel = false;
            AdminNF.Controls.Add(rlist);
            rlist.Show();
        }*/

        private void btnRList_Click(object sender, EventArgs e)
        {
            menuList.Visible = false;
            btnMenu.Visible = true;
            rlist.TopLevel = false;
            AdminNF.Controls.Add(rlist);rlist.Show();
        }
    }
}
