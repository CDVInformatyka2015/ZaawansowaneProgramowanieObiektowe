using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DecBinConverter
{
    public partial class Form1 : Form
    {
        HexConverter converter = new HexConverter();
        List<TextBox> textBoxes = new List<TextBox>();

        public Form1()
        {
            InitializeComponent();
            textBoxes.Add(bin1);
            textBoxes.Add(bin2);
            textBoxes.Add(bin3);
            textBoxes.Add(bin4);
            textBoxes.Add(bin5);
            textBoxes.Add(bin6);
            textBoxes.Add(bin7);
            textBoxes.Add(bin8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bin = converter.DecToBin(textBox1.Text);
            textBox2.Text = bin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string suma = "";
            foreach (TextBox item in textBoxes) {
                 suma += item.Text;
            }
            textBox1.Text = converter.BinToDec(suma);
        }
    }
}
