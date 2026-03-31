namespace zad2_Vaprosi_Zadachi
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
            richTextBox1 = new RichTextBox();
            listBox1 = new ListBox();
            buttonPlay = new Button();
            label1 = new Label();
            labelResult = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(33, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(91, 121);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(377, 49);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(86, 124);
            listBox1.TabIndex = 1;
            // 
            // buttonPlay
            // 
            buttonPlay.Location = new Point(187, 115);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(130, 58);
            buttonPlay.TabIndex = 2;
            buttonPlay.Text = "buttonPlay";
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 227);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "РЕЗУЛТАТ: ";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(130, 227);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(38, 15);
            labelResult.TabIndex = 4;
            labelResult.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 21);
            label2.Name = "label2";
            label2.Size = new Size(189, 15);
            label2.TabIndex = 5;
            label2.Text = "Въведете 6 различни числа [1.49]";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(labelResult);
            Controls.Add(label1);
            Controls.Add(buttonPlay);
            Controls.Add(listBox1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private ListBox listBox1;
        private Button buttonPlay;
        private Label label1;
        private Label labelResult;
        private Label label2;
    }
}
