using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esempio_Verifica_multiform
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public bool pelle = false;
        public bool stoffa = false;
        public string marca = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        internal void pulisciCampi()
        {
            //
        }

        private void chkPelle_CheckedChanged(object sender, EventArgs e)
        {
            if (!pelle)
                pelle = true;
            else
                pelle = false;

        }

        private void chkStoffa_CheckedChanged(object sender, EventArgs e)
        {
            if (!stoffa)
                stoffa = true;
            else
                stoffa = false;
        }

        private void cmbMarca_SelectedValueChanged(object sender, EventArgs e)
        {
            marca = cmbMarca.SelectedItem.ToString();
        }
    }
}
