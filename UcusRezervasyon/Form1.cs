namespace UcusRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nereden: " + comboBox1.Text + "   " + "Nereye: " + comboBox2.Text + "   " + "Uçuþ Zamaný: " + dateTimePicker1.Text + "   " + "Ýsim Soyisim: " + textBox1.Text + "   " + "TC: " + maskedTextBox1.Text + "   " + "Telefon: " + maskedTextBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label8.Text;
        }
    }
}