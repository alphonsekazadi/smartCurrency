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
    public partial class CurrencyChange : Form
    {
        public CurrencyChange()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Do you want to exit ?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CurrencyChange_Load(object sender, EventArgs e)
        {
            label8.Enabled = false;
            label9.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double exchangeRate = double.Parse(textBox1.Text);

            double cdfAmount = double.Parse(textBox2.Text);

            double usdAmount = cdfAmount / exchangeRate;

            label9.Text = usdAmount.ToString();

            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double exchangeRate = double.Parse(textBox1.Text);

            double usdAmount = double.Parse(textBox2.Text);

            double cdfAmount = usdAmount * exchangeRate;

            label8.Text = cdfAmount.ToString();

            textBox2.Text = "";
            textBox2.Focus();
        }
    }
}
