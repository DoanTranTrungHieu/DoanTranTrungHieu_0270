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
    public partial class Form9 : Form
    {
        private const string Username = "hieu";
        private const string Password = "12345678";
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                String userName = txtUserName.Text;
                String password = txtPassword.Text;
                if (userName == Username && password == Password)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Menu mainmenu = new Menu();
                    mainmenu.ShowDialog(this);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("tên tài khoản hoặc mật khẩu k đúng vui lòng nhập lại");
                }


            }
        }
    }

