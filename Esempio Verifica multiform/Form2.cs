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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string chkRivestimenti, ComboBox cmbMarca)
        {
            lbl.Text = "La macchina scelta è: " + cmbMarca.SelectedItem.ToString() + "\n Rivestimenti: "+chkRivestimenti;
        }
    }
}
