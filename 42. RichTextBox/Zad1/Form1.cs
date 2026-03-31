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
            //Когато въвеждаме в RichTextButton, курсора трябва да мига на последното число
            
            int Broy = 0, el, listSize;            
            int P = int.Parse(textBox1.Text);
            int Q = int.Parse(textBox2.Text);            
            listSize = richTextBox1.Lines.Count();           
            for (int i = 0; i < listSize; i++)
            {
               
                el = int.Parse(richTextBox1.Lines[i]);               
                if (el >= P && el <= Q)
                    Broy++;
            }           
            textBox3.Text = Broy.ToString();          
        }
    }
}
