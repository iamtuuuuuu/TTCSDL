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
    public partial class FormBienLaiGV : Form
    {
        private DataRow data;
        public FormBienLaiGV(DataRow data)
        {
            this.data = data;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormBienLaiGV_Load(object sender, EventArgs e)
        {
            var magv = data.ItemArray[3].ToString();
            labelHoTen.Text = new CSDL().Select("select hoten from giaovien where magv='" + magv + "'").ItemArray[0].ToString();
            labelMa.Text = magv;
            label5.Text = data.ItemArray[1].ToString();
            label7.Text = data.ItemArray[2].ToString();



            DateTime dt;
            string[] formats1 = { "dd/MM/yyyy hh:mm:ss tt" };

            if (DateTime.TryParseExact(data.ItemArray[1].ToString(), formats1,
                System.Globalization.CultureInfo.InvariantCulture,
                DateTimeStyles.None, out dt))
            {
            }


            string[] formats2 = { "d/M/yyyy hh:mm:ss tt" };

            if (DateTime.TryParseExact(data.ItemArray[1].ToString(), formats2,
               System.Globalization.CultureInfo.InvariantCulture,
               DateTimeStyles.None, out dt))
            {
                
            }
            string[] formats3 = { "d/MM/yyyy hh:mm:ss tt" };

            if (DateTime.TryParseExact(data.ItemArray[1].ToString(), formats3,
               System.Globalization.CultureInfo.InvariantCulture,
               DateTimeStyles.None, out dt))
            {

            }
            string[] formats4 = { "dd/M/yyyy hh:mm:ss tt" };

            if (DateTime.TryParseExact(data.ItemArray[1].ToString(), formats4,
               System.Globalization.CultureInfo.InvariantCulture,
               DateTimeStyles.None, out dt))
            {

            }


            //DateTime curDate = DateTime.ParseExact(
            //data.ItemArray[1].ToString(), "dd/MM/yyyy hh:mm:ss tt",
            //                            CultureInfo.InvariantCulture);
            DateTime preDate = dt.AddYears(-1);

            dataGridView1.DataSource = new CSDL().SelectData("select * from tesst('"+ magv+"','" + preDate.ToString()+ "','" + data.ItemArray[1].ToString()  + "')");
            //dataGridView1.DataSource = new CSDL().SelectData("select * from tesst('" + magv + "','02/09/2020 12:00:00 AM','02/10/2021 12:00:00 AM')");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
