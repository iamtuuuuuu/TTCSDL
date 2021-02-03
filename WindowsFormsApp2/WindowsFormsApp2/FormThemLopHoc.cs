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
    public partial class FormThemLopHoc : Form
    {

        private string malh;

        public FormThemLopHoc(string malh)
        {
            this.malh = malh;
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
