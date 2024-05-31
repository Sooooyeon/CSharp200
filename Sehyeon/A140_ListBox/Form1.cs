using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A140_ListBox
{
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void ListBox_Load(object sender, EventArgs e)
        {
            listBox2.Items.Add("오스트리아,빈");
            listBox2.Items.Add("오스트리아,빈2");
            listBox2.Items.Add("오스트리아,빈3");
            listBox2.Items.Add("오스트리아,빈4");
            listBox2.Items.Add("오스트리아,빈5");
            listBox2.Items.Add("오스트리아,빈6");
            listBox2.Items.Add("오스트리아,빈7");
            listBox2.Items.Add("오스트리아,빈8");
            listBox2.Items.Add("오스트리아,빈9");
            listBox2.Items.Add("호주,애들레이드");

            List<String> lstGDP = new List<String> { "미국", "러시아", "중국", "영국", "독일", "프랑스", "일본", "사우디아라비아", "UAE", };
            listBox3.DataSource = lstGDP;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            //txtSIndex1.Text = lst.SelectedIndex
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
