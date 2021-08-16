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
    public partial class ex24 : Form
    {
        public ex24()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salariofixo = Convert.ToDouble(textBox2.Text);
            double vendastotais = Convert.ToDouble(textBox1.Text);
            double comissao = 0;
            
                double salariototal = 0;
            if (vendastotais < 1500)
            {
                comissao = (vendastotais * 0.03);
                salariototal = comissao + salariofixo;
                // fazer mb//
                MessageBox.Show("seu salário é de " + salariototal.ToString("C2"));
            }
            else
            {
                comissao = (1500 * 0.03);
                comissao += ((vendastotais - 1500) * 0.05);
                salariototal = comissao + salariofixo;
                MessageBox.Show("seu salário é de " + salariototal.ToString("C2"));
            }
        }
    }
}
