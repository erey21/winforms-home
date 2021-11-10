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
    public partial class less_6 : Form
    {
        public less_6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(element.Text);
            List<int> chet = new List<int>();
            List<int> ne_chet = new List<int>();
            Random r = new Random();
            int[] array = new int[num];
            for (int i = 0; i < num; i++) {
                array[i] = r.Next(-100, 101);
                if (array[i] % 2 == 0)
                {
                    chet.Add(array[i]);
                }
                else {
                    ne_chet.Add(array[i]);
                }
            }
            string chet_ar = "";
            string nchet_ar = "";
            foreach (int item in chet)
            {
                chet_ar += item + " ";
            }
            foreach (int i in ne_chet) {
                nchet_ar += i + " ";
            }

            MessageBox.Show($"Массив чётных чисел: {chet_ar}. \nМассив нечётных чисел: {nchet_ar}");



        }
    }
}
