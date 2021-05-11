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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txbTaiKhoan.Text == "admin" && txbMatKhau.Text == "admin")
            {
                this.Visible = false;
                Form1 fquanLy = new Form1();
                fquanLy.ShowDialog();
                this.Visible = true;
            }
            else if(checkLogin(txbTaiKhoan.Text, txbMatKhau.Text) == 1)
            {
                string ma = getMaGV(txbTaiKhoan.Text, txbMatKhau.Text);
                FormQLDD f = new FormQLDD(ma);
                f.Show();
            }
            else
            {
                MessageBox.Show("Tên truy cập hoặc mật khẩu sai");
            }
           
            this.Visible = true;
        }

        private int checkLogin(string username, string pass)
        {
            CSDL csdl = new CSDL();
            string sql = "SELECT * FROM GIAOVIEN WHERE SDT = \'" + username+ "\' AND pass = \'"+ pass + "\'";
            DataTable tblAccGV = csdl.SelectData(sql);

            if(tblAccGV.Rows.Count == 1)
            {
                return 1;
            }

            return 0;
        }

        private string getMaGV(string username, string pass)
        {
            CSDL csdl = new CSDL();
            string sql = "SELECT * FROM GIAOVIEN WHERE SDT = \'" + username + "\' AND pass = \'" + pass + "\'";
            DataTable tblAccGV = csdl.SelectData(sql);

            return tblAccGV.Rows[0][0].ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
