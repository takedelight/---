namespace ср
{
    partial class Form2
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
            button1 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Value = new DataGridViewTextBoxColumn();
            Prev = new DataGridViewTextBoxColumn();
            Next = new DataGridViewTextBoxColumn();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            Shop = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 52);
            button1.Name = "button1";
            button1.Size = new Size(182, 42);
            button1.TabIndex = 0;
            button1.Text = "Додати до списку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 34);
            textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Value, Prev, Next });
            dataGridView1.Location = new Point(223, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 130);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Value
            // 
            Value.HeaderText = "Value";
            Value.Name = "Value";
            // 
            // Prev
            // 
            Prev.HeaderText = "Prev";
            Prev.Name = "Prev";
            // 
            // Next
            // 
            Next.HeaderText = "Next";
            Next.Name = "Next";
            // 
            // button2
            // 
            button2.Location = new Point(12, 100);
            button2.Name = "button2";
            button2.Size = new Size(182, 42);
            button2.TabIndex = 6;
            button2.Text = "Видалити";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Shop, Address, Product, qty, Price });
            dataGridView2.Location = new Point(12, 187);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(544, 130);
            dataGridView2.TabIndex = 7;
            // 
            // Shop
            // 
            Shop.HeaderText = "Shop";
            Shop.Name = "Shop";
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.Name = "Address";
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.Name = "Product";
            // 
            // qty
            // 
            qty.HeaderText = "Qty";
            qty.Name = "qty";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 348);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 330);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 9;
            label1.Text = "Shop";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(118, 348);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(224, 348);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(330, 348);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(436, 348);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 330);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 14;
            label2.Text = "Adress";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 330);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 15;
            label3.Text = "Product";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 330);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 16;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 330);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 17;
            label5.Text = "Price";
            // 
            // button3
            // 
            button3.Location = new Point(12, 391);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 18;
            button3.Text = "Додвти";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(94, 391);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 19;
            button4.Text = "Сортувати";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(dataGridView2);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Value;
        private DataGridViewTextBoxColumn Prev;
        private DataGridViewTextBoxColumn Next;
        private Button button2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Shop;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn Price;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button3;
        private Button button4;
    }
}