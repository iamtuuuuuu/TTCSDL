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
    public partial class FormThemBienLai : Form
    {
        public FormThemBienLai()
        {
            InitializeComponent();
        }
        private void FormThemBienLai_Load(object sender, EventArgs e)
        {
            CSDL dl = new CSDL();
            string getAllMaHV = "SELECT MaHV FROM HOCVIEN";
            DataTable maHVTable = dl.SelectData(getAllMaHV);
            cbbMaHV.DataSource = maHVTable.Copy();
            cbbMaHV.DisplayMember = "MaHV";
            cbbMaHV.ValueMember = "MaHV";
            cbbMaHV.SelectedIndex = 0;
        }
        //private void txbTongTien_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}
        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "ThemBienLai";
            string maBL = txbMaBL.Text;
            DateTime ngayThu = dtPickerNgayThu.Value;
            int thang = (int)numUpDownThang.Value;
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
                value = cbbMaHV.Text
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
            if (rs == 1)
            {
                MessageBox.Show("Thêm mới thành công");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
