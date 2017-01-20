namespace Zegarek
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.budzikH = new System.Windows.Forms.RichTextBox();
            this.budzikM = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.budzik = new System.Windows.Forms.Button();
            this.budzikStatusDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.MaxLength = 2;
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.richTextBox2.Location = new System.Drawing.Point(166, 12);
            this.richTextBox2.MaxLength = 2;
            this.richTextBox2.Multiline = false;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox2.Size = new System.Drawing.Size(100, 96);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Enabled = false;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.richTextBox3.Location = new System.Drawing.Point(320, 12);
            this.richTextBox3.MaxLength = 2;
            this.richTextBox3.Multiline = false;
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox3.Size = new System.Drawing.Size(100, 96);
            this.richTextBox3.TabIndex = 2;
            this.richTextBox3.Text = "";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 114);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(166, 114);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 23);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(316, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(118, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 63);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(272, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 63);
            this.label2.TabIndex = 7;
            this.label2.Text = ":";
            // 
            // budzikH
            // 
            this.budzikH.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.budzikH.Location = new System.Drawing.Point(12, 143);
            this.budzikH.MaxLength = 2;
            this.budzikH.Multiline = false;
            this.budzikH.Name = "budzikH";
            this.budzikH.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.budzikH.Size = new System.Drawing.Size(100, 96);
            this.budzikH.TabIndex = 8;
            this.budzikH.Text = "";
            // 
            // budzikM
            // 
            this.budzikM.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.budzikM.Location = new System.Drawing.Point(166, 143);
            this.budzikM.MaxLength = 2;
            this.budzikM.Multiline = false;
            this.budzikM.Name = "budzikM";
            this.budzikM.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.budzikM.Size = new System.Drawing.Size(100, 96);
            this.budzikM.TabIndex = 9;
            this.budzikM.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(118, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 63);
            this.label3.TabIndex = 10;
            this.label3.Text = ":";
            // 
            // budzik
            // 
            this.budzik.Location = new System.Drawing.Point(272, 181);
            this.budzik.Name = "budzik";
            this.budzik.Size = new System.Drawing.Size(100, 23);
            this.budzik.TabIndex = 11;
            this.budzik.Text = "Ustaw budzik";
            this.budzik.UseVisualStyleBackColor = true;
            this.budzik.Click += new System.EventHandler(this.budzik_Click);
            // 
            // budzikStatusDisplay
            // 
            this.budzikStatusDisplay.AutoSize = true;
            this.budzikStatusDisplay.Location = new System.Drawing.Point(269, 207);
            this.budzikStatusDisplay.Name = "budzikStatusDisplay";
            this.budzikStatusDisplay.Size = new System.Drawing.Size(0, 13);
            this.budzikStatusDisplay.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 349);
            this.Controls.Add(this.budzikStatusDisplay);
            this.Controls.Add(this.budzik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.budzikM);
            this.Controls.Add(this.budzikH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox budzikH;
        private System.Windows.Forms.RichTextBox budzikM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button budzik;
        private System.Windows.Forms.Label budzikStatusDisplay;
    }
}

