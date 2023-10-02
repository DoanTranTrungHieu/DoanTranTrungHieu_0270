using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanTranTrungHieu_2121110270
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        float data1, data2;
        string pheptinh;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "1";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "2";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "3";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "4";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "5";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "9";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            pheptinh = "cong";
            data1 = float.Parse(textBox2.Text);
            textBox1.Text = data1.ToString() + "+";
            textBox2.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + ".";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (pheptinh == "cong")
            {
                data2 = data1 + float.Parse(textBox2.Text);
                textBox1.Text = data1.ToString() + "+" + float.Parse(textBox2.Text) + "=";
                textBox2.Text = data2.ToString();
            }
            if (pheptinh == "tru")
            {
                data2 = data1 - float.Parse(textBox2.Text);
                textBox1.Text = data1.ToString() + "-" + float.Parse(textBox2.Text) + "=";
                textBox2.Text = data2.ToString();
            }
            if (pheptinh == "nhan")
            {
                data2 = data1 * float.Parse(textBox2.Text);
                textBox1.Text = data1.ToString() + "*" + float.Parse(textBox2.Text) + "=";
                textBox2.Text = data2.ToString();
            }
            if (pheptinh == "chia")
            {
                if (float.Parse(textBox2.Text) == 0)
                {
                    textBox1.Text = data1.ToString() + "/";
                    textBox2.Text = "Khong chia duoc";
                }
                else
                {
                    data2 = data1 / float.Parse(textBox2.Text);
                    textBox1.Text = data1.ToString() + "/" + float.Parse(textBox2.Text) + "=";
                    textBox2.Text = data2.ToString();
                }

            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            pheptinh = "tru";
            data1 = float.Parse(textBox2.Text);
            textBox1.Text = data1.ToString() + "-";
            textBox2.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            pheptinh = "nhan";
            data1 = float.Parse(textBox2.Text);
            textBox1.Text = data1.ToString() + "*";
            textBox2.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pheptinh = "chia";
            data1 = float.Parse(textBox2.Text);
            textBox1.Text = data1.ToString() + "/";
            textBox2.Clear();
        }
    }
}
