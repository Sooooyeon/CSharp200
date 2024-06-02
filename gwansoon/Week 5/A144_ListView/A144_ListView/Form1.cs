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
            myListView.GridLines = true;
            myListView.FullRowSelect = true;
            myListView.View = View.Details; // 여기서 View.Details로 설정합니다.

            myListView.Columns.Add("제품명", 150);
            myListView.Columns.Add("단가", 100, HorizontalAlignment.Right);
            myListView.Columns.Add("수량", 70, HorizontalAlignment.Right);
            myListView.Columns.Add("금액", 100, HorizontalAlignment.Right);

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

            myListView.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4 });

            ImageList sImageList = new ImageList();
            sImageList.ImageSize = new Size(24, 24);

            ImageList lImageList = new ImageList();
            lImageList.ImageSize = new Size(64, 64);

            myListView.SmallImageList = sImageList;
            myListView.LargeImageList = lImageList;

            sImageList.Images.Add(Bitmap.FromFile(@"../../images/access.png"));
            sImageList.Images.Add(Bitmap.FromFile(@"../../images/excel.png"));
            sImageList.Images.Add(Bitmap.FromFile(@"../../images/ppt.png"));
            sImageList.Images.Add(Bitmap.FromFile(@"../../images/word.png"));

            lImageList.Images.Add(Bitmap.FromFile(@"../../images/access.png"));
            lImageList.Images.Add(Bitmap.FromFile(@"../../images/excel.png"));
            lImageList.Images.Add(Bitmap.FromFile(@"../../images/ppt.png"));
            lImageList.Images.Add(Bitmap.FromFile(@"../../images/word.png"));
            AdjustLastColumnWidth();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustLastColumnWidth();
        }

        private void AdjustLastColumnWidth()
        {
            int totalWidth = myListView.ClientSize.Width;
            for (int i = 0; i < myListView.Columns.Count - 1; i++)
            {
                totalWidth -= myListView.Columns[i].Width;
            }
            myListView.Columns[myListView.Columns.Count - 1].Width = totalWidth - 4;
        }
    }
}
