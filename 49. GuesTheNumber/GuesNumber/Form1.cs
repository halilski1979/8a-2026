namespace GuesNumber
{
    public partial class Form1 : Form
    {

        // Глобални променливи за намисленото число и броя опити
        int compNum, cnt;

        public Form1()
        {
            InitializeComponent();
            // В началото бутонът за опит е изключен, докато не се натисне "Начало"
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            compNum = r.Next(1, 101); // Генерира число между 1 и 100

            button2.Enabled = true;   // Активира бутона за опит
            button1.Enabled = false;  // Деактивира бутона за начало

            cnt = 0;                  // Нулира брояча на опитите

            // Изчистване на полетата
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();         // Фокус върху полето за въвеждане
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Проверка дали полето не е празно
            if (string.IsNullOrEmpty(textBox1.Text)) return;

            int myNum = int.Parse(textBox1.Text);
            cnt++; // Увеличаваме броя на опитите

            textBox3.Text = cnt.ToString(); // Показваме броя опити
            textBox1.Focus();
            textBox1.SelectAll(); // Маркира числото за по-лесно изтриване

            if (myNum < compNum)
            {
                textBox2.Text = "нагоре";
            }
            else if (myNum > compNum)
            {
                textBox2.Text = "надолу";
            }
            else // Ако myNum == compNum
            {
                textBox2.Text = "позна";
                button2.Enabled = false; // Спираме играта
                button1.Enabled = true;  // Позволяваме нова игра
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        // ЗАЩИТА НА ПОЛЕТО ЗА ВЪВЕЖДАНЕ (KeyPress на textBox1)
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Позволяваме само цифри (0-9) и клавиша Backspace (код 8)
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true; // Блокира символа
                }
            }
        }
    }
}
