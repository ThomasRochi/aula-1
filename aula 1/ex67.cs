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
    public partial class ex67 : Form
    {
        public ex67()
        {
            InitializeComponent();
            button1.Text = "números";
        }

        private void button1_Click(object sender, EventArgs e)
        {
                int c = 0;
            string numeros = "";
            double soma = 0;
            for (int i = 15; i <= 100; i++)
            {
                numeros += i.ToString() + "\r\n";
                c++;
                soma = soma + i;//
                
                
            }
            double media = soma / c;

            MessageBox.Show(media.ToString());
        }

       
    }
}
