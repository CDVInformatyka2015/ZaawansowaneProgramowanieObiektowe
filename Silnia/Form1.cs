using System;
using System.Threading;
using System.Windows.Forms;

namespace Silnia
{
    public partial class Form1 : Form
    {
        long wynik = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            wynik = 1;
        }

        private void liczButton_Click(object sender, EventArgs e)
        {
            long r = long.Parse(textBox1.Text);
            wynik = (r != 0) ? wynik * r : wynik;
            textBox1.Text = (r - 1).ToString();
            textBox2.Text = wynik.ToString();
        }
    }
}
