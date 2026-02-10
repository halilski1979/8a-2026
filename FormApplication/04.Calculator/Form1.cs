namespace _04.Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Преобразува string(символи) в int(число)
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            //Намира сумата на двете числа
            int c = a + b;

            //Отпечатва резултата в label1
            label1.Text = c.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x=int.Parse(textBox1.Text);
            int y=int.Parse(textBox2.Text);

            int r = x - y;

            label1.Text=r.ToString();
        }
    }
}
