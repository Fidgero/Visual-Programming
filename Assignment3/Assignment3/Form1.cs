namespace Assignment3
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string status = "";
            float weight = float.Parse(textBox1.Text);
            float height = float.Parse(textBox2.Text);
            float BMI = weight / (height * height);
            if (BMI > 25)
            {
                status = "overweight";
            } else if (BMI < 18.5)
            {
                status = "underweight";
            } else
            {
                status = "ok";
            }
            label3.Text = string.Empty;
            label3.Text = "BMI: " + BMI + "\rStatus: " + status;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}