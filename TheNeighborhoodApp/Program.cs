using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNeighborhoodApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserInfo us = new UserInfo();   
            //displayfrm displayfrm = new displayfrm(us);
            FrmAddConcern frmAddConcern = new FrmAddConcern(us);
            FrmConcernResident frmConcernResident = new FrmConcernResident(us);
            FrmAnnouncement frmAnnouncement = new FrmAnnouncement(us);
        FrmNotification frmNotification = new FrmNotification(us);
            frmlogin frmlogin = new frmlogin(us);
            FrmResidentManageAccount frm = new FrmResidentManageAccount(us);
            FrmHomepage frmhome = new FrmHomepage(us);
            FrmAdminCalendar frmadminCalendar = new FrmAdminCalendar();
            //Application.Run(frmhome);
            //Application.Run(frmAddConcern);
            //Application.Run(frmConcernResident);
           // Application.Run(frmNotification);
            Application.Run(new frmlogin(us));
            //Application.Run(new FrmAdminHomepage(us));
            //Application.Run(frmadminCalendar);
            // Application.Run(new FrmAdminHomepage(us));
           //Application.Run(new FrmMessages(us));
        }
    }
}
