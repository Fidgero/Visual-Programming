using System;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int number = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text.ToLower();
                string userChoice = char.ToUpper(input[0]) + input.Substring(1);
                int i = 0;
                number = rand.Next(1, 3);
                string gameChoice = "";

                if (input == "rock")
                {
                    i = 1;
                }
                else if (input == "paper")
                {
                    i = 2;
                }
                else if (input == "scissors")
                {
                    i = 3;
                }
                else
                {
                    MessageBox.Show("Entere Rock, Paper or Scissors");
                }

                if (number == 1)
                {
                    gameChoice = "Rock";
                }
                else if (number == 2)
                {
                    gameChoice = "Paper";
                }
                else
                {
                    gameChoice = "Scissors";
                }

                if (i == number)
                {
                    MessageBox.Show("Its a draw");
                    textBox1.Text = "";
                }
                else if (i == 1 && number == 2 || i == 3 && number == 1 || i == 2 && number == 3)
                {
                    MessageBox.Show("Your choice was: " + userChoice + ", My coice was: " + gameChoice + "\n" + "I win, let's try one more time");
                    textBox1.Text = "";
                }
                else if (i == 1 && number == 3 || i == 2 && number == 1 || i == 3 && number == 2)
                {
                    MessageBox.Show("Your choice was: " + userChoice + ", My coice was: " + gameChoice + "\n" + "You win, I want one more play");
                    textBox1.Text = "";
                }

            }
            catch
            {
                MessageBox.Show("Entere Rock, Paper or Scissors");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
