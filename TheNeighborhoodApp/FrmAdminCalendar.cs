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
    public partial class FrmAdminCalendar : Form
    {
        public FrmAdminCalendar()
        {
            InitializeComponent();
        }
       
        private void FrmAdminCalendar_Load(object sender, EventArgs e)
        {
            DisplayDay();
        }
        private void DisplayDay()
        {
            
            DateTime now = DateTime.Now;
            
            DateTime startofMonth = new DateTime(now.Year, 1, now.Month);
            int totalDays = DateTime.DaysInMonth(now.Year, now.Month);
            int startoftheWeek = Convert.ToInt32(startofMonth.DayOfWeek.ToString("d")) + 1;
            DateTime monthToday = new DateTime(now.Month);
            month.Text = monthToday.ToString();
            for (int i = 1; i < startoftheWeek; i++)
            {
                UserControlBlank blank = new UserControlBlank();
                DateContainer.Controls.Add(blank);
            }
            for (int i = 1; i <= totalDays; i++)
            {
                UserControlDays days = new UserControlDays();
                days.Dates(i);
                DateContainer.Controls.Add(days);
            }


        }
    }
}
