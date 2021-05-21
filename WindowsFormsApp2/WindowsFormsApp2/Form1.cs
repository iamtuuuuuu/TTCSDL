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
        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHocSinhToolStripMenuItem.BackColor = Color.LightGray;
            QuanLyGiaoVienToolStripMenuItem.BackColor = Color.LightGray;
            QuanLyLopHocToolStripMenuItem.BackColor = Color.LightGray;
            //HuongDanToolStripMenuItem.BackColor = Color.LightGray;
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLyHocSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHocSinhToolStripMenuItem.BackColor = Color.SkyBlue;
            QuanLyGiaoVienToolStripMenuItem.BackColor = Color.LightGray;
            QuanLyLopHocToolStripMenuItem.BackColor = Color.LightGray;
            //HuongDanToolStripMenuItem.BackColor = Color.LightGray;
            FormQLHocSinh f = new FormQLHocSinh();
            AddForm(f);
        }

        private void QuanLyGiaoVienToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QuanLyHocSinhToolStripMenuItem.BackColor = Color.LightGray;
            QuanLyGiaoVienToolStripMenuItem.BackColor = Color.SkyBlue;
            QuanLyLopHocToolStripMenuItem.BackColor = Color.LightGray;
            //HuongDanToolStripMenuItem.BackColor = Color.LightGray;
            FormQLGiaoVien f = new FormQLGiaoVien();
            AddForm(f);
        }

        private void QuanLyLopHocToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QuanLyHocSinhToolStripMenuItem.BackColor = Color.LightGray;
            QuanLyGiaoVienToolStripMenuItem.BackColor = Color.LightGray;
            QuanLyLopHocToolStripMenuItem.BackColor = Color.SkyBlue;
            //HuongDanToolStripMenuItem.BackColor = Color.LightGray;
            FormQLLopHoc f = new FormQLLopHoc();
            AddForm(f);
        }

        private void HuongDanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHocSinhToolStripMenuItem.BackColor = Color.LightGray;
            QuanLyGiaoVienToolStripMenuItem.BackColor = Color.LightGray;
            QuanLyLopHocToolStripMenuItem.BackColor = Color.LightGray;
            //HuongDanToolStripMenuItem.BackColor = Color.SkyBlue;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }


    }
}
