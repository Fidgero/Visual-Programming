namespace Assignment5
{
    public partial class Form1 : Form
    {

        Random rand = new Random();
        int number = 0;
        int guesses = 0;

        public Form1()
        {
            InitializeComponent();

            loadQuestions();
        }

        private void loadQuestions()
        {
            number = rand.Next(1, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(textBox1.Text);

                guesses++;

                if (i == number)
                {
                    MessageBox.Show("You win, count of guesses: " + guesses);
                    loadQuestions();
                    textBox1.Text = "";
                    guesses = 0;
                }
                else if (i < number)
                {
                    MessageBox.Show("Too low, try again");
                }
                else
                {
                    MessageBox.Show("too high, try again");
                }
            }
            catch
            {
                MessageBox.Show("Enter a number");
            }
        }
    }
}