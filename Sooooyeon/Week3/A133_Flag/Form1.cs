namespace A133_Flag
{
    public partial class Form1 : Form
    {
        private bool flag; // 디폴트는 false
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(flag == false)
            {
                label1.Text = "Hello World!";
                flag = true;
            }
            else
            {
                label1.Text = "";
                flag = false;
            }
        }
    }
}
