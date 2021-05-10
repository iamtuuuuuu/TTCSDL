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
    public partial class FormThemLopHoc : Form
    {
        string malh;
        public FormThemLopHoc(string malh)
        {
            this.malh = malh;
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThemLopHoc_Load(object sender, EventArgs e)
        {
            CSDL csdl = new CSDL();
            // ma MHP
            string getAllMaMHP = "SELECT MaMHP FROM MUCHOCPHI";
            DataTable maMHPTable = csdl.SelectData(getAllMaMHP);
            comboBoxMaMHP.DataSource = maMHPTable.Copy();
            comboBoxMaMHP.DisplayMember = "MaMHP";
            comboBoxMaMHP.ValueMember = "MaMHP";
            //ma mon học
            string getAllMaMH = "SELECT MaMH FROM MONHOC";
            DataTable maMHTable = csdl.SelectData(getAllMaMH);
            comboBoxMaMonHoc.DataSource = maMHTable.Copy();
            comboBoxMaMonHoc.DisplayMember = "MaMH";
            comboBoxMaMonHoc.ValueMember = "MaMH";
            // mã giáo viên
            string getAllMaGV = "SELECT MaGV FROM GIAOVIEN";
            DataTable maGVTable = csdl.SelectData(getAllMaGV);
            comboBoxMaGiaoVien.DataSource = maGVTable.Copy();
            comboBoxMaGiaoVien.DisplayMember = "MaGV";
            comboBoxMaGiaoVien.ValueMember = "MaGV";
            if (string.IsNullOrEmpty(malh))
            {
                this.Text = "Thêm mới lớp học";
            }
            else
            {
                this.Text = "Cập nhật thông tin lớp học";

                var r = new CSDL().Select(string.Format("searchMaLop '" + malh + "'"));
                                
                textBoxTenLop.Text = r["TenLH"].ToString();

                string maMucHocPhi = r["MaMHP"].ToString();
                Console.WriteLine(maMucHocPhi);
                comboBoxMaMHP.SelectedValue = maMucHocPhi;
                string maMonHoc = r["MaMH"].ToString();
                comboBoxMaMonHoc.SelectedValue = maMonHoc;
                string maGiaoVien = r["MaGV"].ToString();
                comboBoxMaGiaoVien.SelectedValue = maGiaoVien;
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            string sql;
            //string MaLH = textBoxMaLop.Text;
            string TenLH = textBoxTenLop.Text;
            string MaMHP = comboBoxMaMHP.Text;
            string MaMH = comboBoxMaMonHoc.Text;
            string MaGV = comboBoxMaGiaoVien.Text;

            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(malh))
            {
                sql = "ThemMoiLH";
            }
            else
            {
                sql = "UpdateLH";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaLH",
                    value = malh
                });
            }

            lstPara.Add(new CustomParameter()
            {
                key = "@TenLH",
                value = TenLH
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@MaMHP",
                value = MaMHP
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@MaMH",
                value = MaMH
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@MaGV",
                value = MaGV
            });


            var rs = new CSDL().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(malh))
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
