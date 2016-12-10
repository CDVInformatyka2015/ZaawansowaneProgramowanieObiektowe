using System;
using System.Windows.Forms;

namespace Fibonnaciego
{
    public partial class Form1 : Form
    {
        Fibolo fibolo = new Fibolo(1, 1);
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fibolo = new Fibolo(1, 1);
            textBox1.Text = "1";
            textBox2.Text = "1";
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = fibolo.Number1.ToString();
            textBox2.Text = fibolo.Number2.ToString();
            textBox3.Text = fibolo.getResult().ToString();
            fibolo.Calculate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = fibolo.Number1.ToString();
            textBox2.Text = fibolo.Number2.ToString();
            textBox3.Text = fibolo.getReverseResult().ToString();
            fibolo.ReverseCalculate();
        }
    }
}
