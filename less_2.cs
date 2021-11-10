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
    public partial class less_2 : Form
    {
        public less_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(num.Text);
            switch (n) {
                case 5:
                    MessageBox.Show("Число равно 5");
                    break;
                case 10:
                    MessageBox.Show("Число равно 10");
                    break;
                default:
                    MessageBox.Show("Неизвестное число");
                    break;
            }
        }
    }
}
