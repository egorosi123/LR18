using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            try
            {
                int[] Array = new int[int.Parse(textBox3.Text)];
                textBox1.Text = "";
                textBox2.Text = "";
                for (int i = 0; i < Array.Length; i++)
                {
                    Array[i] = random.Next(10);
                    textBox1.Text += Array[i]+" ";
                }
                for (int i = Array.Length-1; i >=0; i--)
                {
                    textBox2.Text += Array[i]+" ";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректное кол-во элементов массива", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
