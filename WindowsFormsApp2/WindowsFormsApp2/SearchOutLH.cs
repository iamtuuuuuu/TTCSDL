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
    public partial class SearchOutLH : Form
    {
        string sqlSearch;

        public SearchOutLH()
        {
            InitializeComponent();
        }

        public SearchOutLH(string sql)
        {
            sqlSearch = sql;
            InitializeComponent();
        }

        private void LoadDSLH()
        {
            dvgSearch.DataSource = null;
            dvgSearch.DataSource = new CSDL().SelectData(sqlSearch);
            dvgSearch.Columns["MaLH"].HeaderText = "Mã Lớp Học";
            dvgSearch.Columns["TenLH"].HeaderText = "Tên Lớp Học";
            dvgSearch.Columns["MaMH"].HeaderText = "Mã Môn Học";
            dvgSearch.Columns["MaGV"].HeaderText = "Mã Giáo Viên";
            dvgSearch.Columns["MaMHP"].HeaderText = "Mã Mức Học Phần";
        }

        private void SearchOutLH_Load(object sender, EventArgs e)
        {
            LoadDSLH();
        }
    }
}
