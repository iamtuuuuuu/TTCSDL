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
    public partial class FormThemHocSinh : Form
    {
        private string maHV;
        public FormThemHocSinh(string maHV)
        {
            this.maHV = maHV;
            InitializeComponent();
        }
        private void FormThemHocSinh_Load(object sender, EventArgs e)
        {
            CSDL dl = new CSDL();
            string getAllMaLH = "SELECT MaLH, TenLH FROM LOPHOC";
            DataTable maLHTable = dl.SelectData(getAllMaLH);
            listBoxLopHoc.DataSource = maLHTable.Copy();
            listBoxLopHoc.DisplayMember = "TenLH";
            listBoxLopHoc.ValueMember = "MaLH";
            if (string.IsNullOrEmpty(maHV))
            {
                this.Text = "Thêm học viên";
                btnLuu.Text = "Thêm";
                txbMaHV.ReadOnly = false;
            }
            else
            {
                var r = new CSDL().Select(string.Format("SelectHocVienByMa '" + maHV + "'"));
                txbMaHV.Text = maHV;
                txbHoTen.Text = r["HoTen"].ToString();
                txbSDT.Text = r["SDT"].ToString();
                dtPickerNgaySinh.Value = DateTime.ParseExact(r["NgaySinh"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                txbDiaChi.Text = r["DiaChi"].ToString();
                if (r["GioiTinh"].ToString() == "Nam")
                    radioBtnNam.Checked = true;
                else
                    radioBtnNu.Checked = true;

                listBoxChonLop.DataSource = new CSDL().SelectData("SELECT b.MaLH, b.TenLH FROM HOCVIEN_LOPHOC a, LOPHOC b " +
                                                                "WHERE a.MaLH = b.MaLH AND a.MaHV = '" + maHV + "'");
                listBoxChonLop.DisplayMember = "TenLH";
                listBoxChonLop.ValueMember = "MaLH";
                this.Text = "Chỉnh sửa thông tin học viên";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            bool checkClass = false;
            if (listBoxLopHoc.SelectedItem != null)
            {
                if (this.Text == "Chỉnh sửa thông tin học viên" && MessageBox.Show("Bạn có chắc chắn thêm lớp này cho học viên " + maHV + " không?",
                    "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataRowView dt = (DataRowView)listBoxLopHoc.SelectedItem;
                    string result = dt["MaLH"].ToString();
                    foreach(DataRowView item in listBoxChonLop.Items)
                    {
                        if (item.Row.ItemArray[0].ToString() == result)
                        {
                            checkClass = true;
                            break;
                        }
                    }
                    if (checkClass == false)
                    {
                        string sql = "ThemLopHocChoHocVien";
                        List<CustomParameter> lstClassPara = new List<CustomParameter>();
                        lstClassPara.Add(new CustomParameter()
                        {
                            key = "@MaHV",
                            value = maHV
                        });
                        lstClassPara.Add(new CustomParameter()
                        {
                            key = "@MaLH",
                            value = result
                        });

                        var r2 = new CSDL().ExeCute(sql, lstClassPara);
                        reloadDSLop();
                    }
                    else
                    {
                        MessageBox.Show("Học viên " + maHV + " đã có trong danh sách lớp " + result + "!!!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (this.Text == "Thêm học viên")
                {

                    foreach (DataRowView item in listBoxChonLop.Items)
                    {
                        if (item.Row.ItemArray[0].ToString() == listBoxLopHoc.SelectedValue.ToString())
                            checkClass = true;
                    }
                    if (checkClass == false)
                    {
                        listBoxChonLop.Items.Add(listBoxLopHoc.SelectedItem);
                        listBoxChonLop.DisplayMember = "TenLH";
                    }
                    else
                    {
                        MessageBox.Show("Học viên " + maHV + " đã có trong danh sách lớp " + listBoxLopHoc.SelectedValue.ToString() + "!!!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void reloadDSLop()
        {
            listBoxChonLop.DataSource = new CSDL().SelectData("SELECT b.MaLH, b.TenLH FROM HOCVIEN_LOPHOC a, LOPHOC b " +
                                                            "WHERE a.MaLH = b.MaLH AND a.MaHV = '" + maHV + "'");
        }
        private void btnChuyenVe_Click(object sender, EventArgs e)
        {
            if (listBoxChonLop.SelectedItem != null)
            {
                if (this.Text == "Chỉnh sửa thông tin học viên" && MessageBox.Show("Bạn có chắc chắn xóa lớp này khỏi học viên " + maHV + " không?",
                    "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var r = new CSDL();
                    DataRowView dt = (DataRowView)listBoxChonLop.SelectedItem;
                    String result = dt["MaLH"].ToString();
                    r.del_lopHoc(maHV, result);
                    reloadDSLop();
                }
                else if (this.Text == "Thêm học viên")
                {
                    listBoxChonLop.Items.Remove(listBoxChonLop.SelectedItem);
                    listBoxChonLop.DisplayMember = "TenLH";
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            string hoTen = txbHoTen.Text;
            string sdt = txbSDT.Text;
            string maHVNew = txbMaHV.Text;
            DateTime ngaySinh = dtPickerNgaySinh.Value;
            string diaChi = txbDiaChi.Text;
            string gioiTinh;
            if (radioBtnNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (String.IsNullOrEmpty(maHV))
            {
                sql = "ThemHocVien";
                lstPara.Add(new CustomParameter()
                {
                    key = "@maHV",
                    value = maHVNew
                });
            }
            else
            {
                sql = "UpdateHocVien";
                lstPara.Add(new CustomParameter()
                {
                    key = "@maHV",
                    value = maHV
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@HoTen",
                value = hoTen
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@SDT",
                value = sdt
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@NgaySinh",
                value = ngaySinh.ToString("yyyy-MM-dd")
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@DiaChi",
                value = diaChi
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@GioiTinh",
                value = gioiTinh
            });

            var r = new CSDL().ExeCute(sql, lstPara);

            if (this.Text == "Thêm học viên" && listBoxChonLop.Items.Count != 0)
            {
                string sql2 = "ThemLopHocChoHocVien";
                List<CustomParameter> lstClassPara = new List<CustomParameter>();
                foreach(DataRowView item in listBoxChonLop.Items)
                {
                    lstClassPara.Add(new CustomParameter()
                    {
                        key = "@MaHV",
                        value = maHVNew
                    });
                    lstClassPara.Add(new CustomParameter()
                    {
                        key = "@MaLH",
                        value = item.Row.ItemArray[0].ToString()
                    });

                    var r2 = new CSDL().ExeCute(sql2, lstClassPara);
                    lstClassPara.Clear();
                }
            }

            if (r == 1)
            {
                if (string.IsNullOrEmpty(maHV))
                {
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }
        }
    }
}