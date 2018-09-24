using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace Clock
{
    public partial class Form1 : Form
    {
        TimeZoneInfo timeZoneInfo;
        TimeZoneInfo timeZoneInfo1;
        DateTime dateTime;
        DateTime dateTime1;

        public Form1()
        {
            InitializeComponent();
            //assign MST to first TimeZoneInfo field
            timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("US Mountain Standard Time");
            //assign KST to second TimeZoneInfo field
            timeZoneInfo1 = TimeZoneInfo.FindSystemTimeZoneById("Korea Standard Time");
            //assign MST to first DateTime field
            dateTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
            //assign KST to second DateTime field
            dateTime1 = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo1);
            //apply MST to left label
            label1.Text = (dateTime.ToString("yyyy-MM-dd HH-mm-ss"));
            //apply KST to right label
            label2.Text = (dateTime1.ToString("yyyy-MM-dd HH-mm-ss"));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("US Mountain Standard Time");
            timeZoneInfo1 = TimeZoneInfo.FindSystemTimeZoneById("Korea Standard Time");
            dateTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
            dateTime1 = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo1);
            label1.Text = (dateTime.ToString("yyyy-MM-dd HH-mm-ss"));
            label2.Text = (dateTime1.ToString("yyyy-MM-dd HH-mm-ss"));
        }
    }
}
