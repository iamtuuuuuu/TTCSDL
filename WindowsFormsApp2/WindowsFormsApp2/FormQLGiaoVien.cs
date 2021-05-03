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
            new FormThemGiaoVien().ShowDialog();
            reload();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var db = new CSDL();
            if (MessageBox.Show("Bạn muốn xóa giáo viên " + dataGridViewDanhSachGiaoVien.CurrentRow.Cells["Hoten"].Value.ToString() + " ?", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.del_dataGV(dataGridViewDanhSachGiaoVien.CurrentRow.Cells["MaGV"].Value.ToString());
            }

            // Hien thi mess thong bao

            reload();
        }

        private void dataGridViewDanhSachGiaoVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                string magv = dataGridViewDanhSachGiaoVien.Rows[e.RowIndex].Cells["MaGV"].Value.ToString();
                new FormThemGiaoVien(magv, dataGridViewDanhSachGiaoVien).ShowDialog();
                reload();
            }
            
        }

        private void btnTraLuong_Click(object sender, EventArgs e)
        {
            new FormQLTL().ShowDialog();
            
        }

        private void reload()
        {
            dataGridViewDanhSachGiaoVien.DataSource = new CSDL().SelectData("select * from giaovien");
        }

            private void FormQLGiaoVien_Load(object sender, EventArgs e)
        {
            dataGridViewDanhSachGiaoVien.DataSource = new CSDL().SelectData("select * from giaovien");
        }


        private void resetValue()
        {
            txbGVThongTin.Text = "";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbGVThongTin.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cbbGVDanhSach.SelectedIndex != -1)
                {
                    String valueSearch = txbGVThongTin.Text;
                    var db = new CSDL();
                    String sqlSearch = "";
                    if (cbbGVDanhSach.SelectedIndex == 0)
                    {
                        sqlSearch = "exec searchMGV '" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOutGV(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbbGVDanhSach.SelectedIndex == 1)
                    {
                        sqlSearch = "exec searchTGV N'" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOutGV(sqlSearch).Show();
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
    }
}
