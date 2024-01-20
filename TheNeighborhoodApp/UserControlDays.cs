using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNeighborhoodApp
{
    public partial class UserControlDays : UserControl
    {
        string eventname;
        FrmAdminCalendar calendar = new FrmAdminCalendar();

        //private string lbl;
        public UserControlDays()
        {
            InitializeComponent();
           
        }
        //public string labels { set { lbl = value; } get => lbl; }
        public void eventLabel(string name){
            eventname = name;
            label1.Text = eventname;
        }
        public void Dates(int num)
        {
            txtDate.Text = num + "";
        }
        
        private void UserControlDays_Load(object sender, EventArgs e)
        {
            
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            

            calendar.DisplayInfo(label1.Text);
            
        }
        
        
    }
}
