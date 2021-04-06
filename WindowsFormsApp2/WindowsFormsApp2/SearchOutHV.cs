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
    public partial class SearchOutHV : Form
    {
        string sqlSearch;
        public SearchOutHV()
        {
            InitializeComponent();
        }
        public SearchOutHV(string sql)
        {
            sqlSearch = sql;
            InitializeComponent();
        }
        private void LoadInformation()
        {
            dgvThongTinHS.DataSource = null;
            dgvThongTinHS.DataSource = new CSDL().SelectData(sqlSearch);
            dgvThongTinHS.Columns["MaHV"].HeaderText = "Mã học viên";
            dgvThongTinHS.Columns["HoTen"].HeaderText = "Họ tên";
            dgvThongTinHS.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvThongTinHS.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvThongTinHS.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvThongTinHS.Columns["GioiTinh"].HeaderText = "Giới tính";
        }

        private void SearchOutHV_Load(object sender, EventArgs e)
        {
            LoadInformation();
        }
    }
}
