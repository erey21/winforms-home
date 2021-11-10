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
    public partial class less_4 : Form
    {
        public less_4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(summa.Text);
            double months = Convert.ToDouble(month.Text);
            for (int i = 0; i < months; i++)
            {
                sum += sum * 0.07;
            }
            MessageBox.Show($"Сумма вклада через {months} месяцев составит {sum}");

        }
    }
}
