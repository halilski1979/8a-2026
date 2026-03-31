namespace Zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < richTextBox1.Lines.Count(); i++)
            {
                string currentLine = richTextBox1.Lines[i].Trim();

                // Проверяваме дали редът не е празен
                if (!string.IsNullOrEmpty(currentLine))
                {
                    // Добавяме два интервала отпред ("  ")
                    string s = "  " + currentLine;

                    // Взимаме само последните 3 символа от низа.
                    // Така числото 5 става "  5", а 123 си остава "123".
                    string formattedNumber = s.Substring(s.Length - 3);

                    // Добавяме го в ListBox, който автоматично ще го сортира
                    listBox1.Items.Add(formattedNumber);
                }
            }

        }
    }
}
