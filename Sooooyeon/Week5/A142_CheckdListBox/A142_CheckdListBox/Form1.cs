﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A142_CheckdListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cLsBox.Items.Add("오스트리아, 빈");
            cLsBox.Items.Add("호주, 멜버른");
            cLsBox.Items.Add("일본, 오사카");
            cLsBox.Items.Add("캐나다, 캘커리");
            cLsBox.Items.Add("호주, 시드니");
            cLsBox.Items.Add("캐나다, 벤쿠버");
            cLsBox.Items.Add("일본, 도쿄");
            cLsBox.Items.Add("캐나다, 토론토");
            cLsBox.Items.Add("덴마크, 코펜하겐");
            cLsBox.Items.Add("호주, 애들레이드");

            lstBox.SelectionMode = SelectionMode.MultiExtended;

        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            foreach (var city in cLsBox.CheckedItems)
            {
                lstBox.Items.Add(city);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            foreach (var city in cLsBox.Items)
            {
                lstBox.Items.Add(city);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            List<string> lstRemove = new List<string>();

            foreach(string city in lstBox.SelectedItems)
            {
                lstRemove.Add(city);
            }

            foreach (string city in lstRemove)
            {
                lstBox.Items.Remove(city);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
        }
    }
}