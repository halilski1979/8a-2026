namespace _05._Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //??????????? ?? string ? ??? double
            double a = double.Parse(textBox1.Text);

            double s = a * a;
            double p = 4 * a;

            textBox2.Text = s.ToString();
            textBox3.Text = p.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
