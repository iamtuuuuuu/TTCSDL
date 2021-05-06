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
    public partial class FormThemBL : Form
    {
        public FormThemBL()
        {
            InitializeComponent();
        }

        private void FormThemBL_Load(object sender, EventArgs e)
        {
            CSDL csdl = new CSDL();


            string getAllGV = "SELECT gv.MaGV  FROM GiaoVien gv";
            DataTable maMTTTable = csdl.SelectData(getAllGV);
            cbbMaGV.DataSource = maMTTTable.Copy();
            cbbMaGV.DisplayMember = "MaGV";
            cbbMaGV.ValueMember = "MaGV";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTien.Text))
            {
                MessageBox.Show("Vui lòng chọn thanh toán");
            }
            else
            {
                string sql;

                string Magv = cbbMaGV.Text;

                DateTime NgaySinh = dateTimePickerNgaySinh.Value;

                List<CustomParameter> lstPara = new List<CustomParameter>();
                float tongtien = float.Parse(txtTien.Text);

                sql = "ThemMoiBL";

                lstPara.Add(new CustomParameter()
                {
                    key = "@Magv",
                    value = Magv
                });


                lstPara.Add(new CustomParameter()
                {
                    key = "@Ngaytra",
                    value = NgaySinh.ToString()
                });

                lstPara.Add(new CustomParameter()
                {
                    key = "@tongtien",
                    value = tongtien.ToString()
                });
                var rs = new CSDL().ExeCute(sql, lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm mới thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thao tác không thành công");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Magv = cbbMaGV.Text;

            DateTime NgaySinh = dateTimePickerNgaySinh.Value;

            DateTime preDate = NgaySinh.AddYears(-1);

            var tmp = new CSDL().SelectData("select sotien from tesst('" + Magv + "','" + preDate.ToString() + "','" + NgaySinh.ToString() + "')");

            if (string.IsNullOrEmpty(tmp.Rows[0].ItemArray[0].ToString()))
            {
                MessageBox.Show("Chưa đủ dữ liệu để thanh toán");
            }
            else

                txtTien.Text = tmp.Rows[0].ItemArray[0].ToString();
        }
    }
}
