using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A149_DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime selectedDay = dateTimePicker1.Value;

            txtDates.Text = today.Subtract(selectedDay).TotalDays.ToString("0");
        }

    }
}
