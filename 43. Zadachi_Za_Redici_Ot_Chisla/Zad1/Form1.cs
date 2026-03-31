namespace Zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (richTextBox1.Lines.Length == 0)
            {
                MessageBox.Show("Моля, въведете числа!");
                return;
            }

            double sum = 0;
            double count = 0;
            double max = double.MinValue; 
            double min = double.MaxValue; 

            foreach (string line in richTextBox1.Lines)
            {
                string trimmedLine = line.Trim();

                // Прескачаме празни редове
                if (string.IsNullOrEmpty(trimmedLine)) continue;

                if (double.TryParse(trimmedLine, out double currentNum))
                {                  
                    sum += currentNum;                    
                    count++;                   
                    if (currentNum > max) max = currentNum;                    
                    if (currentNum < min) min = currentNum;
                }
            }

            
            if (count > 0)
            {
                double average = sum / count;                
                labelMax.Text = "Най-голямо: " + max.ToString();
                labelMin.Text = "Най-малко: " + min.ToString();
                labelSum.Text = "Сума: " + sum.ToString();
                labelAvg.Text = "Средно: " + average.ToString("0.00"); // Форматирано до 2 знака
            }
            else
            {
                MessageBox.Show("Не са открити валидни числа!");
            }
        }
    }
}
