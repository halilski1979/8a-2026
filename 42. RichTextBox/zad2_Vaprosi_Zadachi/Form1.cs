namespace zad2_Vaprosi_Zadachi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            // 1. Списък за вашите числа (от richTextBox1)
            List<int> userNumbers = new List<int>();

            // Четем всеки ред от richTextBox1
            foreach (string line in richTextBox1.Lines)
            {
                // Премахваме интервали и проверяваме дали редът не е празен
                string trimmedLine = line.Trim();
                if (string.IsNullOrEmpty(trimmedLine)) continue;

                if (int.TryParse(trimmedLine, out int num))
                {
                    // Проверка за интервал и дубликати
                    if (num >= 1 && num <= 49)
                    {
                        if (!userNumbers.Contains(num))
                        {
                            userNumbers.Add(num);
                        }
                    }
                }
            }

            // ПРОВЕРКА: Трябва да са въведени точно 6 валидни числа
            if (userNumbers.Count != 6)
            {
                MessageBox.Show("Моля, въведете точно 6 различни числа между 1 и 49 (по едно на ред)!");
                RichTextBox.
                return;
            }

            // 2. Генериране на печелившите числа (6 от 49)
            Random rand = new Random();
            List<int> winningNumbers = new List<int>();
            listBox1.Items.Clear(); // Тук ще покажем изтеглените числа

            while (winningNumbers.Count < 6)
            {
                int nextNum = rand.Next(1, 50); // Генерира от 1 до 49
                if (!winningNumbers.Contains(nextNum))
                {
                    winningNumbers.Add(nextNum);
                    listBox1.Items.Add(nextNum); // Добавяме в списъка за визуализация
                }
            }

            // 3. Сравняване и преброяване на познатите числа
            int matches = 0;
            foreach (int myNum in userNumbers)
            {
                if (winningNumbers.Contains(myNum))
                {
                    matches++;
                }
            }

            // 4. Извеждане на резултата
            labelResult.Text = "Познахте " + matches + " числа!";

            if (matches == 6)
            {
                MessageBox.Show("НЕВЕРОЯТНО! Познахте всички 6 числа!");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
