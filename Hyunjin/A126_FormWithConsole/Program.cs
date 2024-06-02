using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace A126_FormWithConsole
{
    internal static class Program
    {
        static void Main(string[] args)
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
            form1.StartPosition = FormStartPosition.CenterScreen;

          
            form1.Controls.Add(button1); 
            form1.Controls.Add(button2);

 
            form1.ShowDialog();
        }
        private static void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK Button Clicked!");
        }
    }
}