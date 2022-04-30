using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifica_Vaira
{
    public partial class Form1 : Form
    {
        List<Pianta> piante = new List<Pianta>();  
        List<Rosa> rose = new List<Rosa>();

        int num = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAggiungi_Click(object sender, EventArgs e)
        {
            if (txtColore.Text != "" && cmbGenere.SelectedItem.ToString() == "sempreverde")
            {
                Pianta p = new Pianta(num++, txtDescrizione.Text, cmbTipo.SelectedItem.ToString(), cmbGenere.SelectedItem.ToString(), Convert.ToInt32(txtCosto.Text));
                if(txtColore.Text != "")
                    p.inserisciColore(txtColore.Text);
                //p.calcolaPrezzo(Convert.ToInt32(txtCosto.Text));
                piante.Add(p);
            }
            else if (txtVarietà.Text != "")
            {
                Rosa r = new Rosa(num++, txtDescrizione.Text, cmbTipo.SelectedItem.ToString(), cmbGenere.SelectedItem.ToString(), Convert.ToInt32(txtCosto.Text));
                r.varieta = txtVarietà.Text;
                r.nRose = Convert.ToInt32( txtNRose.Text);
                //r.calcolaPrezzo(Convert.ToInt32(txtCosto.Text), Convert.ToInt32(txtNRose.Text));
                rose.Add(r);
            }
        }

        private void btnVisualizzaPiante_Click(object sender, EventArgs e)
        {
            txtVisualizzaLista.Text = "";
            foreach (var item in piante)
            {
                txtVisualizzaLista.Text += item.GetString() + Environment.NewLine;
            }
        }

        private void btnVisualizzaRose_Click(object sender, EventArgs e)
        {
            txtVisualizzaLista.Text = "";
            foreach (var item in rose)
            {
                txtVisualizzaLista.Text += item.GetString() +item.calcolaPrezzo(item.nRose).ToString()+ Environment.NewLine;
            }
        }

        private void btnRimuoviDaLista_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(txtCodPianta.Text);

            foreach (var item in piante)
            {
                if (item.ritornaNum() == cod)
                {
                    piante.Remove(item);
                    break;
                }
            }
            foreach (var item in rose)
            {
                if (item.ritornaNum() == cod)
                {
                    rose.Remove(item);
                    break;
                }
            }
            
        }
    }
}
