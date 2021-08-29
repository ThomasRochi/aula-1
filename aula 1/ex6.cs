using System;
using System.Windows.Forms;

namespace aula_1
{
    public partial class ex6 : Form
    {
        public ex6()
        {
            InitializeComponent();
            button1.Text = "aplicar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            double j = Convert.ToDouble(textBox2.Text);
            double area = (i * j) / 2;
            MessageBox.Show(area.ToString());
        }




    }
}
