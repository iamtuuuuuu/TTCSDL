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
    public partial class SearchOutGV : Form
    {
        string sqlSearch;

        public SearchOutGV()
        {
            InitializeComponent();
        }

        public SearchOutGV(string sql)
        {
            sqlSearch = sql;
            InitializeComponent();
        }



        private void SearchOutGV_Load(object sender, EventArgs e)
        {
            dvgSearch.DataSource = null;
            dvgSearch.DataSource = new CSDL().SelectData(sqlSearch);
            dvgSearch.Columns["MaGV"].HeaderText = "Mã giáo viên";
            dvgSearch.Columns["HoTen"].HeaderText = "Tên giáo viên";
            dvgSearch.Columns["SDT"].HeaderText = "Số điện thoại";
            dvgSearch.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dvgSearch.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dvgSearch.Columns["GioiTinh"].HeaderText = "Giới tính";
            dvgSearch.Columns["MaMTT"].HeaderText = "Mã mức thanh toán";
        }
    }
}
