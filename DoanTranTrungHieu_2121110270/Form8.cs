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
    public partial class Form8 : Form
    {
        int count = 0;
        int min = 0;
        public Form8()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            tmCount.Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            tmCount.Stop();
        }

        private void tmCount_Tick(object sender, EventArgs e)
        {
            count++;
            if (count >= 60)
            {
                min++;
                lbMin.Text = min.ToString();
                count = 0;
            }
            lbSec.Text = count.ToString();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
