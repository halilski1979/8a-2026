namespace zad2_Variant_RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            int x = int.Parse(textBox1.Text);            
            int listSize = richTextBox1.Lines.Count();
            for (int i = 0; i < listSize; i++)
            {
                // Проверяваме дали текущият ред е равен на търсеното число
                if (x == int.Parse(richTextBox1.Lines[i]))
                {                    
                    label3.Text ="Позиция: " + i + ": " + richTextBox1.Lines[i].ToString();
                    return; 
                }
            }
            // Ако цикълът завърши и не е излязъл чрез 'return', значи числото го няма
            label3.Text = "Не е в редицата";
        }
    }
}
