namespace Bank_Winform
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = System.Drawing.Color.Black;
            button1.Location = new System.Drawing.Point(52, 295);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(422, 93);
            button1.TabIndex = 1;
            button1.Text = "Xidmətlər";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Location = new System.Drawing.Point(52, 597);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(422, 93);
            button2.TabIndex = 2;
            button2.Text = "English";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ForeColor = System.Drawing.Color.Black;
            button3.Location = new System.Drawing.Point(747, 295);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(422, 93);
            button3.TabIndex = 3;
            button3.Text = "Nağdlaşırma (AZN)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.ForeColor = System.Drawing.Color.Black;
            button4.Location = new System.Drawing.Point(747, 452);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(422, 93);
            button4.TabIndex = 4;
            button4.Text = "Hesabdan çıxış";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(421, 195);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(389, 41);
            label2.TabIndex = 5;
            label2.Text = "Xaiş edirik əməliyyat seçin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.White;
            label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
            label1.Location = new System.Drawing.Point(88, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(389, 81);
            label1.TabIndex = 6;
            label1.Text = "Kapital Bank";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.White;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(-36, -17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1277, 124);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(1032, 76);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(173, 20);
            label4.TabIndex = 8;
            label4.Text = "Daima xidmətinizdəyik!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label3.Location = new System.Drawing.Point(1066, 26);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(139, 41);
            label3.TabIndex = 7;
            label3.Text = "1020 yes";
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(18F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Firebrick;
            ClientSize = new System.Drawing.Size(1228, 757);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.Color.White;
            Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            Name = "Form2";
            Text = " Əsas menyu";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}