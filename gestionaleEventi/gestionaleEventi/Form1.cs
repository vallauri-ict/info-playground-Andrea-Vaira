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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            eventi = JsonTools.DeserializeFromFileEventi();
            setupDgvEventi();
            
            
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

        private void dgvEventi_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            MessageBox.Show(dgvEventi.SelectedRows.Count.ToString());

            // CELLE SELECTED
        }
    }

    public class iscritto
    {
        public string email; // chiave primaria
        public int telefono; // chiave primaria
        public string nome;
        public string cognome;
        public char genere;
        public DateTime data_nascita;
        public int idEvento; // chiave esterna

        public iscritto(string email, int phone, string name, 
            string surname, char gender, DateTime date, int idEvento)
        {
            this.email = email;
            this.telefono = phone;
            this.nome = name;
            this.cognome = surname;
            this.genere = gender;
            this.data_nascita = date;
            this.idEvento = idEvento;
        }
    }

    public class evento
    {
        public int idEvento; // chiave primaria
        public string tipologia;
        public string denominazione;
        public string descrizione;
        public DateTime data;
        public float costo;
        public string prezzo;

        public evento(int idEvento, string tipologia, string denominazione, string descrizione, DateTime data, float costo)
        {
            this.idEvento = idEvento;
            this.tipologia = tipologia;
            this.denominazione = denominazione;
            this.descrizione = descrizione;
            this.data = data;
            this.costo = costo;
            this.prezzo = costo.ToString() + "€";
        }
    }
}
