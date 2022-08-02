using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio_dispense_delegate
{
    // Dichiaro il delegato
    public delegate void salvataggioEseguitoEventHandler(int id);
    class GestioneSalvataggio
    {
        // Dichiaro l'evento
        public event salvataggioEseguitoEventHandler salvataggioEseguito;

        public void SalvaSuFile(int id)
        {
            System.Windows.Forms.MessageBox.Show("Sto salvando i dati");
            salvataggioEseguito(id);
        }
    }
}
