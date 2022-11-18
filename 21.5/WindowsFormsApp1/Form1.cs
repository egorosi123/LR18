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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            Random random = new Random();
            int[,] Array1 = new int[3, 3];
            int i2 = 0, j2 = 0;
            int Width1 = Array1.GetLength(1);
            int Height1 = Array1.GetLength(0);
            int[,] EditedArray = new int[2, 2];
            int Width2 = EditedArray.GetLength(1);
            int Height2 = EditedArray.GetLength(0);
            Console.WriteLine("Массив:");
            for (int i = 0; i < Height1; i++)
            {
                for (int j = 0; j < Width1; j++)
                {
                    Array1[i, j] = random.Next(10);
                    textBox1.Text+=(Array1[i, j] + "\t");
                }
                textBox1.Text+="\r\n";
            }
            int stolbec = random.Next(3);
            int stroka = random.Next(3);
            label2.Text="Удаляемая строка: " + (stroka + 1) + "\r\n"+"Удаляемый столбец: " + (stolbec + 1) + "\r\n";
            for (int i = 0; i < Height1; i++)
            {
                if (i == stroka) continue;
                j2 = 0;
                for (int j = 0; j < Width1; j++)
                {
                    if (j == stolbec) continue;
                    EditedArray[i2, j2] = Array1[i, j];
                    j2++;
                }
                i2++;
            }
            for (int i = 0; i < Height2; i++)
            {
                for (int j = 0; j < Width2; j++)
                {
                    textBox2.Text+=(EditedArray[i, j] + "\t");
                }
                textBox2.Text+="\r\n";
            }

        }
    }
}
