namespace ср
{
    partial class Form4
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
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Deadline = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            richTextBox1 = new RichTextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            Symbol = new DataGridViewTextBoxColumn();
            Code = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(12, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 34);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(188, 28);
            button1.Name = "button1";
            button1.Size = new Size(131, 34);
            button1.TabIndex = 1;
            button1.Text = "Порахувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title, Deadline, Price });
            dataGridView1.Location = new Point(336, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(345, 136);
            dataGridView1.TabIndex = 3;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.Name = "Title";
            // 
            // Deadline
            // 
            Deadline.HeaderText = "Deadline";
            Deadline.Name = "Deadline";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 72);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(307, 96);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(12, 308);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 34);
            textBox2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(188, 308);
            button2.Name = "button2";
            button2.Size = new Size(131, 34);
            button2.TabIndex = 6;
            button2.Text = "Порахувати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Symbol, Code });
            dataGridView2.Location = new Point(358, 302);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(243, 136);
            dataGridView2.TabIndex = 8;
            // 
            // Symbol
            // 
            Symbol.HeaderText = "Symbol";
            Symbol.Name = "Symbol";
            // 
            // Code
            // 
            Code.HeaderText = "Code";
            Code.Name = "Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 363);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(richTextBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Deadline;
        private DataGridViewTextBoxColumn Price;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private Button button2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Symbol;
        private DataGridViewTextBoxColumn Code;
        private Label label1;
    }
}