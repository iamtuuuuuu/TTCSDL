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
            reload();
        }

        private void reload()
        {
            dataGridViewDanhSachLop.DataSource = new CSDL().SelectData("select * from LOPHOC");

        }

        private void dataGridViewDanhSachLop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sua tt nv
            //new FormThemLopHoc(null).ShowDialog();
            if (e.RowIndex >= 0)
            {
                var mlh = dataGridViewDanhSachLop.Rows[e.RowIndex].Cells["MaLH"].Value.ToString();
                new FormThemLopHoc(mlh).ShowDialog();
                reload();
            }
        }

        private void FormQLLopHoc_Load(object sender, EventArgs e)
        {
            dataGridViewDanhSachLop.DataSource = new CSDL().SelectData("select * from LOPHOC");
        }

        private void resetValue()
        {
            textBox1.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (comboBoxSearch.SelectedIndex != -1)
                {
                    String valueSearch = textBox1.Text;
                    var db = new CSDL();
                    String sqlSearch = "";
                    if (comboBoxSearch.SelectedIndex == 0)
                    {
                        sqlSearch = "exec searchMaLop '" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOutLH(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (comboBoxSearch.SelectedIndex == 1)
                    {
                        sqlSearch = "exec searchTenLop N'" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOutLH(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                resetValue();
            }
        }

        //private void btnGVXoa_Click(object sender, EventArgs e)
        //{
        //    var db = new CSDL();
        //    if (MessageBox.Show("Bạn muốn xóa giáo viên " + dgvGiaoVien.CurrentRow.Cells["TenGV"].Value.ToString() + " ?", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //    {
        //        var tenGV = dgvGiaoVien.CurrentRow.Cells["TenGV"].Value.ToString();
        //        var idGV = dgvGiaoVien.CurrentRow.Cells["MaGV"].Value.ToString();
        //        db.del_data(idGV);
        //        MessageBox.Show("Đã xóa giáo viên : " + tenGV);
        //    }
        //    LoadDSGV();
        //}

    }
}
