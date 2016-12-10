using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzelicznikFahrenheit
{
    public partial class Form1 : Form
    {
        Temperature temperature = new Temperature();

        public Form1()
        {
            InitializeComponent();
            fahrenheit.Text = temperature.toFahrenheit(0).ToString();
        }

        private void CtoF_Click(object sender, EventArgs e)
        {
            fahrenheit.Text = temperature.toFahrenheit(double.Parse(celsjusz.Text)).ToString();
        }

        private void FtoC_Click(object sender, EventArgs e)
        {
            celsjusz.Text = temperature.toCelsjusz(double.Parse(fahrenheit.Text)).ToString();
        }

        private void showCelsjusz_Click(object sender, EventArgs e)
        {
            toProgressBar((int)double.Parse(celsjusz.Text));
        }

        private void showFahrenheit_Click(object sender, EventArgs e)
        {
            toProgressBar((int)double.Parse(fahrenheit.Text));
        }

        private void toProgressBar(int value)
        {
            if (value > 100)
            {
                progressBar1.Value = 200;
                return;
            }

            progressBar1.Value = value + 100;
        }
    }
}
