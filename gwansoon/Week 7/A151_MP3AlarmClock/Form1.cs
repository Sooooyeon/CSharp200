using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib; // WindowsMediaPlayer

namespace A151_MP3AlarmClock
{
    public partial class Form1 : Form
    {
        private Timer myTimer = new Timer();
        private DateTime dDay;
        private DateTime tTime;
        private bool setAlarm;
        WindowsMediaPlayer myPlayer = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
            lblAlarm.ForeColor = Color.Gray;
            lblAlarmset.ForeColor = Color.Gray;

            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "tt hh:mm";

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
                if (dDay == DateTime.Today && cTime.Hour == tTime.Hour && cTime.Minute == tTime.Minute)
                {
                    setAlarm = false;
                    myPlayer.URL = @"D:\Csharp_Practice\CSharp200\gwansoon\A151_MP3AlarmClock\Music\flow.mp3";
                    myPlayer.controls.play();
                }
            }
        }


        private void btnSet_Click(object sender, EventArgs e)
        {
            dDay = DateTime.Parse(datePicker1.Text);
            tTime = DateTime.Parse(TimePicker.Text);

            setAlarm = true;
            lblAlarmset.ForeColor = Color.Red;
            lblAlarm.ForeColor = Color.Blue;
            lblAlarm.Text = "Alarm : " + dDay.ToShortDateString() + " " + tTime.ToLongTimeString();
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setAlarm = false;
            lblAlarmset.ForeColor = Color.Gray;
            lblAlarm.ForeColor = Color.Gray;
            lblAlarm.Text = "Alarm : ";
            tabControl1.SelectedTab = tabPage2;
        }
    }
}