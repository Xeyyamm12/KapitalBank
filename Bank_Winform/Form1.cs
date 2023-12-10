using MessagingToolkit.QRCode.Codec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] pin = { 1531, 7514, 7522};

            int input = Convert.ToInt16(textBox1.Text);

            if (input == pin[0] || input == pin[1] || input == pin[2])
            {
                Form2 back = new Form2();
                back.ShowDialog();
            }
            else
            {
                label3.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}

