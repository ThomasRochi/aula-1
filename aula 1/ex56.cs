using System;
using System.Windows.Forms;

namespace aula_1
{
    public partial class ex56 : Form
    {
        public ex56()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //vadad
            double num = Convert.ToDouble(textBox1.Text);
            string tab = "";

            for (int i = 1; i <= 10; i++) 
            {
                tab += (num * i).ToString() + "\r\n";
            }

            MessageBox.Show(tab);
        }
    }
}
