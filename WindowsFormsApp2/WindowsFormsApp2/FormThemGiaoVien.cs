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
    public partial class FormThemGiaoVien : Form
    {
        private string magv;
        public FormThemGiaoVien(string magv, DataGridView dataGridViewDanhSachGiaoVien)
        {
            this.magv = magv;
            InitializeComponent();
        }

        private void ThemGV_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(magv))
            {


                CSDL csdl = new CSDL();


                string getAllMTT = "SELECT mtt.MaMTT  FROM MucThanhToan mtt";
                DataTable maMTTTable = csdl.SelectData(getAllMTT);
                comboBoxMaMucThanhToan.DataSource = maMTTTable.Copy();
                comboBoxMaMucThanhToan.DisplayMember = "MaMTT";
                comboBoxMaMucThanhToan.ValueMember = "MaMTT";


                this.Text = "Thêm giáo viên";
            }
            else
            {
                CSDL csdl = new CSDL();

                var r = new CSDL().Select(string.Format("SelectGVById '" + magv + "'"));




                string getAllMTT = "SELECT mtt.MaMTT  FROM MucThanhToan mtt";
                DataTable maMTTTable = csdl.SelectData(getAllMTT);
                comboBoxMaMucThanhToan.DataSource = maMTTTable.Copy();
                comboBoxMaMucThanhToan.DisplayMember = "MaMTT";
                comboBoxMaMucThanhToan.ValueMember = "MaMTT";


                textBoxHoTen.Text = r["HoTen"].ToString();
                textBoxSDT.Text = r["SDT"].ToString();
                dateTimePickerNgaySinh.Value = (DateTime)r["NgaySinh"];
                textBoxDiaChi.Text = r["DiaChi"].ToString();
                txtPass.Text = r["pass"].ToString();


                if (r["GioiTinh"].ToString() == "Nam")
                {
                    radioNam.Checked = true;
                }
                else
                {
                    radioNu.Checked = true;
                }

                //comboBoxMaMucThanhToan.Text = r["MaMTT"].ToString();
                this.Text = "Chỉnh sửa giáo viên";
            }
        }



        public FormThemGiaoVien()
        {
            this.magv = magv;
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            string sql;

            string HoTen = textBoxHoTen.Text;
            string sdt = textBoxSDT.Text;
            string GioiTinh = radioNam.Checked ? "Nam" : "Nữ";
            DateTime NgaySinh = dateTimePickerNgaySinh.Value;

            string DiaChi = textBoxDiaChi.Text;
            string MaMTT = comboBoxMaMucThanhToan.Text;

            string pass = txtPass.Text;



            sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(magv))
            {


                sql = "ThemMoiGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@HoTen",
                    value = HoTen
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@SDT",
                    value = sdt
                });

                lstPara.Add(new CustomParameter()
                {
                    key = "@NgaySinh",
                    value = NgaySinh.ToString()
                });

                lstPara.Add(new CustomParameter()
                {
                    key = "@DiaChi",
                    value = DiaChi
                });

                lstPara.Add(new CustomParameter()
                {
                    key = "@GioiTinh",
                    value = GioiTinh
                });

                lstPara.Add(new CustomParameter()
                {
                    key = "@MaMTT",
                    value = MaMTT
                });

                lstPara.Add(new CustomParameter()
                {
                    key = "@pass",
                    value = pass
                });

            }
            else
            {
                sql = "UpdateGiaoVien";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaGV",
                    value = magv
                });

                lstPara.Add(new CustomParameter()
                {
                    key = "@HoTen",
                    value = HoTen
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@SDT",
                    value = sdt
                });

                lstPara.Add(new CustomParameter()
                {
                    key = "@NgaySinh",
                    value = NgaySinh.ToString()
                });

                lstPara.Add(new CustomParameter()
                {
                    key = "@DiaChi",
                    value = DiaChi
                });

                lstPara.Add(new CustomParameter()
                {
                    key = "@GioiTinh",
                    value = GioiTinh
                });

                lstPara.Add(new CustomParameter()
                {
                    key = "@MaMTT",
                    value = MaMTT
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@pass",
                    value = pass
                });


            }

            if (txtPass.Text == txtConfirm.Text)
            {
                var rs = new CSDL().ExeCute(sql, lstPara);
                if (rs == 1)
                {
                    if (string.IsNullOrEmpty(magv))
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
            else
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp. Vui lòng nhập lại");
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
