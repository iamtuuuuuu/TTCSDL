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

                textBoxMaLop.Text = r["MaLH"].ToString();
                textBoxTenLop.Text = r["TenLH"].ToString();

                string maMucHocPhi = r["MaMHP"].ToString();
                Console.WriteLine(maMucHocPhi);
                comboBoxMaMHP.SelectedValue = maMucHocPhi;
                string maMonHoc = r["MaMH"].ToString();
                comboBoxMaMHP.SelectedValue = maMonHoc;
                string maGiaoVien = r["MaGV"].ToString();
                comboBoxMaMHP.SelectedValue = maGiaoVien;
            }
        }
    }
}
