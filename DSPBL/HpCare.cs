﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSPBL
{
    public partial class HpCare : Form
    {
        public HpCare()
        {
            InitializeComponent();
        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
