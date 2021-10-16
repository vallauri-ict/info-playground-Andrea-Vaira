using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifica_Multiform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string colore = "";
        public Form1 form1;
        private void btnInizia_Click(object sender, EventArgs e)
        {
            if (chkBianco.Checked)
                colore = "Bianco";
            else if (chkNero.Checked)
                colore = "Nero";
            else
                colore = "Colore a scelta";
            string scelta = form1.passaScelta();
            MessageBox.Show("Sta iniziando la partita "+scelta+ "colore "+colore);
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {

        }
    }
}
