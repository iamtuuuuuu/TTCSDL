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
        private void dgvDanhSachHocVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maHV = dgvDanhSachHocVien.Rows[e.RowIndex].Cells["MaHV"].Value.ToString();
                new FormThemHocSinh(maHV).ShowDialog();
                FormQLHocSinh_Load(sender, e);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            new FormThemHocSinh(null).ShowDialog();
            reload();
        }
        private void reload()
        {
            dgvDanhSachHocVien.DataSource = new CSDL().SelectData("SELECT * FROM HocVien");
        }

        private void FormQLHocSinh_Load(object sender, EventArgs e)
        {
            LoadHS();
        }
        private void LoadHS()
        {
            dgvDanhSachHocVien.DataSource = new CSDL().SelectData("exec SelectAllHV");

            dgvDanhSachHocVien.Columns["MaHV"].HeaderText = "Mã học viên";
            dgvDanhSachHocVien.Columns["HoTen"].HeaderText = "Họ tên";
            dgvDanhSachHocVien.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvDanhSachHocVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvDanhSachHocVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvDanhSachHocVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
        }
        private void resetValue()
        {
            txbTimKiem.Text = "";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbTimKiem.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cbbTimKiem.SelectedIndex != -1)
                {
                    String valueSearch = txbTimKiem.Text;
                    var db = new CSDL();
                    String sqlSearch = "";
                    if (cbbTimKiem.SelectedIndex == 0)
                    {
                        sqlSearch = "exec searchMaHV '" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOutHV(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbbTimKiem.SelectedIndex == 1)
                    {
                        sqlSearch = "exec searchHoTenHV N'" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOutHV(sqlSearch).Show();
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

        private void txbTimKiem_ForeColorChanged(object sender, EventArgs e)
        {
            if (txbTimKiem.Text == "")
                txbTimKiem.ForeColor = Color.Gray;
            else
                txbTimKiem.ForeColor = Color.Black;
        }

        private void txbTimKiem_Leave(object sender, EventArgs e)
        {
            if (txbTimKiem.Text == "")
            {
                txbTimKiem_ForeColorChanged(sender, e);
                txbTimKiem.Text = "Nhập thông tin muốn tìm kiếm";
            }
                
        }

        private void txbTimKiem_Enter(object sender, EventArgs e)
        {
            if (txbTimKiem.Text == "Nhập thông tin muốn tìm kiếm")
            {
                txbTimKiem_ForeColorChanged(sender, e);
                txbTimKiem.Text = "";
            }
        }

        private void btnQuanLyHocPhi_Click(object sender, EventArgs e)
        {
            FormQLTHP f = new FormQLTHP();
            f.Show();
        }
    }
}
