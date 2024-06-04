using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A142_CheckedListBox
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            clstBox.Items.Add("오스트리아, 빈");
            clstBox.Items.Add("호주, 멜버른");
            clstBox.Items.Add("일본, 오사카");
            clstBox.Items.Add("캐나다, 캘거리");
            clstBox.Items.Add("호주, 시드니");
            clstBox.Items.Add("캐나다, 밴쿠버");
            clstBox.Items.Add("일본, 도쿄");
            clstBox.Items.Add("캐나다, 토론토");
            clstBox.Items.Add("덴마크, 코펜하겐");
            clstBox.Items.Add("호주, 애들레이드");
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            foreach (var city in clstBox.CheckedItems)
                lstBox.Items.Add(city);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            foreach (var city in clstBox.Items)
                lstBox.Items.Add(city);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            List<string> lstRemove = new List<string>();

            foreach (string city in lstBox.SelectedItems)
                lstRemove.Add(city);

            foreach (string city in lstRemove)
                lstBox.Items.Remove(city);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
        }
    }
}
