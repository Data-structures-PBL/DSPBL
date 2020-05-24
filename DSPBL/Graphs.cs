using System;
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
    public partial class Graphs : Form
    {
        public Graphs()
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
            HpCare hpCare = new HpCare();
            this.Hide();
            hpCare.ShowDialog();
            this.Close();
        }

        private void GraphBut_Click(object sender, EventArgs e)
        {
            GraphBut.Focus();
            GraphBut.BackColor = Color.Violet;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Graphs_Load(object sender, EventArgs e)
        {
            GraphBut.Focus();
            GraphBut.BackColor = Color.Violet;

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

        private void Logo_Click(object sender, EventArgs e)
        {

        }
    }
}
