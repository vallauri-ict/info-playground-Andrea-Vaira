using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;

namespace gestionaleEventi
{
    
    public partial class Form1 : Form
    {
        BindingList<iscritto> iscritti = new BindingList<iscritto>();
        BindingList<evento> eventi = new BindingList<evento>();
        BindingList<iscritto> iscrittiAdEventoSelezionato = new BindingList<iscritto>();
        int id;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            eventi = JsonTools.DeserializeFromFileEventi();
            iscritti = JsonTools.DeserializeFromFileIscritti();
            setupDgvEventi();
            setupDgvIscritti();
            dgvIscritti.Visible = false;
            btnNuovoIscritto.Visible = false;
            panelloNuovoIscritto.Visible = false;
            panelloNuovoEvento.Visible = false;
        }

        private void setupDgvEventi()
        {
            string[] intestazioni = new string[] { "id evento", "Tipologia", "Denominazione", "Descrizione", "Data", "Costo", "Prezzo" };
            dgvEventi.ColumnCount = 7;
            foreach (DataGridViewColumn column in dgvEventi.Columns)
            {
                column.HeaderText = intestazioni[column.Index];
            }
            dgvEventi.RowCount = eventi.Count();

            int i = 0;
            foreach (var item in eventi)
            {
                dgvEventi.Rows[i].Cells[0].Value = item.idEvento;
                dgvEventi.Rows[i].Cells[1].Value = item.tipologia;
                dgvEventi.Rows[i].Cells[2].Value = item.denominazione;
                dgvEventi.Rows[i].Cells[3].Value = item.descrizione;
                dgvEventi.Rows[i].Cells[4].Value = item.data.ToShortDateString();
                dgvEventi.Rows[i].Cells[5].Value = item.costo;
                dgvEventi.Rows[i].Cells[6].Value = item.prezzo;
                i++;
            }
        }

        private void setupDgvIscritti()
        {
            string[] intestazioni = new string[] { "Email", "Telefono", "Nome", "Cognome", "Genere", "Data di nascita" };
            dgvIscritti.ColumnCount = 6;
            foreach (DataGridViewColumn column in dgvIscritti.Columns)
            {
                column.HeaderText = intestazioni[column.Index];
            }
            
        }


        private void dgvEventi_CellClick(object sender, DataGridViewCellEventArgs e)
        {   iscritti.Clear();
            iscritti = JsonTools.DeserializeFromFileIscritti();
            DataGridViewRow row = dgvEventi.Rows[e.RowIndex];
            id = Convert.ToInt32(row.Cells[0].Value);
            uploadDgvIscritti(id); // id dell'evento
            dgvIscritti.Visible = true;
            btnNuovoIscritto.Visible = true;

            txtTipologiaEvento.Text = row.Cells[1].Value.ToString();
            txtDenominazioneEvento.Text = row.Cells[2].Value.ToString(); 
            txtDescrizioneEvento.Text = row.Cells[3].Value.ToString();
            dtpDataEvento.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
            txtCostoEvento.Text = row.Cells[5].Value.ToString();

            lblGestioneEvento.Text = "Modifica";
            btnGestioneEvento.Text = "Modifica";

            panelloNuovoEvento.Visible = true;
        }

        private void uploadDgvIscritti(int id)
        {
            iscrittiAdEventoSelezionato.Clear();
            foreach (var item in iscritti)
            {
                if(item.idEvento == id)
                {
                    iscrittiAdEventoSelezionato.Add(item);
                }
            }
            if(iscrittiAdEventoSelezionato.Count() > 0)
            {
                dgvIscritti.RowCount = iscrittiAdEventoSelezionato.Count();
                dgvIscritti.Visible = true;
            }
            else
            {
                dgvIscritti.Visible = false;
            }

            int i = 0;
            foreach (var item in iscrittiAdEventoSelezionato)
            {
                dgvIscritti.Rows[i].Cells[0].Value = item.email;
                dgvIscritti.Rows[i].Cells[1].Value = item.telefono;
                dgvIscritti.Rows[i].Cells[2].Value = item.nome;
                dgvIscritti.Rows[i].Cells[3].Value = item.cognome;
                dgvIscritti.Rows[i].Cells[4].Value = item.genere;
                dgvIscritti.Rows[i].Cells[5].Value = item.data_nascita.ToShortDateString();
                i++;
            }
        }

        private void btnNuovoIscritto_Click(object sender, EventArgs e)
        {
            txtEmail.ReadOnly = false;
            txtTelefono.ReadOnly = false;
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtNome.Text = "";
            txtCognome.Text = "";
            cmbGenere.SelectedIndex = -1;
            dtpDataNascita.Value = DateTime.Now;
            btnGestisciIscritto.Text = "Aggiungi";
            lblGestisciIscritto.Text = "Aggiungi";

            panelloNuovoIscritto.Visible = true;


        }

        private void dgvIscritti_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dgvIscritti.Rows[e.RowIndex];
            if (row.Cells[0].Value != null)
            {
                txtEmail.Text = row.Cells[0].Value.ToString();
                txtEmail.ReadOnly = true;
                txtTelefono.Text = row.Cells[1].Value.ToString();
                txtTelefono.ReadOnly = true;
                txtNome.Text = row.Cells[2].Value.ToString();
                txtCognome.Text = row.Cells[3].Value.ToString();
                cmbGenere.SelectedIndex = row.Cells[4].Value.ToString() == "M" ? 0 : 1;
                dtpDataNascita.Value = Convert.ToDateTime(row.Cells[5].Value);
                btnGestisciIscritto.Text = "Modifica";
                lblGestisciIscritto.Text = "Modifica";

                panelloNuovoIscritto.Visible = true;
            }
            
        }

        private void btnGestisciIscritto_Click(object sender, EventArgs e)
        {
            char gender = cmbGenere.SelectedIndex == 0 ? 'M' : 'F';
            iscritto iscrittoGestito = new iscritto(txtEmail.Text, Convert.ToDouble(txtTelefono.Text), txtNome.Text,
            txtCognome.Text, gender, dtpDataNascita.Value, id);

            iscritti = JsonTools.DeserializeFromFileIscritti();
            if (btnGestisciIscritto.Text == "Modifica")
            {
                bool modificato = false;
                foreach (var item in iscritti)
                {
                    if (item.email == iscrittoGestito.email && item.telefono == iscrittoGestito.telefono && item.idEvento == iscrittoGestito.idEvento)
                    {
                        item.email = iscrittoGestito.email;
                        item.telefono = iscrittoGestito.telefono;
                        item.nome = iscrittoGestito.nome;
                        item.cognome = iscrittoGestito.cognome;
                        item.genere = iscrittoGestito.genere;
                        item.data_nascita = iscrittoGestito.data_nascita;
                        item.idEvento = iscrittoGestito.idEvento;
                        modificato = true;
                    }
                }
                if (modificato)
                {
                    MessageBox.Show("Modifica avvenuta con successo");
                    JsonTools.SerializeToJsonIscritti(iscritti);
                }
                else
                {
                    MessageBox.Show("Errore nella modifica dell'iscritto");
                }
            }
            else if (btnGestisciIscritto.Text == "Aggiungi")
            {
                bool aggiungi = true;
                foreach (var item in iscritti)
                {
                    if(item.email == iscrittoGestito.email && item.telefono == iscrittoGestito.telefono && item.idEvento == iscrittoGestito.idEvento)
                    {
                        aggiungi = false;
                    }
                }
                if (aggiungi)
                {
                    iscritti.Add(iscrittoGestito);
                    JsonTools.SerializeToJsonIscritti(iscritti);
                    MessageBox.Show("Iscritto aggiunto con successo");
                }
                else
                {
                    MessageBox.Show("Errore nell'aggiunta dell'iscritto");
                }
                
            }

            uploadDgvIscritti(id);
            panelloNuovoIscritto.Visible = false;
        }

        private void btnNuovoEvento_Click(object sender, EventArgs e)
        {
            txtTipologiaEvento.Text = "";
            txtDenominazioneEvento.Text = "";
            txtDescrizioneEvento.Text = "";
            dtpDataEvento.Value = DateTime.Now;
            txtCostoEvento.Text = "";

            lblGestioneEvento.Text = "Aggiungi";
            btnGestioneEvento.Text = "Aggiungi";

            panelloNuovoEvento.Visible = true;
        }

        private void btnGestioneEvento_Click(object sender, EventArgs e)
        {
            

            if (btnGestioneEvento.Text == "Aggiungi")
            {
                int idEvento = eventi[eventi.Count - 1].idEvento + 1;
                evento eventoGestito = new evento(idEvento, txtTipologiaEvento.Text, txtDenominazioneEvento.Text, txtDescrizioneEvento.Text,
                    dtpDataEvento.Value, Convert.ToDouble(txtCostoEvento.Text));

                eventi.Add(eventoGestito);
                MessageBox.Show("Evento aggiunto correttamente");
                JsonTools.SerializeToJsonEventi(eventi);
            }
            else
            {
                evento eventoGestito = new evento(id, txtTipologiaEvento.Text, txtDenominazioneEvento.Text, txtDescrizioneEvento.Text,
                    dtpDataEvento.Value, Convert.ToDouble(txtCostoEvento.Text));

                bool modificato = false;
                foreach (var item in eventi)
                {
                    if (item.idEvento == eventoGestito.idEvento)
                    {
                        item.tipologia = eventoGestito.tipologia;
                        item.denominazione = eventoGestito.denominazione;
                        item.descrizione = eventoGestito.descrizione;
                        item.data = eventoGestito.data;
                        item.costo = eventoGestito.costo;
                        modificato = true;
                    }
                }
                if (modificato)
                {
                    MessageBox.Show("Evento modificato correttamente");
                    JsonTools.SerializeToJsonEventi(eventi);
                }
                else
                {
                    MessageBox.Show("Errore durante la modifica dell'evento");
                }
            }

            eventi = JsonTools.DeserializeFromFileEventi();
            setupDgvEventi();
            panelloNuovoEvento.Visible = false;
        }
    }
}
