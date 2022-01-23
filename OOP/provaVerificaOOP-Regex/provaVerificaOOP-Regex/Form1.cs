using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provaVerificaOOP_Regex
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> dictSoci = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuovoSocio_Click(object sender, EventArgs e)
        {
            bool trovato = false;
            foreach (var item in dictSoci)
            {
                if(item.Key == txtMatricola.Text)
                    trovato = true;
            }
            if (!trovato)
            {
                Socio s = new Socio();
                s.matricola = txtMatricola.Text;
                s.nome = txtNome.Text;
                s.cognome = txtCognome.Text;

                addInDictionary(s);

                Associazione associazione = Associazione.GetInstance();
                associazione.AddSocio(s);
            }
            else
            {
                MessageBox.Show("Alunno gia' esistente");
            }

            pulisciCampi();

            

            
        }

        private void pulisciCampi()
        {
            txtMatricola.Text = "";
            txtNome.Text = "";
            txtCognome.Text = "";
        }

        private void addInDictionary(Socio s)
        {
            dictSoci.Add(s.matricola, s.nome+" "+s.cognome);
        }

        private void btnVisualizzaSoci_Click(object sender, EventArgs e)
        {
            Associazione associazione = Associazione.GetInstance();
            List<Socio> soci = associazione.returnList();
            // funzione di visualizzazione
        }
    }
}
