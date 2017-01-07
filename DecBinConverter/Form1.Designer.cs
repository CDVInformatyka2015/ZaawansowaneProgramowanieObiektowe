namespace DecBinConverter
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bin1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bin2 = new System.Windows.Forms.TextBox();
            this.bin3 = new System.Windows.Forms.TextBox();
            this.bin4 = new System.Windows.Forms.TextBox();
            this.bin5 = new System.Windows.Forms.TextBox();
            this.bin6 = new System.Windows.Forms.TextBox();
            this.bin7 = new System.Windows.Forms.TextBox();
            this.bin8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(152, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Decimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Binary";
            // 
            // bin1
            // 
            this.bin1.Location = new System.Drawing.Point(12, 80);
            this.bin1.MaxLength = 1;
            this.bin1.Name = "bin1";
            this.bin1.Size = new System.Drawing.Size(25, 20);
            this.bin1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Convert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bin2
            // 
            this.bin2.Location = new System.Drawing.Point(43, 80);
            this.bin2.MaxLength = 1;
            this.bin2.Name = "bin2";
            this.bin2.Size = new System.Drawing.Size(25, 20);
            this.bin2.TabIndex = 14;
            // 
            // bin3
            // 
            this.bin3.Location = new System.Drawing.Point(74, 80);
            this.bin3.MaxLength = 1;
            this.bin3.Name = "bin3";
            this.bin3.Size = new System.Drawing.Size(25, 20);
            this.bin3.TabIndex = 15;
            // 
            // bin4
            // 
            this.bin4.Location = new System.Drawing.Point(105, 80);
            this.bin4.MaxLength = 1;
            this.bin4.Name = "bin4";
            this.bin4.Size = new System.Drawing.Size(25, 20);
            this.bin4.TabIndex = 16;
            // 
            // bin5
            // 
            this.bin5.Location = new System.Drawing.Point(136, 80);
            this.bin5.MaxLength = 1;
            this.bin5.Name = "bin5";
            this.bin5.Size = new System.Drawing.Size(25, 20);
            this.bin5.TabIndex = 17;
            // 
            // bin6
            // 
            this.bin6.Location = new System.Drawing.Point(167, 80);
            this.bin6.MaxLength = 1;
            this.bin6.Name = "bin6";
            this.bin6.Size = new System.Drawing.Size(25, 20);
            this.bin6.TabIndex = 18;
            // 
            // bin7
            // 
            this.bin7.Location = new System.Drawing.Point(198, 80);
            this.bin7.MaxLength = 1;
            this.bin7.Name = "bin7";
            this.bin7.Size = new System.Drawing.Size(25, 20);
            this.bin7.TabIndex = 19;
            // 
            // bin8
            // 
            this.bin8.Location = new System.Drawing.Point(229, 80);
            this.bin8.MaxLength = 1;
            this.bin8.Name = "bin8";
            this.bin8.Size = new System.Drawing.Size(25, 20);
            this.bin8.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 136);
            this.Controls.Add(this.bin8);
            this.Controls.Add(this.bin7);
            this.Controls.Add(this.bin6);
            this.Controls.Add(this.bin5);
            this.Controls.Add(this.bin4);
            this.Controls.Add(this.bin3);
            this.Controls.Add(this.bin2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bin1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bin1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox bin2;
        private System.Windows.Forms.TextBox bin3;
        private System.Windows.Forms.TextBox bin4;
        private System.Windows.Forms.TextBox bin5;
        private System.Windows.Forms.TextBox bin6;
        private System.Windows.Forms.TextBox bin7;
        private System.Windows.Forms.TextBox bin8;
    }
}

