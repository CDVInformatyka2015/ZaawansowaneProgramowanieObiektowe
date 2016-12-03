using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private bool fullmode = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void guzik_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = Color.Aquamarine;

            Form1.ActiveForm.FormBorderStyle = Form1.ActiveForm.FormBorderStyle == FormBorderStyle.None ? FormBorderStyle.Fixed3D : FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fullScreenMode_Click(object sender, EventArgs e)
        {
            this.GoFullscreen(!fullmode);
        }

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
    }
}
