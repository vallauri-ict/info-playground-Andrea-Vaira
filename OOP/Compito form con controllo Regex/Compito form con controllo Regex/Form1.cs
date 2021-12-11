using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Compito_form_con_controllo_Regex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[a-zA-Z]{3}$");
            if (!reg.IsMatch(txtNome.Text))
            {
                MessageBox.Show("Inserire input corretto");
            }

        }

        private void txtCognome_Leave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[a-zA-Z]{3}$");
            if (!reg.IsMatch(txtCognome.Text))
            {
                MessageBox.Show("Inserire input corretto");
            }
        }

        private void txtEtà_Leave(object sender, EventArgs e)
        {

        }

        private void txtCAP_Leave(object sender, EventArgs e)
        {

        }

        private void txtCitta_Leave(object sender, EventArgs e)
        {

        }

        private void txtCF_Leave(object sender, EventArgs e)
        {

        }

        private void txtMail_Leave(object sender, EventArgs e)
        {

        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {

        }
    }
}
