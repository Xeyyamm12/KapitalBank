namespace Bank_Winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 25.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(458, 125);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(345, 60);
            label1.TabIndex = 0;
            label1.Text = "Xoş Gəlmişsiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(379, 316);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(522, 41);
            label2.TabIndex = 1;
            label2.Text = "Xaiş edirik PİN kodunuzu daxil edin";
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.Firebrick;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            textBox1.Location = new System.Drawing.Point(534, 382);
            textBox1.MaxLength = 4;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.PlaceholderText = "OOOO";
            textBox1.Size = new System.Drawing.Size(184, 80);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(464, 504);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(339, 41);
            label3.TabIndex = 3;
            label3.Text = "PİN kodunuz yalnışdır!";
            // 
            // button1
            // 
            button1.ForeColor = System.Drawing.Color.Black;
            button1.Location = new System.Drawing.Point(534, 593);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(197, 60);
            button1.TabIndex = 4;
            button1.Text = "Təstiq edin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 25.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(438, 209);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(381, 60);
            label4.TabIndex = 5;
            label4.Text = "Hörmətli müştəri";
            // 
            // button2
            // 
            button2.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
            button2.Location = new System.Drawing.Point(795, 399);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(81, 63);
            button2.TabIndex = 6;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(18F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Firebrick;
            ClientSize = new System.Drawing.Size(1228, 757);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.SystemColors.HighlightText;
            Margin = new System.Windows.Forms.Padding(6);
            Name = "Form1";
            Text = "Giris";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}
