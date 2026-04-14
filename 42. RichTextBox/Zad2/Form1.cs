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
                if (!string.IsNullOrEmpty(currentLine))
                {                   
                    string s = "  " + currentLine;                   
                    string formattedNumber = s.Substring(s.Length - 3);                   
                    listBox1.Items.Add(formattedNumber);
                }
            }

        }
    }
}
