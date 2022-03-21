using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxKoleksi.Items.Contains(textBoxInput.Text))
            {
                MessageBox.Show("kembar woy");
            }
            else
            {
               listBoxKoleksi.Items.Add(textBoxInput.Text.ToString());
            }
            textBoxInput.Text = "";
        }
        private void checkBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true)
            {
                radioButtonMerah.Enabled = true;
                radioButtonBiru.Enabled = true;
            }
            else
            {
                radioButtonBiru.Enabled = false;
                radioButtonMerah.Enabled = false;
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelOutput.Text = listBoxKoleksi.SelectedItem.ToString();
        }

        private void radioButtonMerah_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true)
            {
                if (radioButtonMerah.Checked == true)
                {
                    labelOutput.ForeColor = Color.Red;
                }
            }
        }

        private void radioButtonBiru_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true)
            {
                if (radioButtonBiru.Checked == true)
                {
                    labelOutput.ForeColor = Color.Blue;
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "";
            listBoxKoleksi.Items.Clear();
        }
    }
}
