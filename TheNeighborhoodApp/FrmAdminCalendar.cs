﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;

namespace TheNeighborhoodApp
{
    public partial class FrmAdminCalendar : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        ArrayList events = new ArrayList();     
        int _month, _year, monthnow, totalDays;
        string _eventName, _fromDate, _toDate, _description;
        
        public static string selectedDate;
        int eventID;



        public FrmAdminCalendar()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            con.Open();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                btnAttach.Text = openfiledialog.FileName;
                picEvent.Image = new Bitmap(openfiledialog.FileName);
            }
        }

        private void FrmAdminCalendar_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now; monthnow = now.Month;
            _month = now.Month; _year = now.Year;
            DisplayDay(_month);
        }
        /*public void getEventDate()
        {
            con.Open();
            cmm = new SqlCommand("Select Date from Events",con);
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
                selectedDate = (string)dr.GetValue(4);
            }
            con.Close();
        }*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
           
           
            //selectedDate = dtPicker1.Text
            // _eventName = txtTitle.Text; _fromDate = dtPicker1.Text; _toDate = dtPicker2.Text; _description = txtDescription.Text;
            string query = "INSERT INTO Events VALUES (@EventID,@EventName,@EventInfo,@Image,@Date)";
            cmm = new SqlCommand(query, con);
            cmm.Parameters.AddWithValue("@EventID", getEventID());
            cmm.Parameters.AddWithValue("@EventName", txtTitle.Text);
            cmm.Parameters.AddWithValue("@EventInfo", txtDescription.Text);
            
            cmm.Parameters.AddWithValue("@Image", getPhoto()); 
            cmm.Parameters.AddWithValue("@Date", dtPicker1.Value.ToString("yyyy-MM-dd"));            
            cmm.ExecuteNonQuery();
            DisplayDay(_month);

            con.Close();

            txtDescription.Text = ""; txtTitle.Text = "";
           
        }
        public int getEventID()
        {
            int id = 0;
          
            cmm = new SqlCommand("SELECT MAX(EventID) FROM Events", con);
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
         
                    id = (int)dr.GetValue(0);
                id++;
                
                
            }
            dr.Close();
            return id;
           
        }
        public void getDate()
        {
            events.Clear();
           
            cmm = new SqlCommand("select convert(varchar(10),Date,101)from Events order by date", con);
            dr = cmm.ExecuteReader();

            while (dr.Read())
            {
                events.Add(dr.GetValue(0).ToString());
                
            }

            dr.Close();
            events.Sort();

        }
        public byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            if(picEvent != null && picEvent.Image != null)
            {
                picEvent.Image.Save(stream, picEvent.Image.RawFormat);
            }
            

            return stream.GetBuffer();
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

        public void timer1_Tick(object sender, EventArgs e)
        {
            displayText();
        }

        public string eventName { get; set; }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DisplayDay(_month);
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        public string eventInfo { get; set; }
        public Image image { get; set; } public DateTime date { get; set; }

        public void displayText()
        {
            txtTitle.Text = _eventName; txtDescription.Text = _description;
        }

        public void DisplayInfo(string eventName)
        {
            if(eventName == "")
            {
                System.Windows.Forms.MessageBox.Show("No events");
            }
            else
            {
               
                cmm = new SqlCommand("Select EventName, EvenInfo,Image,Date from Events where EventName = '" + eventName + "'", con);
                dr = cmm.ExecuteReader();
                while (dr.Read())
                {
                    _eventName = dr.GetValue(0).ToString(); _description = dr.GetValue(1).ToString();
                    dtPicker1.Value = (DateTime)dr.GetValue(3);
                    if(dr.GetValue(2) != null)
                    {
                        btnAttach.Text = dr.GetValue(2).ToString();
                    }
                    
                    txtTitle.Text = _eventName; txtDescription.Text = _description;
                    
                }
                dr.Close();
            }

            
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


                /*con.Open();
                cmm = new SqlCommand("Select EventName from Events where date = '"+ 
                    _year + "-" + _month + "-" + i + "'", con);
                dr = cmm.ExecuteReader();
               
                days.Dates(i);
                days.eventLabel(dr.GetValue(1).ToString());
                DateContainer.Controls.Add(days);
                con.Close();*/

                //System.Windows.Forms.MessageBox.Show(string.Format("{0:D2}", _month) + "/" + string.Format("{0:D2}",i) + "/" + _year);




                //System.Windows.Forms.MessageBox.Show((string.Format("{0:D2}", _month) + "/" + string.Format("{0:D2}", i) + "/" + _year));
                
               // System.Windows.Forms.MessageBox.Show(index.ToString());
                //System.Windows.Forms.MessageBox.Show(events[index].ToString());
                string countDate = (string.Format("{0:D2}", m) + "/" + string.Format("{0:D2}", i) + "/" + _year);
                if(events.Count > index)
                {
                    if (events[index].Equals(countDate))
                    {
                      
                        cmm = new SqlCommand("Select EventName from Events where date = '" +
                           events[index] + "'", con);
                        dr = cmm.ExecuteReader();
                        while (dr.Read())
                        {

                            days.Dates(i); days.eventLabel(dr.GetValue(0).ToString());
                            DateContainer.Controls.Add(days);
                        }
                        //System.Windows.Forms.MessageBox.Show("ookay");
                        index = index + 1;
                        dr.Close();
                       
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
