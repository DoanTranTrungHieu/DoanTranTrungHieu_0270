﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainmenu = new Form1();
            mainmenu.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 mainmenu = new Form2();
            mainmenu.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 mainmenu = new Form3();
            mainmenu.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 mainmenu = new Form4();
            mainmenu.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 mainmenu = new Form5();
            mainmenu.ShowDialog(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 mainmenu = new Form6();
            mainmenu.ShowDialog(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 mainmenu = new Form7();
            mainmenu.ShowDialog(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 mainmenu = new Form8();
            mainmenu.ShowDialog(this);
        }
    }
}
