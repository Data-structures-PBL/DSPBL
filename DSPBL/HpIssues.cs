using System;
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
    public partial class HpIssues : Form
    {
        public HpIssues()
        {
            InitializeComponent();
        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HcareBut_Click(object sender, EventArgs e)
        {
            HpCare hpCare = new HpCare();
            this.Hide();
            hpCare.ShowDialog();
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
            HealthBut.Focus();
            HealthBut.BackColor = Color.Violet;
        }

        private void GraphBut_Click(object sender, EventArgs e)
        {
            Graphs grap = new Graphs();
            this.Hide();
            grap.ShowDialog();
            this.Close();
        }

        private void HpIssues_Load(object sender, EventArgs e)
        {
            HealthBut.Focus();
            HealthBut.BackColor = Color.Violet;
        }
    }
}
