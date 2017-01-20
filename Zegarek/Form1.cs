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
        private bool _budzikStatus = false;
        private uint _budzikHour;
        private uint _budzikMinutes;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Time();
        }

        private void Time()
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

            if (_budzikStatus == true && _budzikHour == data.Hour && _budzikMinutes == data.Minute)
            {
                _budzikStatus = false;
                budzikStatusDisplay.Text = "";
                MessageBox.Show("OBUDŹ SIĘ!", "Alarm!");
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void budzik_Click(object sender, EventArgs e)
        {
            if (budzikH.Text == "" || budzikM.Text == "") return;
            try
            {
                _budzikHour = uint.Parse(budzikH.Text);
                _budzikMinutes = uint.Parse(budzikM.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                budzikH.Text = budzikM.Text = "";
            }
            _budzikStatus = true;
            budzikH.Text = budzikM.Text = "";
            budzikStatusDisplay.Text = "Budzik ustawiony na " + _budzikHour + ":" + _budzikMinutes;
        }
    }
}
