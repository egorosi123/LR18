using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = 11;
            double[] Array = new double[size];
            textBox1.Text = "";
            textBox2.Text = "";
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = Math.Pow(2, i);
                textBox1.Text+=Array[i]+" ";
            }
            for (int i = size-1; i >= 0; i--)
            {
                textBox2.Text += Array[i]+" ";
            }
        }

    }
}
