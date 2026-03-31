namespace zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            listBox2.Items.Clear();           
            int listSize = listBox1.Items.Count;
                       
            if (listSize == 0)
            {
                MessageBox.Show("Przen spisak!");
                return;
            }

           
            for (int i = listSize - 1; i >= 0; i--)
            {
                string tmp = listBox1.Items[i].ToString();
                listBox2.Items.Add(tmp);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(textBox1.Text, out int number))
            {
                listBox1.Items.Add(number); 
                textBox1.Clear();           
                textBox1.Focus();           
            }
            else
            {
                MessageBox.Show("Molq, vavedete cqlo chislo!");
            }           
        }
    }
}
