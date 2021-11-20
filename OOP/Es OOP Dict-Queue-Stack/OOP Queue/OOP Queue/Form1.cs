using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Queue
{
    public partial class Form1 : Form
    {
        public struct paziente
        {
            public string nome;
            public int eta;
            public string colore;
            public float temperatura;
        }

        Queue<paziente> rosso = new Queue<paziente>();
        Queue<paziente> giallo = new Queue<paziente>();
        Queue<paziente> verde = new Queue<paziente>();
        Queue<paziente> bianco = new Queue<paziente>();

        float tMax = 0;
        float tMin = 45;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paziente p;

            p.nome = txtNome.Text;
            txtNome.Text = "";
            p.eta = Convert.ToInt32(txtEta.Text);
            txtEta.Text = "";
            p.colore = comboBox1.SelectedItem.ToString();
            p.temperatura = Convert.ToInt32(txtTemperatura.Text);
            inserisciInCoda(p);
            if ((float)p.temperatura > tMax)
                tMax = p.temperatura;
            if ((float)p.temperatura < tMin)
                tMin = p.temperatura;
            txtTemperatura.Text = "";

            comboBox1.SelectedIndex = -1;
            txtNome.Focus();
        }

        private void inserisciInCoda(paziente p)
        {
            try
            {
                switch (p.colore)
                {
                    case "Rosso":
                        rosso.Enqueue(p);
                        break;
                    case "Giallo":
                        giallo.Enqueue(p);
                        break;
                    case "Verde":
                        verde.Enqueue(p);
                        break;
                    case "Bianco":
                        bianco.Enqueue(p);
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Il caricamento del paziente non è andato  a buon fine");
            }
        }

        private void btnNewPaziente_Click(object sender, EventArgs e)
        {
            paziente p;
            if(rosso.Count > 0)
            {
                p = rosso.Dequeue();
                MessageBox.Show("Paziente: "+p.nome+"\nColore: "+p.colore);
            }
            else if(giallo.Count > 0)
            {
                p = giallo.Dequeue();
                MessageBox.Show("Paziente: " + p.nome + "\nColore: " + p.colore);
            }
            else if( verde.Count > 0)
            {
                p = verde.Dequeue();
                MessageBox.Show("Paziente: " + p.nome + "\nColore: " + p.colore);
            }
            else if(bianco.Count > 0)
            {
                p = bianco.Dequeue();
                MessageBox.Show("Paziente: " + p.nome + "\nColore: " + p.colore);
            }
            else
            {
                MessageBox.Show("Non c'è nessun paziente in attesa");
            }
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La temperatura massima misurata è: "+tMax.ToString()+ "\nLa temperatura massima misurata è: "+tMin.ToString());
        }
    }
}
