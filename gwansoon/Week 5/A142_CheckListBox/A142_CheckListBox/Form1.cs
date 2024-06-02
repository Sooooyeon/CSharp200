using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace A142_CheckListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 폼의 Load 이벤트에 이벤트 핸들러 연결
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            foreach (var city in cLstBox.CheckedItems)
            {
                lstBox.Items.Add(city);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            foreach (var city in cLstBox.CheckedItems)
            {
                lstBox.Items.Add(city);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            List<string> lstRemove = new List<string>();

            foreach (string city in lstBox.SelectedItems)
            {
                lstRemove.Add(city);
            }

            foreach (string city in lstRemove)
            {
                lstBox.Items.Remove(city);
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cLstBox.Items.Add("오스트리아, 빈");
            cLstBox.Items.Add("호주, 맬버른");
            cLstBox.Items.Add("일본, 오사카");
            cLstBox.Items.Add("캐나다, 캘거리");
            cLstBox.Items.Add("호주, 시드니");
            cLstBox.Items.Add("캐나다, 밴쿠버");
            cLstBox.Items.Add("일본, 도쿄");
            cLstBox.Items.Add("캐나다, 토론토");
            cLstBox.Items.Add("덴마크, 코펜하겐");
            cLstBox.Items.Add("호주, 애들레이드");

            lstBox.SelectionMode = SelectionMode.MultiExtended;
        }
    }
}
