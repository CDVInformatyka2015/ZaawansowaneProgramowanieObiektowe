using System;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Silnia
{
    public partial class Form1 : Form
    {
        int wynik = 1;
        int krok = 0;

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
            int r = 0;

            try
            {
                r = int.Parse(textBox1.Text);
            }
            catch
            {
                textBox1.Clear();
                return;
            }

            krok = (r > 0 && krok == 0) ? krok = 100 / r : krok;

            if (krok < 100)
            {
                progressBar1.Value += krok;
            }
            else
            {
                Console.Beep();
                MessageBox.Show("KONIEC!");
            }

            wynik = (r != 0) ? wynik * r : wynik;
            textBox1.Text = (r - 1).ToString();
            textBox2.Text = wynik.ToString();
        }
    }
}
