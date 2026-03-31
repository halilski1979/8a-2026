namespace Zad1_VaprosiZadachi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка за празен списък
            if (richTextBox1.Lines.Length == 0) return;

            // Инициализираме променливите
            int? min = null;
            int? max = null;
            int countMin = 0;
            int countMax = 0;

            foreach (string line in richTextBox1.Lines)
            {
                if (int.TryParse(line.Trim(), out int currentNum))
                {
                    // Първоначална настройка при първото валидно число
                    if (min == null || max == null)
                    {
                        min = max = currentNum;
                        countMin = countMax = 1;
                        continue;
                    }

                    // ПРОВЕРКА ЗА МАКСИМУМ
                    if (currentNum > max)
                    {
                        max = currentNum;
                        countMax = 1; // Нулираме брояча, защото сме намерили нов рекорд
                    }
                    else if (currentNum == max)
                    {
                        countMax++; // Намерили сме същото максимално число отново
                    }

                    // ПРОВЕРКА ЗА МИНИМУМ
                    if (currentNum < min)
                    {
                        min = currentNum;
                        countMin = 1; // Нулираме брояча за нов минимум
                    }
                    else if (currentNum == min)
                    {
                        countMin++; // Намерили сме същото минимално число отново
                    }
                }
            }

            // Извеждане на резултатите
            if (min != null && max != null)
            {
                labelMax.Text = $"Макс: {max} (среща се {countMax} пъти)";
                labelMin.Text = $"Мин: {min} (среща се {countMin} пъти)";
            }
        }
    }
}
