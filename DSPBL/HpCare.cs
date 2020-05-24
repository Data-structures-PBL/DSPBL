﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

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

        private void Infobut_Click(object sender, EventArgs e)
        {
            Form1 start = new Form1();
            this.Hide();
            start.ShowDialog();
            this.Close();
        }

        private void HealthBut_Click(object sender, EventArgs e)
        {
            HpIssues hpIssues = new HpIssues();
            this.Hide();
            hpIssues.ShowDialog();
            this.Close();
        }

        private void HcareBut_Click(object sender, EventArgs e)
        {
            HcareBut.BackColor = Color.Violet;
            HcareBut.Focus();
        }

        private void GraphBut_Click(object sender, EventArgs e)
        {
            Graphs grap = new Graphs();
            this.Hide();
            grap.ShowDialog();
            this.Close();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void HpCare_Load(object sender, EventArgs e)
        {
            HcareBut.Focus();
            HcareBut.BackColor = Color.Violet;

        }

        private void MenuBut_Click(object sender, EventArgs e)
        {

            //expand
            if (panel1.Width == 65)
            {
                panel1.Visible = false;
                panel1.Width = 250;
                PanelAnimation2.ShowSync(panel1);
            }
            //minimize
            else
            {
                panel1.Visible = false;
                panel1.Width = 65;
                PanelAnimation.ShowSync(panel1);
            }
        }
    }
}
