using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zegarek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            time();
        }

        private void time()
        {
            DateTime data = DateTime.Now;

            richTextBox1.Text = data.Hour.ToString();
            richTextBox2.Text = data.Minute.ToString();
            richTextBox3.Text = data.Second.ToString();

            if (data.Second % 2 == 0)
            {
                label1.Text = "";
                label2.Text = "";
            } else
            {
                label1.Text = ":";
                label2.Text = ":";
            }

            if (data.Second == 0)
            {
                MessageBox.Show("OBUDŹ SIĘ!", "Alarm!");
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
