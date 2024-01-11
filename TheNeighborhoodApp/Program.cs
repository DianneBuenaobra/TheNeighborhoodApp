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
            displayfrm displayfrm = new displayfrm(us);
            FrmAddConcern frmAddConcern = new FrmAddConcern(us);
            FrmConcernResident frmConcernResident = new FrmConcernResident(us);
            //Application.Run(FrmHomepage(us));
            //Application.Run(frmAddConcern);
            //Application.Run(frmConcernResident);
            Application.Run(displayfrm);
            //Application.Run(new FrmAdminHomepage());
        }
    }
}
