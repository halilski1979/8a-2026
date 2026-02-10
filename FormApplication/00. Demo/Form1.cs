namespace _00._Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible=false;
        }
    }
}
