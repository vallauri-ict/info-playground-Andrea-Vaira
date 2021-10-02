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

        public Form1(CheckBox chkPelle, CheckBox chkStoffa, ComboBox cmbMarca)
        {
            this.chkPelle = chkPelle;
            this.chkStoffa = chkStoffa;
            this.cmbMarca = cmbMarca;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkStoffa.Checked = false;
            chkPelle.Checked = false;
            cmbMarca.Select(0,0);
        }

    }
}
