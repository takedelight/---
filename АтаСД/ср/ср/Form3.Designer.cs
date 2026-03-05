namespace ср
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            textBox3 = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(298, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 150);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 34);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(183, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 2;
            button1.Text = "Шукати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(12, 273);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 34);
            textBox2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(183, 273);
            button2.Name = "button2";
            button2.Size = new Size(75, 34);
            button2.TabIndex = 5;
            button2.Text = "Додати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 15F);
            richTextBox1.Location = new Point(276, 250);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(384, 188);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(12, 330);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 34);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(183, 330);
            button3.Name = "button3";
            button3.Size = new Size(75, 34);
            button3.TabIndex = 8;
            button3.Text = "Пошук";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private TextBox textBox2;
        private Button button2;
        private RichTextBox richTextBox1;
        private TextBox textBox3;
        private Button button3;
    }
}