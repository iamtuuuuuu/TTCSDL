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
            new FormBienLaiGV(null).ShowDialog();
        }

        private void FormQLTL_Load(object sender, EventArgs e)
        {

        }
    }
}
