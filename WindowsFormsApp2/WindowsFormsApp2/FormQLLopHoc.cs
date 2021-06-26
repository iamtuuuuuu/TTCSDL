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
    public partial class FormQLLopHoc : Form
    {
        public FormQLLopHoc()
        {
            InitializeComponent();
        }

        private void dataGridViewDanhSachLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            FormQLDD f = new FormQLDD();
            f.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new FormThemLopHoc(null).ShowDialog();
            reload();
        }

        private void reload()
        {
            dataGridViewDanhSachLop.DataSource = new CSDL().SelectData("select * from LOPHOC");

        }

        private void dataGridViewDanhSachLop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sua tt nv
            //new FormThemLopHoc(null).ShowDialog();
            if (e.RowIndex >= 0)
            {
                var mlh = dataGridViewDanhSachLop.Rows[e.RowIndex].Cells["MaLH"].Value.ToString();
                new FormThemLopHoc(mlh).ShowDialog();
                reload();
            }
        }

        private void FormQLLopHoc_Load(object sender, EventArgs e)
        {
            dataGridViewDanhSachLop.DataSource = new CSDL().SelectData("select * from LOPHOC");
        }

        private void resetValue()
        {
            textBox1.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (comboBoxSearch.SelectedIndex != -1)
                {
                    String valueSearch = textBox1.Text;
                    var db = new CSDL();
                    String sqlSearch = "";
                    if (comboBoxSearch.SelectedIndex == 0)
                    {
                        sqlSearch = "exec searchMaLop '" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOutLH(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (comboBoxSearch.SelectedIndex == 1)
                    {
                        sqlSearch = "exec searchTenLop N'" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOutLH(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                resetValue();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var db = new CSDL();
            if (MessageBox.Show("Bạn muốn xóa lớp học " + dataGridViewDanhSachLop.CurrentRow.Cells["TenLH"].Value.ToString() + " ?", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var tenLH = dataGridViewDanhSachLop.CurrentRow.Cells["TenLH"].Value.ToString();
                var idLH = dataGridViewDanhSachLop.CurrentRow.Cells["MaLH"].Value.ToString();
                db.deleteHV_LH(idLH);
                string getMaBuoiHoc = "select MaBH from BUOIHOC where MaLH = \'" + idLH + "\'";
                DataTable maBHTable = db.SelectData(getMaBuoiHoc);
                Console.WriteLine(maBHTable);
                for(int i = 0; i < maBHTable.Rows.Count; i++)
                {
                    db.deleteDiemDanh(maBHTable.Rows[i][0].ToString());
                }

                db.deleteBuoiHoc(idLH);
                db.deleteLH(idLH);
                MessageBox.Show("Đã xóa lớp học : " + tenLH);
            }
            reload();
        }

    }
}
