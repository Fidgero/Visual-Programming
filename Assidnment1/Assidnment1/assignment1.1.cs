namespace Assidnment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "1 card";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "2 card";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "3 card";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "4 card";
        }
    }
}