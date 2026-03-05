using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ср.data_structures; // Твій неймспейс для кодека

namespace ср
{
    public struct Product
    {
        public int Deadline { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            SetupGrids();
            FillTableWithSampleData();
        }

        private void SetupGrids()
        {
            // Таблиця товарів
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Товар";
            dataGridView1.Columns[1].Name = "Дедлайн (днів)";
            dataGridView1.Columns[2].Name = "Ціна";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Таблиця Хаффмана
            dataGridView2.Rows.Clear();
            dataGridView2.ColumnCount = 2;
            dataGridView2.Columns[0].Name = "Символ";
            dataGridView2.Columns[1].Name = "Код Хаффмана";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FillTableWithSampleData()
        {
            dataGridView1.Rows.Add("Молоко", 1, 60.00);
            dataGridView1.Rows.Add("Хліб", 1, 30.00);
            dataGridView1.Rows.Add("Сир", 2, 150.00);
            dataGridView1.Rows.Add("Йогурт", 2, 40.00);
            dataGridView1.Rows.Add("Ковбаса", 3, 250.00);
        }

        // --- ЛОГІКА DELIVERY PLANNER ---
        private void button1_Click(object sender, EventArgs e)
        {
            var inputProducts = new List<Product>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                try
                {
                    inputProducts.Add(new Product
                    {
                        Name = row.Cells[0].Value?.ToString() ?? "Товар",
                        Deadline = int.Parse(row.Cells[1].Value?.ToString() ?? "0"),
                        Price = double.Parse(row.Cells[2].Value?.ToString() ?? "0")
                    });
                }
                catch { MessageBox.Show("Помилка в даних товарів!"); return; }
            }

            if (inputProducts.Count == 0) return;
            double minimalLoss;
            var results = CalculateSalesLogic(inputProducts, out minimalLoss);

            richTextBox1.Clear();
            foreach (var line in results) richTextBox1.AppendText(line + Environment.NewLine);
            textBox1.Text = minimalLoss.ToString("F2");
        }

        private List<string> CalculateSalesLogic(List<Product> products, out double minimalLoss)
        {
            var sorted = products.OrderBy(p => p.Deadline).ToList();
            var heap = new PriorityQueue<int, double>();
            for (int i = 0; i < sorted.Count; i++)
            {
                heap.Enqueue(i, sorted[i].Price);
                if (heap.Count > sorted[i].Deadline) heap.Dequeue();
            }

            bool[] soldFull = new bool[sorted.Count];
            double fullSum = 0, totalSum = 0;
            while (heap.Count > 0)
            {
                heap.TryDequeue(out int index, out double price);
                soldFull[index] = true;
                fullSum += price;
            }
            foreach (var p in sorted) totalSum += p.Price;
            minimalLoss = (totalSum - fullSum) * 0.5;

            return sorted.Select((p, i) =>
                $"{(soldFull[i] ? "[Повна]" : "[Уцінка]")} {p.Name}: {(soldFull[i] ? p.Price : p.Price * 0.5):F2}").ToList();
        }

        // --- ЛОГІКА ХАФФМАНА ---
        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            if (string.IsNullOrEmpty(text)) return;

            HuffmanCodec codec = new HuffmanCodec();

            // Тимчасово через файл, бо твій клас HuffmanCodec заточений під File.ReadAllText
            string tempPath = "huffman_temp.txt";
            File.WriteAllText(tempPath, text);

            if (codec.SetInputFile(tempPath))
            {
                codec.Compress();
                var codes = codec.GetCodes();

                // 1. Заповнюємо таблицю
                dataGridView2.Rows.Clear();
                foreach (var kvp in codes)
                {
                    string charDisplay = char.IsWhiteSpace(kvp.Key) ? "[Пробіл]" : kvp.Key.ToString();
                    dataGridView2.Rows.Add(charDisplay, kvp.Value);
                }

                // 2. Виводимо бінарний код у textBox3
                StringBuilder sb = new StringBuilder();
                foreach (char c in text) sb.Append(codes[c]);
                label1.Text = sb.ToString();
            }

            if (File.Exists(tempPath)) File.Delete(tempPath);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}