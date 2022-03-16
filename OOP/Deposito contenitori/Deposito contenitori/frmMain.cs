using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Deposito_contenitori
{
    public partial class frmMain : Form
    {
        int prog;
        int qta;
        int index1;
        string liquido;
        Contenitore c;
        List<Contenitore> contenitori = new List<Contenitore>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLattina_Click(object sender, EventArgs e)
        {
            qta = Convert.ToInt32(Interaction.InputBox("Inserire la quantità contenitore", "LATTINA"));
            liquido = (Interaction.InputBox("Inserire il tipo di liquido", "Lattina"));
            c = new Lattina(qta, liquido, ref prog);
            contenitori.Add(c);
        }

        private void btnBidone_Click(object sender, EventArgs e)
        {
            qta = Convert.ToInt32(Interaction.InputBox("Inserire la quantià contenitore", "BIDONE"));
            liquido = (Interaction.InputBox("Inserire il tipo di liquido", "Bidone"));
            c = new Bidone(qta, liquido, ref prog);
            contenitori.Add(c);
        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            index1 = Convert.ToInt32(Interaction.InputBox("Inserire l'indice del primo contenitore ", "CONTENITORE"));
            try
            {
                Contenitore c1 = contenitori.ElementAt(index1 - 1);
                contenitori = utils.filtra(contenitori, c1);
                MessageBox.Show("Tutti i contenitori che contengono " + c1.liquido + " sono stati cancellati");

            }
            catch (Exception)
            {

                MessageBox.Show("Indice del contenitore errato. Il contenitore non esiste o è stato cancellato");
            }
        }

        private void btnConfronta_Click(object sender, EventArgs e)
        {
            try
            {
                index1 = Convert.ToInt32(Interaction.InputBox("Inserire l'indice del primo contenitore ", "Contenitore"));
                int index2 = Convert.ToInt32(Interaction.InputBox("Inserire l'indice del secondo contenitore ", "Contenitore"));
                Contenitore c1 = contenitori.ElementAt(index1 - 1);
                Contenitore c2 = contenitori.ElementAt(index2 - 1);
                c.confronta(c1, c2);
            }
            catch (Exception)
            {

                MessageBox.Show("Indice dei contenitori errato. Ii contenitori non esistono o sono stati cancellati");
            }
        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            string msg = "";
            foreach (Contenitore item in contenitori)
            {
                msg += item.liquido + " " + item.progressivo + "\n";
            }
            MessageBox.Show(msg, "STAMPA LISTA");
        }
    }
}
