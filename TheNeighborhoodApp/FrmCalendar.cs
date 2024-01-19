using System;
using System.Collections;
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
    public partial class FrmCalendar : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection(); SqlDataReader dr;

        int _month, _year, monthnow, totalDays;
        ArrayList events = new ArrayList();
        public FrmCalendar()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            _month++;
            DisplayDay(_month);
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            _month--;
            DisplayDay(_month);
        }

        private void FrmCalendar_Load(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now; monthnow = now.Month;
            _month = now.Month; _year = now.Year;
            DisplayDay(_month);
        }
        public void getDate()
        {
            events.Clear();
            con.Open();
            cmm = new SqlCommand("select convert(varchar(10),Date,101)from Events order by date", con);
            dr = cmm.ExecuteReader();

            while (dr.Read())
            {
                events.Add(dr.GetValue(0).ToString());

            }
            dr.Close();
            con.Close();
            events.Sort();

        }
        private void DisplayDay(int m)
        {

            getDate();
            //selectedDate = _year + "-" + _month + "-" + day;
            DateContainer.Controls.Clear();
            if (monthnow == m) { btnprev.Enabled = false; }
            else if (m == 12) { btnnext.Enabled = false; }
            else { btnprev.Enabled = true; btnnext.Enabled = true; }
            DateTime startofMonth = new DateTime(_year, m, 1);
            totalDays = DateTime.DaysInMonth(_year, m);
            int startoftheWeek = Convert.ToInt32(startofMonth.DayOfWeek.ToString("d")) + 1;




            for (int i = 1; i < startoftheWeek; i++)
            {

                UserControlBlank blank = new UserControlBlank();
                DateContainer.Controls.Add(blank);
            }
            int index = 0;
            for (int i = 1; i <= totalDays; i++)
            {
                UserControlDays days = new UserControlDays();
                string countDate = (string.Format("{0:D2}", m) + "/" + string.Format("{0:D2}", i) + "/" + _year);
                if (events.Count > index)
                {
                    if (events[index].Equals(countDate))
                    {
                        con.Open();
                        cmm = new SqlCommand("Select EventName from Events where date = '" +
                           events[index] + "'", con);
                        dr = cmm.ExecuteReader();
                        while (dr.Read())
                        {

                            days.Dates(i); days.eventLabel(dr.GetValue(0).ToString());
                            DateContainer.Controls.Add(days);
                        }
                        
                        index = index + 1;

                        con.Close();
                    }
                    else
                    {
                        days.Dates(i);
                        DateContainer.Controls.Add(days);
                    }
                }
                else
                {
                    days.Dates(i);
                    DateContainer.Controls.Add(days);
                }
            }
            switch (m)
            {
                case 1: lblmonth.Text = "January " + _year; break;
                case 2: lblmonth.Text = "February " + _year; break;
                case 3: lblmonth.Text = "March " + _year; break;
                case 4: lblmonth.Text = "April " + _year; break;
                case 5: lblmonth.Text = "May " + _year; break;
                case 6: lblmonth.Text = "June " + _year; break;
                case 7: lblmonth.Text = "July " + _year; break;
                case 8: lblmonth.Text = "August " + _year; break;
                case 9: lblmonth.Text = "September " + _year; break;
                case 10: lblmonth.Text = "October " + _year; break;
                case 11: lblmonth.Text = "November " + _year; break;
                case 12: lblmonth.Text = "December " + _year; break;
            }
        }
        }
}
