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
    public partial class ThemBuoiHoc : Form
    {
        public ThemBuoiHoc()
        {
            InitializeComponent();
        }

        private void ThemBuoiHoc_Load(object sender, EventArgs e)
        {
            CSDL csdl = new CSDL();
            string getAllMaLH = "SELECT MaLH FROM LOPHOC";
            DataTable maLHTable = csdl.SelectData(getAllMaLH);
            comboBoxChonLop.DataSource = maLHTable.Copy();
            comboBoxChonLop.DisplayMember = "MaLH";
            comboBoxChonLop.ValueMember = "MaLH";

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {   // Khi luu:
            // + Them Buoi hoc
            // + Them Diem danh 
            CSDL csdl = new CSDL();
            
            string sql = "ThemMoiBH";
            string sqlThemDD = "";

            string getAllMaBH = "select MaBH from BUOIHOC where MaLH = \'" + comboBoxChonLop.Text + "\'";
            DataTable maMHTable = csdl.SelectData(getAllMaBH);

            string motMaBHTrongLop = maMHTable.Rows[0][0].ToString();

            // table de lay du lieu them diem danh cho tat ca hoc sinh trong lop vao buoi hoc moi tao
            string getDSHSTheoBuoi = "select * from dbo.XemDSHSTheoBuoi(\'"+ comboBoxChonLop.Text + "\', \'"+ motMaBHTrongLop + "\')";
            DataTable dsHSTable = csdl.SelectData(getDSHSTheoBuoi);

            string sqlGetMaBHVuaThem = "select next value for BuoiHocSeq";
            DataTable maBHVuaThemTable = csdl.SelectData(sqlGetMaBHVuaThem);
            int IntmaBHVuaThem = Int32.Parse(maBHVuaThemTable.Rows[0][0].ToString()) + 1;
            string maBHVuaThem = "BH" + IntmaBHVuaThem.ToString();

            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@thoiGian",
                value = dateTimePicker1.Value.ToString()
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MaLH",
                value = comboBoxChonLop.Text
            });

            var rs = new CSDL().ExeCute(sql, lstPara);
            if (rs == 1)
            {

                for (int i = 0; i < dsHSTable.Rows.Count; i++)
                {
                    List<CustomParameter> lstPara2 = new List<CustomParameter>();

                    sqlThemDD = "ThemMoiDD";
                    lstPara2.Add(new CustomParameter()
                    {
                        key = "@MaBH",
                        value = maBHVuaThem
                    });


                    lstPara2.Add(new CustomParameter()
                    {
                        key = "@MaHV",
                        value = dsHSTable.Rows[i][0].ToString()
                    });


                    lstPara2.Add(new CustomParameter()
                    {
                        key = "@CoTrenLop",
                        value = "0"
                    });


                    var rs2 = new CSDL().ExeCute(sqlThemDD, lstPara2);
                    if (rs2 == 1)
                    {
                        //MessageBox.Show("Cập nhật thành công");
                        //this.buttonLoad.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Thao tác không thành công");
                    }
                }
                MessageBox.Show("Thêm mới thành công"
                        + "\nMã lớp: " + comboBoxChonLop.Text + "mabh: " + maBHVuaThem
                        + "\nThời gian: " + dateTimePicker1.Value.ToString());
                                  
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }
        }
    }
}
