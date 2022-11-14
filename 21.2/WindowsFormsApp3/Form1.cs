using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = Math.Pow(2, i);
                textBox1.Text+=Array[i]+" ";
            }
        }
    }
}
