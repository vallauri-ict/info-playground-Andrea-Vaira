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

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paziente p;

            p.nome = txtNome.Text;
            p.eta = Convert.ToInt32(txtEta.Text);
            p.colore = comboBox1.SelectedItem.ToString();
            p.temperatura = Convert.ToInt32(txtTemperatura);
            if (p.temperatura > 37)
                inserisciInCoda(p);
            else
                MessageBox.Show("Non è possibile far accede il paziente alla struttura");
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

            }
        }
    }
}
