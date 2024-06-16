using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A152_WMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            axWindowsMediaPlayer1.uiMode = "full";
            axWindowsMediaPlayer1.stretchToFit = true;

            btnFile.Location = new Point(
                ClientSize.Width - btnFile.Size.Width -5,
                ClientSize.Height - btnFile.Size.Height -5 );
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = ofd.FileName;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Size = this.ClientSize;

            btnFile.Location = new Point(
                ClientSize.Width - btnFile.Size.Width -5,
                ClientSize.Height - btnFile.Size.Height -5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
