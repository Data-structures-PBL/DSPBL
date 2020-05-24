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
    public partial class SplashForm : Form
    {
        Timer time = new Timer();
        public SplashForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }
        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(Pbar);
            timer1.Enabled = true;

        }
        void Pbar(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == 100) timer2.Enabled = true;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
