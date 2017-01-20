using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
        private readonly string _dayImage = Path.GetDirectoryName(Application.ExecutablePath) + "\\day.jpg";
        private readonly string _nightImage = Path.GetDirectoryName(Application.ExecutablePath) + "\\night.jpg";
        private Image _dayImageFile;
        private Image _nightImageFile;


        public Form1()
        {
            InitializeComponent();
            if (File.Exists(_dayImage))
            {
                File.Delete(_dayImage);
            };
            if (File.Exists(_nightImage))
            {
                File.Delete(_nightImage);
            };

            using (var wc = new WebClient())
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://c.tadst.com/gfx/sunrise.png", _dayImage);
                }
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://i.ytimg.com/vi/W8tVwiYsgHg/maxresdefault.jpg", _nightImage);
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Time();
        }

        private void Time()
        {
            var data = DateTime.Now;

            richTextBox1.Text = data.Hour.ToString();
            richTextBox2.Text = data.Minute.ToString();
            richTextBox3.Text = data.Second.ToString();

            if (data.Second % 2 == 0)
            {
                label1.Text = label2.Text = "";
            } else
            {
                label1.Text = label2.Text = ":";
            }

            if (data.Hour > 6 && data.Hour < 18)
            {
                _dayImageFile = new Bitmap(_dayImage);
                this.BackgroundImage = _dayImageFile;
            }
            else
            {
                _nightImageFile = new Bitmap(_nightImage);
                this.BackgroundImage = _nightImageFile;
            }

            if (_budzikStatus != true || _budzikHour != data.Hour || _budzikMinutes != data.Minute) return;

            _budzikStatus = false;
            budzikStatusDisplay.Text = "";
            MessageBox.Show(@"OBUDŹ SIĘ!", @"Alarm!");
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
            budzikStatusDisplay.Text = @"Budzik: " + _budzikHour + @":" + _budzikMinutes;
        }
    }
}
