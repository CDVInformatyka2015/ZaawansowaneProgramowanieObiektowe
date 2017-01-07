using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DecBinConverter
{
    public partial class Form1 : Form
    {
        HexConverter converter = new HexConverter();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bin = converter.DecToBin(textBox1.Text);
            textBox2.Text = bin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string suma = "";
            for (int i = 1; i < 9; i++)
            {
                TextBox box = (TextBox)Controls["bin" + i];
                suma += box.Text;
            }
            textBox1.Text = converter.BinToDec(suma);
        }
    }
}
