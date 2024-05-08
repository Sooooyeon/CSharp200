using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //Point사용 라이브러리 
using System.Windows.Forms; //추가 

namespace A126_FormWithConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateMyForm();
        }
        private static void CreateMyForm()
        {
            Form form1 = new Form(); //form객체생성
             
            Button button1 = new Button(); //버튼 객체 생성
            Button button2 = new Button();

            button1.Text = "OK"; //ok글자가 보임 
            button1.Location = new Point(10, 10); //위치
            button2.Text = "Cancel"; 
            button2.Location 
                = new Point(button1.Left, button1.Height + button1.Top + 10); //btn1기준 위치

            form1.Text = "My Dialog Box";

            button1.Click += Button1_Click; //이벤트 처리 메소드 

            //닷넷 제공 enum
            form1.FormBorderStyle = FormBorderStyle.FixedDialog; //선 속성 
            form1.StartPosition = FormStartPosition.CenterScreen; 

            //Add buttons to the form
            form1.Controls.Add(button1); //form1에 버튼 추가 
            form1.Controls.Add(button2);

            //Display the form as a modal dialog box. 
            form1.ShowDialog(); //폼 보이기 
        }
        private static void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK Button Clicked!");
        }
    }
}
