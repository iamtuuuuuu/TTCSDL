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
    public partial class FormQLGiaoVien : Form
    {
        public FormQLGiaoVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new FormThemGiaoVien(null).ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDanhSachGiaoVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new FormThemGiaoVien(null).ShowDialog();
        }

        private void btnTraLuong_Click(object sender, EventArgs e)
        {
            new FormQLTL().ShowDialog();
            
        }
    }
}
