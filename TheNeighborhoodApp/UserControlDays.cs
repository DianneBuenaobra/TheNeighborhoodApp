using System;
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
    public partial class UserControlDays : UserControl
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        SqlDataReader dr;
        DBConnection db = new DBConnection();
        FrmAdminCalendar calendar = new FrmAdminCalendar();
        string eventname;

        //private string lbl;
        public UserControlDays()
        {
            InitializeComponent();
            cnn = new SqlConnection(db.MyConnection());



            
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

       
    }
}
