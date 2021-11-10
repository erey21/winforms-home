using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeforms5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //задание сравнение
        private void button1_Click(object sender, EventArgs e)
        {
            less_1 f1 = new less_1();
            f1.Show();
        }
        //задание равно 5 или 10
        private void button2_Click(object sender, EventArgs e)
        {
            less_2 f1 = new less_2();
            f1.Show();
        }
        //задание вклад в банк
        private void button3_Click(object sender, EventArgs e)
        {
            less_3 f1 = new less_3();
            f1.Show();
        }
        //задание вклад по месяцам
        private void button4_Click(object sender, EventArgs e)
        {
            less_4 f1 = new less_4();
            f1.Show();
        }
        //задание простой калькулятор
        private void button5_Click(object sender, EventArgs e)
        {
            less_5 f1 = new less_5();
            f1.Show();
        }
        //задание сортировка массива
        private void button6_Click(object sender, EventArgs e)
        {
            less_6 f1 = new less_6();
            f1.Show();
        }
        //задание разность элементов
        private void button7_Click(object sender, EventArgs e)
        {
            less_7 f1 = new less_7();
            f1.Show();
        }
        
    }
}
