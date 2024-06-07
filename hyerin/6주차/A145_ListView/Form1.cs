using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A144_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            myLV.GridLines = true;
            myLV.FullRowSelect = true;

            myLV.Columns.Add("제품명", 150);
            myLV.Columns.Add("단가", 100, HorizontalAlignment.Right);
            myLV.Columns.Add("수량", 70, HorizontalAlignment.Right);
            myLV.Columns.Add("금액", 100, HorizontalAlignment.Right);

            ListViewItem item1 = new ListViewItem("Access", 0);
            ListViewItem item2 = new ListViewItem("Excel", 1);
            ListViewItem item3 = new ListViewItem("PowerPoint", 2);
            ListViewItem item4 = new ListViewItem("Word", 3);

            item1.SubItems.Add("22,000");
            item1.SubItems.Add("30");
            item1.SubItems.Add("660,000");

            item2.SubItems.Add("33,000");
            item2.SubItems.Add("50");
            item2.SubItems.Add("1,650,000");

            item3.SubItems.Add("11,000");
            item3.SubItems.Add("50");
            item3.SubItems.Add("550,000");

            item4.SubItems.Add("22,000");
            item4.SubItems.Add("30");
            item4.SubItems.Add("660,000");

            myLV.Items.AddRange(new ListViewItem[]
            {item1, item2, item3, item4});

            ImageList sImageList = new ImageList();
            sImageList.ImageSize = new Size(24, 24);
            ImageList lImageList = new ImageList();
            lImageList.ImageSize = new Size(64, 64);

            myLV.SmallImageList = sImageList;
            myLV.LargeImageList = lImageList;

            sImageList.Images.Add(Bitmap.FromFile(@"../../Image/access.jpg"));
            sImageList.Images.Add(Bitmap.FromFile(@"../../Image/excel.jpg"));
            sImageList.Images.Add(Bitmap.FromFile(@"../../Image/ppt.jpg"));
            sImageList.Images.Add(Bitmap.FromFile(@"../../Image/word.jpg"));

            lImageList.Images.Add(Bitmap.FromFile(@"../../Image/access.jpg"));
            lImageList.Images.Add(Bitmap.FromFile(@"../../Image/excel.jpg"));
            lImageList.Images.Add(Bitmap.FromFile(@"../../Image/ppt.jpg"));
            lImageList.Images.Add(Bitmap.FromFile(@"../../Image/word.jpg"));
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            myLV.View = View.Details;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            myLV.View = View.List;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            myLV.View = View.SmallIcon;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            myLV.View = View.LargeIcon;
        }

        private void myLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            ListView.SelectedListViewItemCollection selected = myLV.SelectedItems;

            foreach (ListViewItem item in selected)
            {
                for (int i = 0; i < 4; i++)
                    textBox1.Text += item.SubItems[i].Text + "\t";
            }
        }
    }
}
