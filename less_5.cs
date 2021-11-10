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
    public partial class less_5 : Form
    {
        public less_5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                // узнать как исправить чтобы выскакивала ошибка только один раз!
                double a = get_d();
                double b = get_d();
            

            switch (comboBox1.Text) {
                case "+":
                    textBox3.Text = Convert.ToString(a + b);
                    break;
                case "-":
                    textBox3.Text = Convert.ToString(a - b);
                    break;
                case "*":
                    textBox3.Text = Convert.ToString(a * b);
                    break;
                case "/":
                    if (b == 0) {
                        MessageBox.Show("На ноль делить нельзя!");
                    }
                    textBox3.Text = Convert.ToString(a / b);
                    break;
            }
             double get_d() {
                double d;
                try
                {
                    return d = Convert.ToDouble(textBox1.Text);
                }
                catch {
                    MessageBox.Show("Введите число");
                    return get_d();
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
        }
    }
}
