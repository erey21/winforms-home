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
    public partial class less_7 : Form
    {
        public less_7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int n = Convert.ToInt32(num.Text);

            double[] array = new double[n];
            for (int i = 0; i < n; i++) {
                array[i] = r.Next(-100, 101);
            }
            MessageBox.Show($"Максимальный элемент сгенерированного массива: {array.Max()}.\nМинимальный элемент сгенерированного массива: {array.Min()}.\nРазность между ними = {array.Max() - array.Min()}");


        }
    }
}
