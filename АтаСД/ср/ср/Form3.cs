using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using ср.data_structures;

namespace ср
{
    public partial class Form3 : Form
    {
        private HashTable hashTable = new HashTable(20);
        private BTree bTree = new BTree();

        public Form3()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadDataFromFile();

            if (richTextBox1 != null)
            {
                richTextBox1.Font = new Font("Consolas", 10);
                richTextBox1.ReadOnly = true;
            }
        }

        private void SetupDataGridView()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Індекс";
            dataGridView1.Columns[1].Name = "Ключ";
            dataGridView1.Columns[2].Name = "Підказка";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadDataFromFile()
        {
            string filePath = "keywords.txt";
            if (File.Exists(filePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (var line in lines)
                    {
                        var parts = line.Split(':');
                        if (parts.Length == 2)
                            hashTable.Insert(parts[0].Trim(), parts[1].Trim());
                    }
                    RefreshGrid();
                }
                catch (Exception ex) { MessageBox.Show("Помилка: " + ex.Message); }
            }
        }

        private void RefreshGrid()
        {
            dataGridView1.Rows.Clear();
            var data = hashTable.GetFullTable();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != null && data[i].IsOccupied)
                    dataGridView1.Rows.Add(i, data[i].Key, data[i].Value);
                else
                    dataGridView1.Rows.Add(i, "-", "-");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text.Trim();
            string result = hashTable.Search(key);
            label1.Text = result != null ? $"Підказка: {result}" : "Слово не знайдено";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int value))
            {
                bTree.Insert(value);
                textBox2.Clear();
                textBox2.Focus();
                RefreshTreeOutput();
            }
            else
            {
                MessageBox.Show("Введіть ціле число!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int value))
            {
                bool found = bTree.Search(value);
                if (found)
                {
                    RefreshTreeOutput();
                    HighlightNode(value);
                    MessageBox.Show($"Число {value} знайдено!");
                }
                else
                {
                    MessageBox.Show("Число не знайдено.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bTree = new BTree();
            richTextBox1.Clear();
        }

        private void RefreshTreeOutput()
        {
            richTextBox1.Clear();
            if (bTree.Root != null)
            {
                ShowTree(bTree.Root, "", true);
            }
        }

        private void ShowTree(Node node, string indent, bool last)
        {
            richTextBox1.AppendText(indent);
            if (last)
            {
                richTextBox1.AppendText("└─ ");
                indent += "   ";
            }
            else
            {
                richTextBox1.AppendText("├─ ");
                indent += "│  ";
            }

            richTextBox1.AppendText("[" + string.Join(", ", node.Keys) + "]" + Environment.NewLine);

            for (int i = 0; i < node.Children.Count; i++)
            {
                ShowTree(node.Children[i], indent, i == node.Children.Count - 1);
            }
        }

        private void HighlightNode(int value)
        {
            string search = value.ToString();
            int start = 0;
            while ((start = richTextBox1.Find(search, start, RichTextBoxFinds.None)) != -1)
            {
                richTextBox1.Select(start, search.Length);
                richTextBox1.SelectionBackColor = Color.Yellow;
                start += search.Length;
            }
        }

        private void ClearHighlight()
        {
            if (richTextBox1.TextLength > 0)
            {
                int currentSelection = richTextBox1.SelectionStart;
                int currentLength = richTextBox1.SelectionLength;

                richTextBox1.SelectAll();
                richTextBox1.SelectionBackColor = richTextBox1.BackColor;

                richTextBox1.Select(currentSelection, currentLength);
            }
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ClearHighlight();

            if (int.TryParse(textBox3.Text, out int value))
            {
                HighlightNode(value);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int value))
            {
                bool found = bTree.Search(value);

                RefreshTreeOutput();

                if (found)
                {
                    HighlightNode(value);
                    MessageBox.Show($"Вузло {value} знайдено!");
                }
                else
                {
                    MessageBox.Show("Вузло не знайдено");
                }
            }
        }
    }
}