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
                var checkdb = new CSDL().SelectData(string.Format("SelectBienLaiHPByMaHVAndThang '" + maHV + "', " + a));
                if (checkdb.Rows.Count == 0)
                {
                    string sql = "ThemBienLai";
                    string maBL;
                    if (a < 10)
                    {
                        maBL = "BL200" + a.ToString() + maHV.Substring(maHV.Length - 2, 2) + "01";
                    }
                    else
                    {
                        maBL = "BL20" + a.ToString() + maHV.Substring(maHV.Length - 2, 2) + "01";
                    }
                    int countingDay = DateTime.DaysInMonth(2020, a);
                    DateTime ngayThu = new DateTime(2020, a, countingDay);
                    int thang = a;
                    int tongTien = 0;
                    List<CustomParameter> lstPara = new List<CustomParameter>();

                    lstPara.Add(new CustomParameter()
                    {
                        key = "@MaBL",
                        value = maBL
                    });

                    lstPara.Add(new CustomParameter()
                    {
                        key = "@MaHV",
                        value = maHV
                    });

                    lstPara.Add(new CustomParameter()
                    {
                        key = "@NgayThu",
                        value = ngayThu.ToString("yyyy-MM-dd")
                    });

                    lstPara.Add(new CustomParameter()
                    {
                        key = "@Thang",
                        value = thang.ToString()
                    });

                    lstPara.Add(new CustomParameter()
                    {
                        key = "@TongTien",
                        value = tongTien.ToString()
                    });

                    var rs = new CSDL().ExeCute(sql, lstPara);
                    if (rs == 0)
                        MessageBox.Show("Xem không thành công");
                }

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
