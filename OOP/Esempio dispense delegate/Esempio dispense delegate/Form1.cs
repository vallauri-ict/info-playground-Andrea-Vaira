using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esempio_dispense_delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MiaFunzione(int id)
        {
            MessageBox.Show("Elemento "+id+" salvato correttamente");
        }
        private void MiaFunzione2(int id)
        {
            MessageBox.Show("Secondo gestore d'evento");
        }
        private void btnSalva_Click(object sender, EventArgs e)
        {
            GestioneSalvataggio salva = new GestioneSalvataggio();

            salva.salvataggioEseguito += new salvataggioEseguitoEventHandler(MiaFunzione);
            salva.salvataggioEseguito += new salvataggioEseguitoEventHandler(MiaFunzione2);
            // id = 101
            salva.SalvaSuFile(101);
        }

       
    }
}
