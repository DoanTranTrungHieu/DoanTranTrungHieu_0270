using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoanTranTrungHieu_2121110270
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int kq = x + y;
            richTextBox1.Text = richTextBox1.Text + x.ToString() + " + " + y.ToString() + " = " + kq.ToString() + "\r\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int kq = x * y;
            richTextBox1.Text = richTextBox1.Text + x.ToString() + " * " + y.ToString() + " = " + kq.ToString() + "\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Caculator.txt",true);
            sw.Write(richTextBox1.Text);
            sw.Close();
        }
    }
}
