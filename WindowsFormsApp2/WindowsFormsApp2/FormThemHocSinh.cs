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

                listBoxChonLop.DataSource = new CSDL().SelectData("SELECT b.MaLH, b.TenLH FROM HOCVIEN_LOPHOC a, LOPHOC b WHERE a.MaLH = b.MaLH AND a.MaHV = '" + maHV + "'");
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
            if (listBoxLopHoc.SelectedItem != null)
            {
                listBoxChonLop.Items.Add(listBoxLopHoc.SelectedItem);
                listBoxChonLop.DisplayMember = "TenLH";
            }
        }

        private void btnChuyenVe_Click(object sender, EventArgs e)
        {
            if (listBoxChonLop.SelectedItem != null)
            {
                listBoxChonLop.Items.Remove(listBoxChonLop.SelectedItem);
            }
        }
    }
}
