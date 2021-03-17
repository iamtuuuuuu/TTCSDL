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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddForm(Form f)
        {
            this.panelContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(f);
            f.Show();
        }

        private void DoiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau f = new FormDoiMatKhau();
            AddForm(f);
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin flogin = new FormLogin();
            this.Hide();
            flogin.Show();
            //Application.Exit();
        }

        private void QuanLyHocSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLHocSinh f = new FormQLHocSinh();
            AddForm(f);
        }

        private void QuanLyGiaoVienToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormQLGiaoVien f = new FormQLGiaoVien();
            AddForm(f);
        }

        private void QuanLyLopHocToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormQLLopHoc f = new FormQLLopHoc();
            AddForm(f);
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
