using System;
using System.Drawing;
using System.Windows.Forms;

namespace A126_FormWithConsole
{
    class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        static void Main()
        {
            CreateMyForm();

        }

        private static void CreateMyForm()
        {
            Form form1 = new Form();

            Button button1 = new Button();
            Button button2 = new Button();

            button1.Text = "OK";
            button1.Location = new Point(10, 10);
            button2.Text = "Cancel";
            button2.Location
                = new Point(button1.Left, button1.Height + button1.Top + 10);

            form1.Text = "My Dialog Box";

            button1.Click += Button1_Click;

            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            form1.StartPosition = FormStartPosition.CenterParent;

            form1.Controls.Add(button1);
            form1.Controls.Add(button2);

            form1.ShowDialog();
        }

        private static void Button1_Click(object sender, EventArgs e) {
            MessageBox.Show("OK Button Clicked!");
        }
    }
}

