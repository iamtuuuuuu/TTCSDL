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
            this.Text = maHV;
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
                        value = DBNull.Value.ToString()
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

                    string sql2 = "GhiNo";
                    List<CustomParameter> lstPara2 = new List<CustomParameter>();
                    lstPara2.Add(new CustomParameter()
                    {
                        key = "@MaHV",
                        value = maHV
                    });

                    var rs2 = new CSDL().ExeCute(sql2, lstPara2);
                    if (rs2 == 0)
                        MessageBox.Show("Ghi nợ không thành công");
                }

                var r = new CSDL().Select(string.Format("SelectBienLaiHPByMaHVAndThang '" + maHV + "', " + a));
                lbMaHV.Text = r["MaHV"].ToString();
                lbHoTen.Text = r["HoTen"].ToString();
                dtpkNgayThanhToan.Value = DateTime.ParseExact(r["NgayThu"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                lbThangDong.Text = r["Thang"].ToString();
                lbTongTien.Text = r["TongTien"].ToString();
                lbSoThangNo.Text = r["SoThangChuaTra"].ToString();
                if (dtpkNgayThanhToan.Value.ToString() != "1/1/1900 12:00:00 AM")
                {
                    dtpkNgayThanhToan.Enabled = false;
                    ckbDongTien.Checked = true;
                    ckbDongTien.Enabled = false;
                }
                else
                {
                    dtpkNgayThanhToan.Enabled = true;
                    ckbDongTien.Checked = false;
                    ckbDongTien.Enabled = true;
                }
                    
            }
            else
            {
                lbMaHV.Text = "None";
                lbHoTen.Text = "None";
                dtpkNgayThanhToan.Value = DateTime.Now;
                lbThangDong.Text = "None";
                lbTongTien.Text = "None";
                lbSoThangNo.Text = "None";
            }
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThongTinBLChiTiet();
        }


        private void ckbDongTien_MouseClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Học viên này vừa đóng tiền?", "Questions???",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DongTien";
                List<CustomParameter> lstPara = new List<CustomParameter>();
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaHV",
                    value = lbMaHV.Text
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@Thang",
                    value = lbThangDong.Text
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@NgayThu",
                    value = dtpkNgayThanhToan.Value.ToString("yyyy-MM-dd")
                });
                var rs = new CSDL().ExeCute(sql, lstPara);
                if (rs == 0)
                    MessageBox.Show("Đóng tiền không thành công");
                this.Close();
            }
            else
            {
                ckbDongTien.Checked = false;
            }
        }
    }
}