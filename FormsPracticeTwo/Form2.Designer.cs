namespace FormsPracticeTwo
{
    partial class Form2
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
            this.one = new System.Windows.Forms.TextBox();
            this.two = new System.Windows.Forms.TextBox();
            this.three = new System.Windows.Forms.TextBox();
            this.four = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(58, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(410, 13);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(100, 20);
            this.one.TabIndex = 2;
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(558, 13);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(100, 20);
            this.two.TabIndex = 3;
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(410, 49);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(100, 20);
            this.three.TabIndex = 4;
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(558, 49);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(100, 20);
            this.four.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(785, 213);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox one;
        private System.Windows.Forms.TextBox two;
        private System.Windows.Forms.TextBox three;
        private System.Windows.Forms.TextBox four;
        private System.Windows.Forms.Button button1;
    }
}