using System;
using System.Collections;
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
    public partial class Form7 : Form
    {
        List<Employee> lst;


        public Form7()
        {
            InitializeComponent();
        }

        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>();
            Employee em = new Employee();
            em.Id = "53418";
            em.Name = "Trần Tiến";
            em.Age = "20";
            lst.Add(em);

            em = new Employee();
            em.Id = "53416";
            em.Name = "Nguyễn Cường";
            em.Age = "25";
            lst.Add(em);

            em = new Employee();
            em.Id = "53417";
            em.Name = "Nguyễn Hào";
            em.Age = "23";
            lst.Add(em);
            return lst;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            tbAge.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            ckGender.Checked = bool.Parse(dataGridView1.Rows[idx].Cells[3].Value.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            em.Age = tbAge.Text;
            em.Gender = ckGender.Checked;
            lst.Add(em);
            dataGridView1.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idx = dataGridView1.CurrentCell.RowIndex;
            lst.RemoveAt(idx);
            dataGridView1.Rows.RemoveAt(idx);
        }

        private void Form7_Load_1(object sender, EventArgs e)
        {
            lst = GetData();
            foreach (Employee em in lst)
            {
                dataGridView1.Rows.Add(em.Id, em.Name, em.Age);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int idx = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[idx].SetValues(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
        }
    }
}
