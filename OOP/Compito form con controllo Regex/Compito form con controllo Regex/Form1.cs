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
            Regex reg = new Regex(@"^[a-zA-Z]{3,}$");
            if (!reg.IsMatch(txtNome.Text) && txtNome.Text.Length != 0)
            {
                txtNome.ForeColor = Color.Red;
                epNome.SetError(txtNome, "Inserire nome corretto");
            }
            if(reg.IsMatch(txtNome.Text))
            ripulisciCampi(txtNome, epNome);
        }

        private void txtCognome_Leave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[a-zA-Z]{3,}$");
            if (!reg.IsMatch(txtCognome.Text) && txtCognome.Text.Length!=0)
            {
                txtCognome.ForeColor = Color.Red;
                epCognome.SetError(txtCognome, "Inserire cognome corretto");
            }
            if(reg.IsMatch(txtCognome.Text))
                ripulisciCampi(txtCognome, epCognome);
        }

        

        private void txtEtà_Leave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[0-9]{1,3}?$");
            
            if (!reg.IsMatch(txtEtà.Text) && txtEtà.Text.Length != 0) 
            {
                txtEtà.ForeColor = Color.Red;
                epEta.SetError(txtEtà, "Inserire eta' corretta");
            }
            else if(reg.IsMatch(txtEtà.Text) && txtEtà.Text.Length != 0 && (Convert.ToInt32(txtEtà.Text)<0 || Convert.ToInt32(txtEtà.Text) > 120))
            {
                txtEtà.ForeColor = Color.Red;
                epEta.SetError(txtEtà, "Inserire eta' corretta");
            }
            if (reg.IsMatch(txtEtà.Text) && txtEtà.Text.Length != 0 && (Convert.ToInt32(txtEtà.Text) >= 0 && Convert.ToInt32(txtEtà.Text) <= 120))
                ripulisciCampi(txtEtà, epEta);
        } 

        private void txtCAP_Leave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[0-9]{5}$");
            if (!reg.IsMatch(txtCAP.Text) && txtCAP.Text.Length != 0)
            {
                txtCAP.ForeColor = Color.Red;
                epCAP.SetError(txtCAP, "Inserire CAP corretto");
            }
            if (reg.IsMatch(txtCAP.Text))
                ripulisciCampi(txtCAP, epCAP);
        }

        private void txtCitta_Leave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[a-zA-Z]{3,}\s[A-Z]{2}$");
            if (!reg.IsMatch(txtCitta.Text) && txtCAP.Text.Length != 0)
            {
                txtCitta.ForeColor = Color.Red;
                epCitta.SetError(txtCitta, "Inserire citta' corretta");
            }
            if (reg.IsMatch(txtCitta.Text))
                ripulisciCampi(txtCitta, epCitta);
        }

        private void txtCF_Leave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[A-Z]{6}[0-9]{2}[ABCDEHLMPRST]{1}[0-9]{2}[A-Z]{1}[0-9]{3}[a-zA-Z]{1}$");
            if (!reg.IsMatch(txtCF.Text) && txtCF.Text.Length != 0)
            {
                txtCF.ForeColor = Color.Red;
                epCF.SetError(txtCF, "Inserire codice fiscale corretto");
            }
            if (reg.IsMatch(txtCF.Text))
                ripulisciCampi(txtCF, epCF);
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (!reg.IsMatch(txtMail.Text) && txtMail.Text.Length != 0)
            {
                txtMail.ForeColor = Color.Red;
                epMail.SetError(txtMail, "Inserire mail corretta");
            }
            if (reg.IsMatch(txtMail.Text))
                ripulisciCampi(txtMail, epMail);
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[a-z A-Z]{1}[a-zA-Z0-9]{4,}$");
            if(!reg.IsMatch(txtUsername.Text) && txtUsername.Text.Length != 0)
            {
                txtUsername.ForeColor = Color.Red;
                epUsername.SetError(txtUsername, "Inserire uno username corretto");
            }
            if (reg.IsMatch(txtUsername.Text))
                ripulisciCampi(txtUsername, epUsername);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[a-zA-Z0-9]{7,14}[-+!]+$");
            if (!reg.IsMatch(txtPassword.Text) && txtPassword.Text.Length != 0)
            {
                txtPassword.ForeColor = Color.Red;
                epPassword.SetError(txtPassword, "inserire password corretta");
            }
            if (reg.IsMatch(txtPassword.Text))
                ripulisciCampi(txtPassword, epPassword);
        }

        private void ripulisciCampi(TextBox txt, ErrorProvider ep)
        {
            txt.ForeColor = Color.Green;
            ep.Clear();
        }

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            bool vuoto = false;
            bool errato = false;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if(this.Controls[i] is TextBox)
                {
                    if (this.Controls[i].Text == "")
                    {
                        vuoto = true;
                    }
                    if (this.Controls[i].ForeColor == Color.Red)
                    {
                        errato = true;
                    }
                }
            }

            if (vuoto)
            {
                MessageBox.Show("Compilare tutti i campi prima di registrarsi");
            }
            if (errato)
            {
                MessageBox.Show("Compilare tutti i campi correttamente prima di registrarsi");
            }
            if(!errato && !vuoto)
            {
                lblResult.Text = "Elenco mail:\n";
                if (txtMail.Text.Contains(","))
                {
                    for (int i = 0; i < txtMail.Text.Split(',').Length; i++)
                    {
                        if (i == 0)
                            lblResult.Text += " ";
                        lblResult.Text += txtMail.Text.Split(',')[i] + "\n";
                    }
                }
                else
                    lblResult.Text += txtMail.Text;
            }


            
        }
    }
}
