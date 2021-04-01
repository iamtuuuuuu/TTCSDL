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
    public partial class FormQLLopHoc : Form
    {
        public FormQLLopHoc()
        {
            InitializeComponent();
        }

        private void dataGridViewDanhSachLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            FormQLDD f = new FormQLDD();
            f.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new FormThemLopHoc(null).ShowDialog();
        }

        private void dataGridViewDanhSachLop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sua tt nv
            new FormThemLopHoc(null).ShowDialog();
        }

        private void FormQLLopHoc_Load(object sender, EventArgs e)
        {
            dataGridViewDanhSachLop.DataSource = new CSDL().SelectData("select * from LOPHOC");
        }
    }
}
