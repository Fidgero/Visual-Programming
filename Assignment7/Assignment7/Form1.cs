using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class Form1 : Form
    {
        int rightAnswerCount = 0;
        int mistakesCount = 0;
        string[] mistakesInExam = new string[20];
        string[] rightAnswer = new string[20] {"b"  //1
                                            , "d"   //2
                                            , "a"   //3
                                            , "a"   //4
                                            , "c"   //5
                                            , "a"   //6
                                            , "b"   //7
                                            , "a"   //8
                                            , "c"   //9
                                            , "d"   //10
                                            , "b"   //11
                                            , "c"   //12
                                            , "d"   //13
                                            , "a"   //14
                                            , "d"   //15
                                            , "c"   //16
                                            , "c"   //17
                                            , "b"   //18
                                            , "d"   //19
                                            , "a" };//20
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("C:\\Users\\Matvei\\source\\repos\\Visual-Programming\\TestForAssignment7.txt");

            for (int i = 0; i < 20; i++)
            {
                if (lines[i] == rightAnswer[i])
                {
                    rightAnswerCount++;
                    mistakesInExam[i] = lines[i] + "    Correct";
                }
                else
                {
                    mistakesCount++;
                    mistakesInExam[i] = lines[i];
                }
            }

            try
            {
                textBox1.Text = rightAnswerCount.ToString();
                textBox2.Text = mistakesCount.ToString();
                
                for (int i = 0; i < 20; i++)
                {
                    label3.Text += rightAnswer[i] + "\n";
                    label4.Text += mistakesInExam[i] + "\n";
                }

            } catch { }
        }
    }
}
