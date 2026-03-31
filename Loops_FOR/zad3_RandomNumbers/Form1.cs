namespace zad3_RandomNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int min = 1000;
            Random r=new Random();

            for (int i = 0; i < 10; i++)
            {
                int number = r.Next() % 100 + 1;
                listBox1.Items.Add(number);
                if (min>number)
                {
                    min = number;
                }
            }
            textBox1.Text = min.ToString();

        }
    }
}
