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
    public partial class less_3 : Form
    {
        public less_3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(summa.Text);
            if (sum < 100)
            {
                MessageBox.Show($"Сумма возврата составит: {sum += sum * 0.05}.\nСумма возврата с бонусом составит: {sum += sum * 0.05 + 15}.");               
            }
            else if (sum < 200)
            {
                MessageBox.Show($"Сумма возврата составит: {sum += sum * 0.07}.\nСумма возврата с бонусом составит: {sum += sum * 0.07 + 15}.");
            }
            else {
                MessageBox.Show($"Сумма возврата составит: {sum += sum * 0.1}.\nСумма возврата с бонусом составит: {sum += sum * 0.1 + 15}.");
            }
        }
    }
}
