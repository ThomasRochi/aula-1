using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_1
{
    public partial class ex14 : Form
    {
        public ex14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);

            if (i < 10)
            {
                MessageBox.Show("é menor que 10");
            }
            else
            {
                MessageBox.Show("é maior que 10");
            }
        }
    }
}
