using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A141_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            label2.Text = "이번 주 모임장소는: " + cb.SelectedItem.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text !="")
            {
                comboBox1.Items.Add(comboBox1.Text);
                label2.Text = comboBox1.Text + " Added!";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex >= 0)
            {
                label2.Text = comboBox1.SelectedItem.ToString() + " Deleted!";
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            }
        }
    }
}
