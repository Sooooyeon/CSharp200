using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A135
{
    public partial class Form1 : Form
    {
        private RadioButton checkedRB;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            if (rbKorea.Checked)
                result += "nationality: Korea\n";
            else if (rbChina.Checked)
                result += "nationality: China\n";
            else if (rbJapan.Checked)
                result += "nationality: Japan\n";
            else if (rbOther.Checked)
                result += "nationality: Other\n";

            if (checkedRB == rbMaie)
                result += "Gender: Male";
            else if (checkedRB == rbFemale)
                result += "Gender: Female";

            MessageBox.Show(result, "Result");

        }

        private void rbMaie_CheckedChanged(object sender, EventArgs e)
        {
            checkedRB = rbMaie;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            checkedRB = rbFemale;
        }
    }
}
