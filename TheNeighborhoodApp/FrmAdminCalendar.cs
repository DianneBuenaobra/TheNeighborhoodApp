using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNeighborhoodApp
{
    public partial class FrmAdminCalendar : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        int _month, _year, monthnow, totalDays;
        string _eventName, _fromDate, _toDate, _description;
        public static string selectedDate;
        UserControlDays ucdays = new UserControlDays();



        public FrmAdminCalendar()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());con.Open();
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           // ucdays.displayEvent(_month,_year, totalDays);
        }

        private void FrmAdminCalendar_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now; monthnow = now.Month;
            _month = now.Month; _year = now.Year;
            DisplayDay();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
            // _eventName = txtTitle.Text; _fromDate = dtPicker1.Text; _toDate = dtPicker2.Text; _description = txtDescription.Text;
            string query = "INSERT INTO Events VALUES (@EventName,@Date,@description)";
            cmm = new SqlCommand(query, con);
            cmm.Parameters.AddWithValue("@EventName", txtTitle.Text);
            cmm.Parameters.AddWithValue("@Date", dtPicker1.Value.ToString("yyyy-MM-dd")); 
            
            cmm.Parameters.AddWithValue("@description", txtDescription.Text);
            cmm.ExecuteNonQuery();

            MessageBox.Show(selectedDate);
       
            con.Close();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
           DateContainer.Controls.Clear();
            _month++;
            //timer1.Start();
            if (monthnow == _month) { btnprev.Enabled = false; }
            else if (_month == 12) { btnnext.Enabled = false; }
            else { btnprev.Enabled = true; btnnext.Enabled = true; }
            DateTime startofMonth = new DateTime(_year, _month, 1);
            totalDays = DateTime.DaysInMonth(_year, _month);
            int startoftheWeek = Convert.ToInt32(startofMonth.DayOfWeek.ToString("d")) + 1;
            int monthdigit = _month;

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
            switch (_month)
            {
                case 1: lblmonth.Text = "January " + _year; break;case 2: lblmonth.Text = "February " + _year; break;
                case 3: lblmonth.Text = "March " + _year; break;case 4: lblmonth.Text = "April " + _year; break;
                case 5: lblmonth.Text = "May " + _year; break;case 6: lblmonth.Text = "June " + _year; break;
                case 7: lblmonth.Text = "July " + _year; break;case 8: lblmonth.Text = "August " + _year; break;
                case 9: lblmonth.Text = "September " + _year; break;case 10: lblmonth.Text = "October " + _year; break;
                case 11: lblmonth.Text = "November " + _year; break;case 12: lblmonth.Text = "December " + _year; break;
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        { 
            
            DateContainer.Controls.Clear();
            _month--;
            //timer1.Start();
            if (monthnow == _month) { btnprev.Enabled = false; }
            else if (_month == 12) { btnnext.Enabled = false; }
            else { btnprev.Enabled = true; btnnext.Enabled = true; }
            DateTime startofMonth = new DateTime(_year, _month, 1);
            totalDays = DateTime.DaysInMonth(_year, _month);
            int startoftheWeek = Convert.ToInt32(startofMonth.DayOfWeek.ToString("d")) + 1;
            int monthdigit = _month;

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
            switch (_month)
            {
                case 1: lblmonth.Text = "January " + _year; break;case 2: lblmonth.Text = "February " + _year; break;
                case 3: lblmonth.Text = "March " + _year; break;case 4: lblmonth.Text = "April " + _year; break;
                case 5: lblmonth.Text = "May " + _year; break;case 6: lblmonth.Text = "June " + _year; break;
                case 7: lblmonth.Text = "July " + _year; break;case 8: lblmonth.Text = "August " + _year; break;
                case 9: lblmonth.Text = "September " + _year; break;case 10: lblmonth.Text = "October " + _year; break;
                case 11: lblmonth.Text = "November " + _year; break;case 12: lblmonth.Text = "December " + _year; break;
            }
        }
        private void DisplayDay()
        {
            //selectedDate = _year + "-" + _month + "-" + day;
            DateContainer.Controls.Clear();
            if (monthnow == _month) { btnprev.Enabled = false; }
            else if (_month == 12) { btnnext.Enabled = false; }
            else { btnprev.Enabled = true; btnnext.Enabled = true; }
            DateTime startofMonth = new DateTime(_year, _month, 1);
            totalDays = DateTime.DaysInMonth(_year, _month);
            int startoftheWeek = Convert.ToInt32(startofMonth.DayOfWeek.ToString("d")) + 1;
            
            
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
            switch (_month)
            {
                case 1: lblmonth.Text = "January " + _year;break;case 2: lblmonth.Text = "February " + _year; break;
                case 3: lblmonth.Text = "March " + _year; break;case 4: lblmonth.Text = "April " + _year; break;
                case 5: lblmonth.Text = "May " + _year; break;case 6: lblmonth.Text = "June " + _year; break;
                case 7: lblmonth.Text = "July " + _year; break;case 8: lblmonth.Text = "August " + _year; break;
                case 9: lblmonth.Text = "September " + _year; break;case 10: lblmonth.Text = "October " + _year; break;
                case 11: lblmonth.Text = "November " + _year; break;case 12: lblmonth.Text = "December " + _year; break;
            }
            


        }
    }
}
