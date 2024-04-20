using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCurrency
{
    public partial class loadPage : Form
    {
        public loadPage()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                home homePage = new home();
                this.Hide();
                homePage.Show();
                timer1.Stop();
            }
            else {
                progressBar1.Value += 1;
                label7.Text = "Please wait..." + progressBar1.Value + "%";
            }
        }

        private void loadPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Do you want to exit ?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (question == DialogResult.Yes) {
                Application.Exit();
            }
        }
    }
}
