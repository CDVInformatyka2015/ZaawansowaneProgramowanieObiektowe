﻿using System;
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
            fahrenheit.Text = temperature.toStringFahrenheit(celsjusz.Text);
        }

        private void FtoC_Click(object sender, EventArgs e)
        {
            celsjusz.Text = temperature.toStringCelsjusz(fahrenheit.Text);
        }

        private void showCelsjusz_Click(object sender, EventArgs e)
        {
            toProgressBar(celsjusz.Text);
        }

        private void showFahrenheit_Click(object sender, EventArgs e)
        {
            toProgressBar(fahrenheit.Text);
        }

        private void toProgressBar(string value)
        {
            int temp = (int)double.Parse(value);
            if (temp > 100)
            {
                progressBar1.Value = 200;
                return;
            }

            progressBar1.Value = temp + 100;
        }
    }
}
