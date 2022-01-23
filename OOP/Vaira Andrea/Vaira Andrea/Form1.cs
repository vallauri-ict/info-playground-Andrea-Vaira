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

namespace Vaira_Andrea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string> dict = new Dictionary<string, string>(); 

        private void btnAggiungiGiocatore_Click(object sender, EventArgs e)
        {
            string strEta = txtEta.Text;
            


            Regex regMatricola = new Regex(@"^[a-zA-Z]{4}[0-9]{3}[#$&]{1}$"); //TODO
            Regex regNome = new Regex(@"^[a-zA-Z0-9]{3,}$");
            Regex regEta = new Regex(@"^[0-9]{1,2}$");

            bool errore = false;

            if (!regMatricola.IsMatch(txtMatricola.Text))
            {
                errore = true;
                MessageBox.Show("Inserire una matricola corretta");
            }
            if (!regNome.IsMatch(txtUsername.Text))
            {
                errore = true;
                MessageBox.Show("Inserire uno username corretto");
            }
            if (!regNome.IsMatch(txtCognome.Text))
            {
                errore = true;
                MessageBox.Show("Inserire un cognome corretto");
            }
            if (txtEta.TextLength == 1)
            {
                txtEta.Text = "0" + txtEta.Text;
                if (!regEta.IsMatch(txtEta.Text))
                {
                    errore = true;
                    MessageBox.Show("Inserire un'età corretta");
                }
            }
            if(txtEta.TextLength > 2)
            {
                errore = true;
                MessageBox.Show("Inserire un'età corretta");
            }

            if (!errore)
            {
                bool esiste = ControlloEsistenza();

                if (!esiste)
                {
                    Giocatore g = Giocatore.creaGiocatore(txtMatricola.Text, txtUsername.Text, txtCognome.Text);

                    Squadra s = Squadra.GetInstance();
                    s.AddGiocatoreList(g);

                    dict.Add(txtMatricola.Text, txtCognome.Text + " " + txtUsername.Text);

                    
                }
                else
                    MessageBox.Show("Il giocatore "+txtCognome.Text+ " "+ txtUsername.Text+" è già stato inserito");

                Pulisci();
            }
            
        }

        private bool ControlloEsistenza()
        {
            bool trovato = false;
            foreach (var item in dict)
            {
                if(item.Key == txtMatricola.Text)
                {
                    trovato = true;
                }
            }
            if(trovato)
                return true;
            else
                return false;
        }

        private void Pulisci()
        {
            txtMatricola.Text = "";
            txtUsername.Text = "";
            txtCognome.Text = "";
            txtEta.Text = "";
        }

        private void btnVisualizzaSquadra_Click(object sender, EventArgs e)
        {
            Squadra s = Squadra.GetInstance();
            List<Giocatore> listGiocatori = s.getListGiocatori();
            string str = "Giocatori\n";
            if(listGiocatori.Count==0)
                MessageBox.Show("Nessun giocatore in lista");
            else
            {
                foreach (var item in listGiocatori)
                {
                    str += item.matricola + " " + item.nome + " " + item.cognome + "\n";
                }
                MessageBox.Show(str);
            }
        }

        private void btnCreaSquadra_Click(object sender, EventArgs e)
        {
            Squadra s = Squadra.GetInstance();
            lblSquadra.Text += s.GetNome();
            lblCitta.Text += s.GetCitta();
            lblPunteggio.Text += s.GetPunteggio();
            s.newSquadra = true;
        }
    }
}
