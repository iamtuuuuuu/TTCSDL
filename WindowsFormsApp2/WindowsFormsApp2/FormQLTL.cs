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
    public partial class FormQLTL : Form
    {
        public FormQLTL()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var magv = dataGridView1.CurrentRow.Cells["MaGV"].Value.ToString();

            var data = new CSDL().Select("select * from bienlaitraluong where magv='" + magv + "'");

            new FormBienLaiGV(data).ShowDialog();
        }

        private void FormQLTL_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new CSDL().SelectData("select * from bienlaitraluong");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reload()
        {
            dataGridView1.DataSource = new CSDL().SelectData("select * from bienlaitraluong");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormThemBL().ShowDialog();
            reload();
        }
    }
}
