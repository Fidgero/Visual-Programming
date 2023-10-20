namespace Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numberToFactorial = Convert.ToInt32(textBox1.Text);
                int number = 1;
                if (numberToFactorial < 0)
                {
                    label2.Text = "Factorial can't be negative";
                }
                else
                {
                    for (int i = 1; i <= numberToFactorial; i++)
                    {
                        number = number * i;
                    }
                    label2.Text = string.Empty;
                    label2.Text += number;
                }
            }
            catch
            {
                label2.Text = "Enter a number";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}