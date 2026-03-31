namespace Zad1_VaprosiZadachi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            labelMax = new Label();
            labelMin = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(29, 21);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(103, 171);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.Location = new Point(56, 283);
            labelMax.Name = "labelMax";
            labelMax.Size = new Size(38, 15);
            labelMax.TabIndex = 1;
            labelMax.Text = "label1";
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Location = new Point(56, 311);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(38, 15);
            labelMin.TabIndex = 2;
            labelMin.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(29, 212);
            button1.Name = "button1";
            button1.Size = new Size(103, 48);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(226, 21);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 160);
            textBox1.TabIndex = 4;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 349);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(labelMin);
            Controls.Add(labelMax);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label labelMax;
        private Label labelMin;
        private Button button1;
        private TextBox textBox1;
    }
}
