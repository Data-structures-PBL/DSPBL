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
            chart1.Visible = false;
            chart2.Visible = false;

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

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential("Pblgroup", "Pblgroupwork69");
            client.DownloadFile("ftp://66.220.9.50/My Documents/CovidTracker.txt", "C://csv files//CovidTracker.txt");

            StreamReader readfile = new StreamReader("C://csv files//CovidTracker.txt");

            chart1.Visible = true;
            chart2.Visible = true;

            while (readfile.Peek()!=-1)
            {
                string entry = readfile.ReadLine();
                string[] entries = entry.Split(',');
                string date = entries[0];
                string cases = entries[1];
                string recs = entries[2];
                string deds = entries[3];

                ListViewItem lvi = new ListViewItem(date);
                lvi.SubItems.Add(cases);
                lvi.SubItems.Add(recs);
                lvi.SubItems.Add(deds);
                listView1.Items.Add(lvi);

                for(int day = 0;day <=12;day++)
                {
                    chart1.Series["Total Cases"].Points.AddXY(entries[0], entries[1]);
                    chart1.Series["Recoveries"].Points.AddXY(entries[0], entries[2]);
                    chart1.Series["Deaths"].Points.AddXY(entries[0], entries[3]);

                    chart2.Series["Total Cases"].Points.AddXY(entries[0], entries[1]);
                    chart2.Series["Recoveries"].Points.AddXY(entries[0], entries[2]);
                    chart2.Series["Deaths"].Points.AddXY(entries[0], entries[3]);
                }
                
            }

        }
    }
}
