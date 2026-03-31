namespace zad2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btnAdd = new Button();
            btnReverse = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(80, 48);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(96, 214);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(404, 48);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(95, 214);
            listBox2.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(213, 103);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 47);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReverse
            // 
            btnReverse.Location = new Point(226, 211);
            btnReverse.Name = "btnReverse";
            btnReverse.Size = new Size(92, 39);
            btnReverse.TabIndex = 3;
            btnReverse.Text = "Reverse";
            btnReverse.UseVisualStyleBackColor = true;
            btnReverse.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 48);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(105, 44);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 345);
            Controls.Add(textBox1);
            Controls.Add(btnReverse);
            Controls.Add(btnAdd);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnAdd;
        private Button btnReverse;
        private TextBox textBox1;
    }
}
