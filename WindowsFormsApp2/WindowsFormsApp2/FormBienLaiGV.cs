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
    public partial class FormBienLaiGV : Form
    {
        private string magv;
        public FormBienLaiGV(string magv)
        {
            this.magv = magv;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormBienLaiGV_Load(object sender, EventArgs e)
        {

        }
    }
}
