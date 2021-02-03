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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new FormBienLaiHV(null).ShowDialog();
        }

        private void FormQLTHP_Load(object sender, EventArgs e)
        {

        }
    }
}
