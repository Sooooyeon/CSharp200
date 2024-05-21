using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A103_MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // (1) 간단한 메시지박스
            MessageBox.Show("가장 간단한 메시지박스입니다.");

            // (2) 타이틀을 갖는 메시지박스
            MessageBox.Show("타이틀을 갖는 메시지박스입니다.", "Title Message");

            // (3) 느낌표, 알림 메시지박스
            MessageBox.Show("느낌표와 알림 메시지박스입니다.", "느낌표와 알람소리",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // (4) 두개의 버튼을 갖는 메시지박스
            DialogResult result1 = MessageBox.Show("두개의 버튼을 갖는 메시지박스입니다.", "Qusetion",
                MessageBoxButtons.YesNo);

            // (5) 세개의 버튼과 물음표 아이콘을 보여주는 메시지박스
            DialogResult result2 = MessageBox.Show("세개의 버튼과 물음표 아이콘을 보여주는 메시지박스입니다.", "Qusetion",
                MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);


            // (6) 디폴트 버튼을 두 번째 버튼으로 지정한 메시지박스
            DialogResult result3 = MessageBox.Show("디폴트 버튼을 두 번째 버튼으로\n 지정한 메시지박스입니다.", "Qusetion",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            string msg = string.Format("당신의 선택 : {0} {1} {2}",result1.ToString(), result2.ToString(), result3.ToString());
            // (7) 선택결과를 보여주는 메시지박스
            MessageBox.Show(msg, "Your Selections");

        }
    }
}
