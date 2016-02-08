using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeelsBadMan_testi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temppi;
            double eurtousd;
            double usdtoeur;

            eurtousd = 1.11239;
            usdtoeur = 0.898963;

            try
            {
                if (textBox1.Text != "" && textBox1.Enabled == true)
                {
                    temppi = Convert.ToDouble(textBox1.Text);
                    temppi = temppi * eurtousd;
                    textBox1.Text = Convert.ToString(temppi);
                }

                if (textBox2.Text != "" && textBox2.Enabled == true)
                {
                    temppi = Convert.ToDouble(textBox2.Text);
                    temppi = temppi * usdtoeur;
                    textBox2.Text = Convert.ToString(temppi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
            }
            if (checkBox1.Checked == false)
            {
                textBox1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
            }
            if (checkBox2.Checked == false)
            {
                textBox2.Enabled = false;
            }
        }

    }
}
