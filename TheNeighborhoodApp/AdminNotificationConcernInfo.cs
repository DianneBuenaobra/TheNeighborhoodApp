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
    public partial class AdminNotificationConcernInfo : Form
    {
        private UserControlNotificationControl notifInfo;
        public AdminNotificationConcernInfo(UserControlNotificationControl notifInfo)
        {
            InitializeComponent();
            this.notifInfo = notifInfo;
        }

        private void AdminNotificationConcernInfo_Load(object sender, EventArgs e)
        {

            lblname.Text = notifInfo.cname;
            lblconcerninfo.Text = notifInfo.concerninfo;
            lblconcern.Text = notifInfo.concern;
        }
    }
}
