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
    public partial class FormQLDD : Form
    {
        public FormQLDD()
        {
            InitializeComponent();
        }

        // Thang 9 => '2020-9-01 00:00:00', '2020-10-01 00:00:00'
        private string Map(string a)
        {
            string res = "";
            string[] month = a.Split(' ');
            if(month[1] == "12")
            {
                res = "\'2020-" + month[1] + "-01 00:00:00\', \'2021-01-01 00:00:00\'";
                return res;
            }
            int nextMonth = Int32.Parse(month[1]) + 1;
            res = "\'2020-" + month[1] + "-01 00:00:00\', \'2020-" + nextMonth.ToString() + "-01 00:00:00\'";


            return res;
        }

        private void FormQLDD_Load(object sender, EventArgs e)
        {
            CSDL csdl = new CSDL();
            string getAllMaLH = "SELECT MaLH FROM LOPHOC";
            DataTable maLHTable = csdl.SelectData(getAllMaLH);
            comboBoxChonLop.DataSource = maLHTable.Copy();
            comboBoxChonLop.DisplayMember = "MaLH";
            comboBoxChonLop.ValueMember = "MaLH";

            comboBoxChonLop.SelectedIndex = 7;
            comboBoxChonThang.SelectedIndex = 8;

            textBoxSearch.Text = "Nhập tên học sinh...";
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string month = Map(comboBoxChonThang.Text);
            string lopHoc = comboBoxChonLop.Text;
            dataGridViewQLDiemDanh.DataSource = new CSDL().SelectData("SELECT * FROM dbo.TESTXemBuoiHoc(\'" + lopHoc + "\' , " + month + ")");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(textBoxSearch.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên học sinh");
                return;
            }
            string month = Map(comboBoxChonThang.Text);
            string lopHoc = comboBoxChonLop.Text;
            string tenHS = textBoxSearch.Text; 
            dataGridViewQLDiemDanh.DataSource = new CSDL().SelectData("SELECT * FROM dbo.TESTXemBuoiHoc2( N\'" + tenHS +"\', \'" + lopHoc + "\' , " + month + ")");
        }



        

        private void dataGridViewQLDiemDanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewQLDiemDanh.CurrentCell is DataGridViewCheckBoxCell)
            {             

                // Save the changes by passing checkBoxState and keyValue accordingly
                string sql;
                int keyValue;

                if (Convert.ToBoolean(dataGridViewQLDiemDanh.CurrentCell.Value) == true)
                {
                    keyValue = 0;
                } else
                {
                    keyValue = 1;
                }
                List<CustomParameter> lstPara = new List<CustomParameter>();

                sql = "UpdateDD";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaBH",
                    value = dataGridViewQLDiemDanh.CurrentRow.Cells["MaBH"].Value.ToString()
                });


                lstPara.Add(new CustomParameter()
                {
                    key = "@MaHV",
                    value = dataGridViewQLDiemDanh.CurrentRow.Cells["MaHV"].Value.ToString()
                });
                

                lstPara.Add(new CustomParameter()
                {
                    key = "@CoTrenLop",
                    value = keyValue.ToString()
                });


                var rs = new CSDL().ExeCute(sql, lstPara);
                if (rs == 0)
                {
                    //MessageBox.Show("Cập nhật thành công");
                    //this.buttonLoad.PerformClick();
                    MessageBox.Show("Thao tác không thành công");
                }
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.Text = "Nhập tên học sinh...";
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Nhập tên học sinh...")
            {
                textBoxSearch.Text = "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new ThemBuoiHoc().ShowDialog();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật thành công");
            this.buttonLoad.PerformClick();
        }
    }
}
