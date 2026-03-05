namespace ср
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new();

            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();

            form.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();

            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();

            
            form.Show();
        }
    }
}
