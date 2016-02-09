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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString(Properties.SuperSettings.Default.EURTOUSD);
            textBox2.Text = Convert.ToString(Properties.SuperSettings.Default.USDTOEUR);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                double temp;

                temp = Convert.ToDouble(textBox1.Text);
                Properties.SuperSettings.Default.EURTOUSD = temp;
                Properties.SuperSettings.Default.Save();
                temp = Convert.ToDouble(textBox2.Text);
                Properties.SuperSettings.Default.USDTOEUR = temp;
                Properties.SuperSettings.Default.Save();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note, please use comma, not period when dealing with decimals\n\n" + "Exception: " + ex);
            }

            }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Properties.SuperSettings.Default.default_eurtousd);
            textBox2.Text = Convert.ToString(Properties.SuperSettings.Default.default_usdtoeur);

            double temp;

            temp = Convert.ToDouble(textBox1.Text);
            Properties.SuperSettings.Default.EURTOUSD = temp;
            Properties.SuperSettings.Default.Save();
            temp = Convert.ToDouble(textBox2.Text);
            Properties.SuperSettings.Default.USDTOEUR = temp;
            Properties.SuperSettings.Default.Save();
        }

    }
}
