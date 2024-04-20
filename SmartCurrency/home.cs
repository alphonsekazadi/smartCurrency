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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
              DialogResult question = MessageBox.Show("Do you want to exit ?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(question == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrencyChange currencyPage = new CurrencyChange();
            this.Hide();
            currencyPage.Show();
        }
    }
}
