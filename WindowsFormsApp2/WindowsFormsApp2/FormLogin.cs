using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormLogin : Form
    {
        public static FormLogin fLogin;
        public FormLogin()
        {
            fLogin = this;
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txbTaiKhoan.Text == "admin" && txbMatKhau.Text == "admin")
            {
                this.Visible = false;
                Form1 fquanLy = new Form1();
                fquanLy.Show();
            }
            else
            {
                MessageBox.Show("Tên truy cập hoặc mật khẩu sai");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
