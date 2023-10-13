using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoanTranTrungHieu_2121110270
{
    public partial class Form7 : Form
    {
        List<Employee> lst;
        int id;


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
            comboBox1.Text = dataGridView1.Rows[idx].Cells[3].Value.ToString();

            textBox1.Text = dataGridView1.Rows[idx].Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.Rows[idx].Cells[5].Value.ToString();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool IsDuplicateID(string id)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Column1"].Value != null && row.Cells["Column1"].Value.ToString() == id)
                {
                    return true;
                }
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                id = Int32.Parse(tbId.Text);
                id = Int32.Parse(tbAge.Text);
                id = Int32.Parse(textBox1.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin hoặc Mã, tuổi, điểm phải là số ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (IsDuplicateID(tbId.Text))
            {
                MessageBox.Show("ID đã tồn tại. Vui lòng nhập ID khác.");
                return;
            }

            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            em.Age = tbAge.Text;
            lst.Add(em);
            if (checkData())
            {
                dataGridView1.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, comboBox1.Text, textBox1.Text, textBox2.Text, pictureBox1.Image);
            }
            

        }

        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(tbId.Text))
            {
                MessageBox.Show("Bạn chưa nhập Mã sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbId.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Bạn chưa nhập Họ tên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbAge.Text))
            {
                MessageBox.Show("Bạn chưa nhập Tuổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbAge.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Bạn chưa nhập Giới tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Bạn chưa nhập Điểm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Bạn chưa nhập Lớppppp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Focus();
                return false;
            }



            return true;
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
            dataGridView1.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, comboBox1.Text, textBox1.Text, textBox2.Text, pictureBox1.Image);
        }

        private void ckGender_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filepath = null; OpenFileDialog ofdImages = new OpenFileDialog(); PictureBox objpt = new PictureBox(); if (ofdImages.ShowDialog() == DialogResult.OK) { filepath = ofdImages.FileName; }
            MessageBox.Show(filepath); pictureBox1.Image = System.Drawing.Image.FromFile(filepath.ToString()); this.pictureBox1.Name = "pictureBox";
        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
