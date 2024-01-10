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
            
            DateTime startofMonth = new DateTime(now.Year, now.Month, 1);
            int totalDays = DateTime.DaysInMonth(now.Year, now.Month);
            int startoftheWeek = Convert.ToInt32(startofMonth.DayOfWeek.ToString("d")) + 1;
            int monthdigit = now.Month;
            
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
            switch (monthdigit)
            {
                case 1: month.Text = "January";break;case 2:month.Text = "February";break;
                case 3:month.Text = "March";break;case 4:month.Text = "April";break;
                case 5:month.Text = "May";break;case 6:month.Text = "June";break;
                case 7:month.Text = "July";break;case 8:month.Text = "August";break;
                case 9:month.Text = "September";break;case 10:month.Text = "October";break;
                case 11:month.Text = "November";break;case 12:month.Text = "December";break;
            }


        }
    }
}
