namespace Assignment2
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int classA = Convert.ToInt32(textBox1.Text);
            int priceA = classA * 15;
            textBox4.Text = string.Empty;
            textBox4.Text += priceA;

            int classB = Convert.ToInt32(textBox2.Text);
            int priceB = classB * 12;
            textBox5.Text = string.Empty;
            textBox5.Text += priceB;

            int classC = Convert.ToInt32(textBox3.Text);
            int priceC = classC * 9;
            textBox6.Text = string.Empty;
            textBox6.Text += priceC;


            textBox7.Text = string.Empty;
            textBox7.Text += priceA + priceB + priceC;
        }
    }
}