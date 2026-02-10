namespace _02._Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hello, world!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }
    }
}
