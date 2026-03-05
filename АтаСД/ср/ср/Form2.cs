using cp.data_structures;
using sort;
using static cp.data_structures.DoublyLinkedList;

namespace ср
{


    public partial class Form2 : Form
    {
        private DoublyList myList = new DoublyList();
        private TextBox[] inputs;

        private List<ShopItem> shopList = new List<ShopItem>();

        public Form2()
        {
            InitializeComponent();

            inputs = new TextBox[] { textBox2, textBox3, textBox4, textBox5, textBox6 };
            ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int val))
            {
                myList.add(val);
                RefreshTable();
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int val))
            {
                bool isDeleted = myList.remove(val);

                if (!isDeleted)
                {
                    MessageBox.Show($"Значення {val} не знайдено");
                }
                ;
                RefreshTable();
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void RefreshTable()
        {
            dataGridView1.Rows.Clear();


            var current = myList.head;

            while (current != null)
            {
                dataGridView1.Rows.Add(
                    current.value,
                    current.prev?.value.ToString() ?? "null",
                    current.next?.value.ToString() ?? "null"
                );
                current = current.next;
            }
        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inputs.Any(tb => string.IsNullOrWhiteSpace(tb.Text)))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля!");
                return;
            }

            var newItem = new ShopItem
            {
                Name = textBox2.Text,
                Address = textBox3.Text,
                Product = textBox4.Text,
                Quantity = int.Parse(textBox5.Text),
                Price = double.Parse(textBox6.Text)
            };

            shopList.Add(newItem);
            RefreshShopTable();

            Array.ForEach(inputs, tb => tb.Clear());
        }

        private void RefreshShopTable()
        {
            dataGridView2.Rows.Clear();
            foreach (var item in shopList)
            {
                dataGridView2.Rows.Add(item.Name, item.Address, item.Product, item.Quantity, item.Price);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (shopList.Count < 2) return;

            List<double> prices = shopList.Select(x => x.Price).ToList();

            List<double> sortedPrices = HeapSort.sort(prices);

            List<ShopItem> sortedList = new List<ShopItem>();

            foreach (double price in sortedPrices)
            {
                var item = shopList.FirstOrDefault(x => x.Price == price);
                if (item != null)
                {
                    sortedList.Add(item);
                    shopList.Remove(item);
                }
            }

            shopList = sortedList;
            RefreshShopTable();
        }
    }


    public class ShopItem
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}