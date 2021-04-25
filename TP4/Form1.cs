using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Enablebutton ()
        {
            if ((txtnomprenom.Text != "") & (txtds.Text != "") & (txtNP.Text != ""))
            {

                btcal.Enabled = true;

            }
            else
            {
                btcal.Enabled = false;
            }
        }

        private void txtnomprenom_TextChanged(object sender, EventArgs e)
        {
            Enablebutton();
        }

        private void txtds_TextChanged(object sender, EventArgs e)
        {
            Enablebutton();
        }

        private void txtexaman_TextChanged(object sender, EventArgs e)
        {
            Enablebutton();
        }

        private void txtNP_TextChanged(object sender, EventArgs e)
        {
            Enablebutton();
        }

        private void txtmoyenne_TextChanged(object sender, EventArgs e)
        {
            if (txtmoyenne.Text != "")
            {
                btAdd.Enabled = true;
                btcal.Enabled = false;
            }
            else
            {
                btAdd.Enabled = false;
            }
        }
        public void clear ()
        {
            txtexaman.Clear();
            txtmoyenne.Clear();
            txtnomprenom.Clear();
            txtNP.Clear();
            txtds.Clear();
        }

        private void btcal_Click(object sender, EventArgs e)
        {
            Etudiant et = new Etudiant();
            et.Instialisation(txtnomprenom.Text, int.Parse(txtNP.Text), int.Parse(txtexaman.Text), int.Parse(txtNP.Text));
            txtmoyenne.Text = et.CalculMoyenne().ToString();

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Etudiant et = new Etudiant();
            et.Instialisation(txtnomprenom.Text, int.Parse(txtNP.Text), int.Parse(txtexaman.Text), int.Parse(txtNP.Text));
            Liste.Items.Add(et.Affiche());
            clear();

        }

        private void Liste_SelectedIndexChanged(object sender, EventArgs e)
        {
          if(Liste.SelectedIndex != -1)
            {
                btSupp.Enabled = true;
            } else
            {
                btSupp.Enabled = false;
            }
        }

        private void btSupp_Click(object sender, EventArgs e)
        {
            Liste.Items.Remove(Liste.SelectedItem);
        }
    }
}
