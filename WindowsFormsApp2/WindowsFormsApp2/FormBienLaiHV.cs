﻿using System;
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
    public partial class FormBienLaiHV : Form
    {
        private string mahv;
        public FormBienLaiHV(string mahv)
        {
            this.mahv = mahv;
            InitializeComponent();
        }

        private void FormBienLaiHV_Load(object sender, EventArgs e)
        {

        }
    }
}
