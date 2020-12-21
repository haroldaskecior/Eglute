using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int k = 0;
            int Size;
            int Asterisk = 1;
            int Spacing;
            if (Int32.TryParse(textBox2.Text, out Size) && Size > 0)
            {
                Spacing = Size;
                do
                {
                    for (int i = 1; i < Spacing; i++)
                    {
                        richTextBox1.AppendText(" ");
                    }
                    for (int i = 0; i < Asterisk; i++)
                    {
                        richTextBox1.AppendText("* ");
                    }
                    richTextBox1.AppendText("\n");
                    Spacing--;
                    Asterisk++;
                    k++;
                } while (k < Size);
            }
        }
        public int[] Sk = new int[10];
        public int n = 0;

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (Int32.TryParse(textBox1.Text, out Sk[n]))
                {
                    n++;
                    richTextBox2.Text = (1 + ".\t" + Sk[0] + "\n");
                    for (int i = 1; i < n; i++)
                    {
                        richTextBox2.AppendText(i + 1 + ".\t" + Sk[i] + "\n");

                    }
                }
            }
            catch (IndexOutOfRangeException) { n = 0; richTextBox2.Clear();}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (n < 10)
            {
                MessageBox.Show("Iveskite 10 skaiciu");
            }
            else
            {
                int i = 0;
                int sum = 0;
                while (true)
                {
                    sum += Sk[i];
                    i++;
                    if (i == n) break;
                }
                richTextBox2.Text = "Suvestu skaiciu suma = \t" + sum;
            }
        }
    }
        
}
