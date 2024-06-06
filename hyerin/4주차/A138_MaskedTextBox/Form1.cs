using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A138_MaskedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;

            str = "입사일: " + txtDate.Text + "\n";
            str += "우편번호: " + txtDate.Text + "\n";
            str += "주소: " + txtAdr.Text + "\n";
            str += "휴대폰번호: " + txtPh.Text + "\n";
            str += "주민등록번호: " + txtId.Text + "\n";
            str += "휴대폰번호: " + txtPh.Text + "\n";
            str += "이메일: " + txtE.Text + "\n";

            MessageBox.Show(str, "개인정보");
        }
    }
}
