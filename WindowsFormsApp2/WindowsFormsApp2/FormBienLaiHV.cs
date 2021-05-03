using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormBienLaiHV : Form
    {
        private string maHV;
        private int thang;
        public FormBienLaiHV(string maHV, int thang)
        {
            this.maHV = maHV;
            this.thang = thang;
            InitializeComponent();
        }

        private void FormBienLaiHV_Load(object sender, EventArgs e)
        {
            cbbThang.SelectedIndex = thang - 1;
            LoadThongTinBLChiTiet();
        }
        private void LoadThongTinBLChiTiet()
        {
            string[] month = cbbThang.Text.Split(' ');
            int a = Int32.Parse(month[1]);
            dgvBienLaiChiTiet.DataSource = new CSDL().SelectData(string.Format("WatchBLDetail '" + maHV + "', " + a));

            dgvBienLaiChiTiet.Columns["MaHV"].HeaderText = "Mã học viên";
            dgvBienLaiChiTiet.Columns["MaLH"].HeaderText = "Mã lớp học";
            dgvBienLaiChiTiet.Columns["TenLH"].HeaderText = "Tên lớp học";
            dgvBienLaiChiTiet.Columns["HocPhi1Buoi"].HeaderText = "Học phí 1 buổi";
            dgvBienLaiChiTiet.Columns["SoLanDiHoc"].HeaderText = "Số lần đi học trong tháng";
            dgvBienLaiChiTiet.Columns["Tháng"].HeaderText = "Tháng";

            if (dgvBienLaiChiTiet.Rows.Count != 1)
            {
                var r = new CSDL().Select(string.Format("SelectBienLaiHPByMaHVAndThang '" + maHV + "', " + a));
                lbMaHV.Text = r["MaHV"].ToString();
                lbHoTen.Text = r["HoTen"].ToString();
                lbNgayThanhToan.Text = r["NgayThu"].ToString();
                lbThangDong.Text = r["Thang"].ToString();
                lbTongTien.Text = r["TongTien"].ToString();
            }
            else
            {
                lbMaHV.Text = "None";
                lbHoTen.Text = "None";
                lbNgayThanhToan.Text = "None";
                lbThangDong.Text = "None";
                lbTongTien.Text = "None";
            }
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThongTinBLChiTiet();
        }
    }
}
