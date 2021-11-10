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
    public partial class less_1 : Form
    {
        public less_1()
        {
            InitializeComponent();
        }

        private void less_1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(num1.Text);
            int b = Convert.ToInt32(num2.Text);
            if (a > b)
            {
                MessageBox.Show("Первое число больше второго!");
            }
            else if (a < b)
            {
                MessageBox.Show("Второе число больше первого!");
            }
            else {
                MessageBox.Show("Числа равны!");
            }
        }
    }
}
