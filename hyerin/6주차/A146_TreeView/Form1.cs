using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace A146_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            TreeNode root = new TreeNode("영국의 왕");

            TreeNode stuart = new TreeNode("스튜어트 왕가");
            TreeNode hanover= new TreeNode("하노버 왕가");
            TreeNode sachsen = new TreeNode("작센코브르트고타 왕가");
            TreeNode windsor = new TreeNode("윈저 왕가");

            stuart.Nodes.Add("앤(1707~1714)");

            hanover.Nodes.Add("조지 1세(1714~1727)");
            hanover.Nodes.Add("조지 2세(1727~1760)");
            hanover.Nodes.Add("조지 3세(1760~1820)");
            hanover.Nodes.Add("조지 4세(1820~1830)");
            hanover.Nodes.Add("윌리엄 4세(1830~1837)");
            hanover.Nodes.Add("빅토리아(1837~1901)");

            sachsen.Nodes.Add("에드워드 7세(1901~1910)");

            windsor.Nodes.Add("조지 5세(1910~1936)");
            windsor.Nodes.Add("에드워드 8세(1936~1936)");
            windsor.Nodes.Add("조지 6세(1936~1952)");
            windsor.Nodes.Add("엘리자베스 2세(1952~현재)");

            root.Nodes.Add(stuart);
            root.Nodes.Add(hanover);
            root.Nodes.Add(sachsen);
            root.Nodes.Add(windsor);

            treeView1.Nodes.Add(root);
            treeView1.ExpandAll();
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "앤(1707~1714)") 
            {
                pictureBox1.Image = Bitmap.FromFile("../../Images/king.jpg");
                txtMemo.Text = "앤 여왕은 1702년 3월 8일 잉글랜드와 스코틀랜드, ...";
            }
            else if(e.Node.Text == "조지 1세(1714~1727)")
            {
                pictureBox1.Image = Bitmap.FromFile("../../Images/king.jpg");
                txtMemo.Text = "잉글랜드 의회에서 1701년 왕위결정법이 통과되면서, ..."
;            }
        }
    }
}
