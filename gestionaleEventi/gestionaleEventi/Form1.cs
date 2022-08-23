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
            dgvIscritti.RowCount = iscrittiAdEventoSelezionato.Count();

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
            interfacciaIscritto form2 = new interfacciaIscritto(id);
            form2.ShowDialog();
            dgvIscritti.Visible = false;
        }

        private void dgvIscritti_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dgvIscritti.Rows[e.RowIndex];
            interfacciaIscritto form2 = new interfacciaIscritto(new iscritto(
                row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[1].Value), row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(), Convert.ToChar(row.Cells[4].Value), 
                Convert.ToDateTime(row.Cells[5].Value.ToString()), id), id);
            
            form2.ShowDialog();
            dgvIscritti.Visible = false;
        }
    }
}
