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
    public partial class FormQLTHP : Form
    {
        public FormQLTHP()
        {
            InitializeComponent();
        }
        private void dgvBienLaiHP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maHV = dgvBienLaiHP.Rows[e.RowIndex].Cells["MaHV"].Value.ToString();
                //string[] month = dgvBienLaiHP.Rows[e.RowIndex].Cells["NgayThu"].Value.ToString().Split('/');
                //int thang = Int32.Parse(month[0]);
                int thang = Int32.Parse(dgvBienLaiHP.Rows[e.RowIndex].Cells["Thang"].Value.ToString());
                new FormBienLaiHV(maHV, thang).ShowDialog();
                FormQLTHP_Load(sender, e);
            }
        }
        private void FormQLTHP_Load(object sender, EventArgs e)
        {
            LoadBLThuHP();
        }
        private void LoadBLThuHP()
        {
            dgvBienLaiHP.DataSource = new CSDL().SelectData("exec SelectAllBLThuHP");

            dgvBienLaiHP.Columns["MaBL"].HeaderText = "Mã biên lai";
            dgvBienLaiHP.Columns["NgayThu"].HeaderText = "Ngày thu";
            dgvBienLaiHP.Columns["TongTien"].HeaderText = "Tổng tiền";
            dgvBienLaiHP.Columns["MaHV"].HeaderText = "Mã học viên";
            dgvBienLaiHP.Columns["Thang"].HeaderText = "Tháng";
        }

        private void btnThemBL_Click(object sender, EventArgs e)
        {
            FormThemBienLai bl = new FormThemBienLai();
            bl.ShowDialog();
            LoadBLThuHP();
        }

        private void btnXoaBL_Click(object sender, EventArgs e)
        {
            var r = new CSDL();
            if (MessageBox.Show("Bạn có chắc chắn xóa biên lai này không?", "Warning!!!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                r.del_BLHocPhi(dgvBienLaiHP.CurrentRow.Cells["MaBL"].Value.ToString());
            }
            LoadBLThuHP();
        }
    }
}
