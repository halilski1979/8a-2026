namespace Zad1
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
            labelMax = new Label();
            labelMin = new Label();
            labelSum = new Label();
            labelAvg = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(91, 88);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(119, 192);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelMax.Location = new Point(230, 104);
            labelMax.Name = "labelMax";
            labelMax.Size = new Size(65, 25);
            labelMax.TabIndex = 5;
            labelMax.Text = "label5";
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelMin.Location = new Point(230, 140);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(65, 25);
            labelMin.TabIndex = 6;
            labelMin.Text = "label6";
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelSum.Location = new Point(230, 179);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(65, 25);
            labelSum.TabIndex = 7;
            labelSum.Text = "label7";
            // 
            // labelAvg
            // 
            labelAvg.AutoSize = true;
            labelAvg.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            labelAvg.Location = new Point(230, 221);
            labelAvg.Name = "labelAvg";
            labelAvg.Size = new Size(65, 25);
            labelAvg.TabIndex = 8;
            labelAvg.Text = "label8";
            // 
            // button1
            // 
            button1.Location = new Point(91, 302);
            button1.Name = "button1";
            button1.Size = new Size(204, 55);
            button1.TabIndex = 9;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 443);
            Controls.Add(button1);
            Controls.Add(labelAvg);
            Controls.Add(labelSum);
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
        private Label labelSum;
        private Label labelAvg;
        private Button button1;
    }
}
