namespace zad1
{
    public partial class Form1 : Form
    {

        int listSize = 0;
        
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Добавя текста от textBox4 в списъка
            listBox1.Items.Add(textBox4.Text);

            // Изчиства текстовото поле за следващо въвеждане
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxv, pos, j, k;
            string s;

            // три търсения на максимален елемент
            for (int i = 0; i < 3; i++)
            {
                maxv = 0;
                pos = i;
                // търсене на максимален от индекс i нататък
                for (j = i; j < listBox1.Items.Count; j++)
                {
                    s = listBox1.Items[j].ToString();
                    k = int.Parse(s);

                    if (k > maxv)
                    {
                        maxv = k;
                        pos = j;
                    }
                }
                // преместване на максимума в началото (размяна на местата)
                s = listBox1.Items[i].ToString();
                listBox1.Items[i] = listBox1.Items[pos];
                listBox1.Items[pos] = s;
            }

            // Извеждане на трите най-големи стойности в текстовите полета
            textBox1.Text = listBox1.Items[0].ToString();
            textBox2.Text = listBox1.Items[1].ToString();
            textBox3.Text = listBox1.Items[2].ToString();
        }
    }
}
