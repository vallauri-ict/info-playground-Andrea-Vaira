using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionaleEventi
{
    public partial class interfacciaIscritto : Form
    {
        iscritto iscritto;
        int idEvento;
        string email;
        int telefono;
        public interfacciaIscritto()
        {

        }
        public interfacciaIscritto(int idEvento)
        {
            InitializeComponent();
            btnAction.Text = "Aggiungi";
            lblAction.Text = "Aggiungi iscritto";
            this.idEvento = idEvento;
        }

        public interfacciaIscritto(iscritto iscritto, int idEvento)
        {
            InitializeComponent();
            this.iscritto = new iscritto(iscritto.email, iscritto.telefono, iscritto.nome, iscritto.cognome,
                iscritto.genere, iscritto.data_nascita, idEvento);
            this.idEvento=idEvento;
            btnAction.Text = "Modifica";
            lblAction.Text = "Modifica iscritto";
            email = iscritto.email;
            telefono = iscritto.telefono;
        }


        private void interfacciaIscritto_Load(object sender, EventArgs e)
        {
            if(iscritto != null)
            {
                txtEmail.Text = iscritto.email;
                txtTelefono.Text = iscritto.telefono.ToString();
                txtNome.Text = iscritto.nome;
                txtCognome.Text = iscritto.cognome;
                cmbGenere.SelectedIndex = iscritto.genere == 'M' ? 0 : 1;
                dtpDataNascita.Value = iscritto.data_nascita;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            char gender = cmbGenere.SelectedIndex == 0 ? 'M' : 'F';
            iscritto iscrittoModificato = new iscritto(txtEmail.Text, Convert.ToInt32(txtTelefono.Text), txtNome.Text,
            txtCognome.Text, gender, dtpDataNascita.Value, idEvento);



            BindingList<iscritto> iscritti = new BindingList<iscritto>();
            iscritti = JsonTools.DeserializeFromFileIscritti();
            
            if(iscritto == null)
            {
                bool errore = false;
                foreach (var item in iscritti)
                {
                    if (item.email == iscrittoModificato.email && item.telefono == iscrittoModificato.telefono && item.idEvento == iscrittoModificato.idEvento)
                    {
                        errore = true;
                    }
                }
                if (!errore)
                {
                    iscritti.Add(iscrittoModificato);
                    JsonTools.SerializeToJsonIscritti(iscritti);
                    MessageBox.Show("L'aggiunta è andata a buonfine");
                }
                else
                {
                    MessageBox.Show("L'aggiunta non è andata a buonfine");
                }
                this.Close();
            }
            else
            {
                bool modificato = false;
                foreach (var item in iscritti)
                {
                    if (item.email == email && item.telefono == telefono && item.idEvento == iscrittoModificato.idEvento)
                    {
                        modificato = true;
                        item.email = iscrittoModificato.email;
                        item.telefono = iscrittoModificato.telefono;
                        item.nome = iscrittoModificato.nome;
                        item.cognome = iscrittoModificato.cognome;
                        item.genere = iscrittoModificato.genere;
                        item.data_nascita = iscrittoModificato.data_nascita;
                        item.idEvento = iscrittoModificato.idEvento;
                    }
                }
                if (modificato)
                {
                    JsonTools.SerializeToJsonIscritti(iscritti);
                    MessageBox.Show("La modifica è andata a buonfine");
                }
                else
                {
                    MessageBox.Show("La modifica non è andata a buonfine");
                }
                this.Close();
            }
            
        }
    }
}
