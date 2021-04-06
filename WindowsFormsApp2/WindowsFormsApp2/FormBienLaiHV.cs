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
        public FormBienLaiHV(string maHV)
        {
            this.maHV = maHV;
            InitializeComponent();
        }

        private void FormBienLaiHV_Load(object sender, EventArgs e)
        {
            LoadThongTinBLChiTiet();
        }
        private void LoadThongTinBLChiTiet()
        {
            dgvBienLaiChiTiet.DataSource = new CSDL().SelectData(string.Format("SelectLopHocByMaHV '" + maHV + "'"));

            dgvBienLaiChiTiet.Columns["MaHV"].HeaderText = "Mã học viên";
            dgvBienLaiChiTiet.Columns["MaLH"].HeaderText = "Mã lớp học";
            dgvBienLaiChiTiet.Columns["TenLH"].HeaderText = "Tên lớp học";
            dgvBienLaiChiTiet.Columns["HocPhi1Buoi"].HeaderText = "Học phí 1 buổi";
            dgvBienLaiChiTiet.Columns["SoLanDiHoc"].HeaderText = "Số lần đi học trong tháng";

            var r = new CSDL().Select(string.Format("SelectBienLaiHPByMaHV '" + maHV + "'"));
            lbMaHV.Text = r["MaHV"].ToString();
            lbHoTen.Text = r["HoTen"].ToString();
            lbNgayThanhToan.Text = r["NgayThu"].ToString();
            lbSoThangNo.Text = r["SoThangChuaTra"].ToString();
            //lbThangDong.Text = r[""]
            lbTongTien.Text = r["TongTien"].ToString();
        }
    }
}
