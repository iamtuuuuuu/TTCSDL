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
    public partial class FormQLHocSinh : Form
    {
        public FormQLHocSinh()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new FormThemHocSinh(null).ShowDialog();
        }

        private void dataGridViewDanhSachHocSinh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //sua
            new FormThemHocSinh(null).ShowDialog();
        }

        private void btnThuHocPhi_Click(object sender, EventArgs e)
        {
            FormQLTHP f = new FormQLTHP();
            f.Show();
        }
    }
}
