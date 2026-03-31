namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Път до файла (уверете се, че файлът съществува)
            string filePath = "names.txt";

            // 2. Инициализираме StreamReader
            // Използваме 'using', за да се затвори файла автоматично, 
            // или r.Close() накрая, както е в учебника.
            StreamReader r = new StreamReader(filePath);

            string line = "";

            // Изчистваме текстовото поле преди четене
            richTextBox1.Clear();

            // 3. Цикъл за четене ред по ред
            while (line != null)
            {
                line = r.ReadLine(); // Чете следващия ред

                if (line != null) // Проверка да не добавяме последната празна стойност
                {
                    // Добавяме прочетения ред към RichTextBox
                    richTextBox1.Text = richTextBox1.Text + line + "\n";
                }
            }

            // 4. Затваряме файла (както е посочено в урока)
            r.Close();
        }
    }
}
