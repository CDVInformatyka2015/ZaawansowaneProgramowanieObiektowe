namespace PrzelicznikFahrenheit
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
            this.celsjusz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fahrenheit = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.showCelsjusz = new System.Windows.Forms.Button();
            this.showFahrenheit = new System.Windows.Forms.Button();
            this.CtoF = new System.Windows.Forms.Button();
            this.FtoC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // celsjusz
            // 
            this.celsjusz.Location = new System.Drawing.Point(12, 25);
            this.celsjusz.Name = "celsjusz";
            this.celsjusz.Size = new System.Drawing.Size(100, 20);
            this.celsjusz.TabIndex = 0;
            this.celsjusz.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Celsjusz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fahrenheit";
            // 
            // fahrenheit
            // 
            this.fahrenheit.Location = new System.Drawing.Point(214, 25);
            this.fahrenheit.Name = "fahrenheit";
            this.fahrenheit.Size = new System.Drawing.Size(100, 20);
            this.fahrenheit.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 51);
            this.progressBar1.Maximum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(464, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 100;
            // 
            // showCelsjusz
            // 
            this.showCelsjusz.Location = new System.Drawing.Point(320, 22);
            this.showCelsjusz.Name = "showCelsjusz";
            this.showCelsjusz.Size = new System.Drawing.Size(75, 23);
            this.showCelsjusz.TabIndex = 5;
            this.showCelsjusz.Text = "Show C";
            this.showCelsjusz.UseVisualStyleBackColor = true;
            this.showCelsjusz.Click += new System.EventHandler(this.showCelsjusz_Click);
            // 
            // showFahrenheit
            // 
            this.showFahrenheit.Location = new System.Drawing.Point(401, 22);
            this.showFahrenheit.Name = "showFahrenheit";
            this.showFahrenheit.Size = new System.Drawing.Size(75, 23);
            this.showFahrenheit.TabIndex = 6;
            this.showFahrenheit.Text = "Show F";
            this.showFahrenheit.UseVisualStyleBackColor = true;
            this.showFahrenheit.Click += new System.EventHandler(this.showFahrenheit_Click);
            // 
            // CtoF
            // 
            this.CtoF.Location = new System.Drawing.Point(118, 25);
            this.CtoF.Name = "CtoF";
            this.CtoF.Size = new System.Drawing.Size(43, 23);
            this.CtoF.TabIndex = 7;
            this.CtoF.Text = "C > F";
            this.CtoF.UseVisualStyleBackColor = true;
            this.CtoF.Click += new System.EventHandler(this.CtoF_Click);
            // 
            // FtoC
            // 
            this.FtoC.Location = new System.Drawing.Point(167, 25);
            this.FtoC.Name = "FtoC";
            this.FtoC.Size = new System.Drawing.Size(41, 23);
            this.FtoC.TabIndex = 8;
            this.FtoC.Text = "F > C";
            this.FtoC.UseVisualStyleBackColor = true;
            this.FtoC.Click += new System.EventHandler(this.FtoC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "-100 stopni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "0 stopni";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "100 stopni";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 98);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FtoC);
            this.Controls.Add(this.CtoF);
            this.Controls.Add(this.showFahrenheit);
            this.Controls.Add(this.showCelsjusz);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fahrenheit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.celsjusz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox celsjusz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fahrenheit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button showCelsjusz;
        private System.Windows.Forms.Button showFahrenheit;
        private System.Windows.Forms.Button CtoF;
        private System.Windows.Forms.Button FtoC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

