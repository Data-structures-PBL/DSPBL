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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Infobut.Focus();
            Infobut.BackColor = Color.Gray;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Infobut_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void DisplayTxt_Click(object sender, EventArgs e)
        {

        }

        private void HealthBut_Click(object sender, EventArgs e)
        {
            HpIssues hpIssues = new HpIssues();
            hpIssues.Show();
            this.Hide();
        }
    }
}
