using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox1.Text = "";
            textBox2.Text = "";
            //Если хотите изменить размер матрицы, поменяйте значение переменных m и n.
            //m - кол-во строк
            //n - кол-во столбцов
            int m=3, n=5;
            int i, j;
            int[,] Matrix1 = new int[m, n];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Matrix1[i, j] = rnd.Next(10);
                    textBox1.Text += Matrix1[i, j]+"\t";
                }
                textBox1.Text +="\r\n";
            }
            for (j = 0; j < n ; j++)
            {
                for (i = 0; i < m; i++)
                {
                    textBox2.Text += Matrix1[i, j]+"\t";
                }
                textBox2.Text += "\r\n";
            }
        }
    }
}
