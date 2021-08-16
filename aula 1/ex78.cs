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
    public partial class ex78 : Form
    {
        public ex78()
        {
            InitializeComponent();
        }
        List<string> names = new List<string>();
        int c = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (c >= 10)
            {
                MessageBox.Show("para com essa p0r@ mermão");
                return;
            }
            names.Add(textBox1.Text);
            c++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool verificacao = names.Contains(textBox1.Text);
            if (verificacao)
            {
                MessageBox.Show("ACHEI");
            }
            else
            {
                MessageBox.Show("NÃO ACHEI");
            }
        }
    }
}
