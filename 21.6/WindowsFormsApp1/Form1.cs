using System;
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
            textBox1.Text = "";
            int N = 6;
            int[,] Array = new int[N, N];
            int c = 1;
            for (int spin = 0; spin < N - 2; spin++)
            {
                for (int i = 0 + spin; i < N - spin; i++)
                {
                    Array[0 + spin, i] = c;
                    c++;
                }
                c--;
                for (int i = 0 + spin; i < N - spin; i++)
                {
                    Array[i, N - 1 - spin] = c;
                    c++;
                }
                c--;
                for (int i = N - 1 - spin; i >= 0 + spin; i--)
                {
                    Array[N - 1 - spin, i] = c;
                    c++;
                }
                c--;
                for (int i = N - 1 - spin; i >= 1 + spin; i--)
                {
                    Array[i, 0 + spin] = c;
                    c++;
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    textBox1.Text += Array[i, j] + "\t";
                }
                textBox1.Text += "\r\n";
            }
        }
    }
}
