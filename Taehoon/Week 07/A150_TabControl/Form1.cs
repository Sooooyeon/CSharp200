using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace A150_TabControl
{
    public partial class Form1 : Form
    {
        private Timer myTimer = new Timer();
        private DateTime dDay;
        private DateTime tTime;
        private bool setAlarm;
        public Form1()
        {
            InitializeComponent();
            lblAlarm.ForeColor = Color.Gray;
            lblAlarmSet.ForeColor = Color.Gray;

            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "tt hh:mm";

            myTimer.Interval = 1000;
            myTimer.Tick += MyTimer_Tick;
            myTimer.Start();

            tabControl1.SelectedTab = tabPage2;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            DateTime cTime = DateTime.Now;
            lblDate.Text = cTime.ToShortDateString();

            lblTime.Text = cTime.ToLongTimeString();

            if (setAlarm == true)
            {
                if(dDay == DateTime.Today &&
                    cTime.Hour == tTime.Hour && cTime.Minute == tTime.Minute)
                {
                    setAlarm = false;
                    MessageBox.Show("Alarm !! ");
                }
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            dDay = DateTime.Parse(datePicker.Text);
            tTime = DateTime.Parse(timePicker.Text);

            setAlarm = true;
            lblAlarmSet.ForeColor = Color.Red;
            lblAlarm.ForeColor = Color.Blue;
            lblAlarm.Text = "Alarm : " + dDay.ToShortDateString() + " "
            + tTime.ToLongTimeString();
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setAlarm = false;
            lblAlarmSet.ForeColor = Color.Gray;
            lblAlarm.ForeColor = Color.Gray;
            lblAlarm.Text = "Alarm : ";
            tabControl1.SelectedTab = tabPage2;
        }
    }
}
