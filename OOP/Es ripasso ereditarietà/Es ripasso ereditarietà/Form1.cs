using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_ripasso_ereditarietà
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Recipiente recipiente;
        Bicchiere bicchiere;

        private void btnSettaRecipiente_Click(object sender, EventArgs e)
        {
            recipiente.Set(Convert.ToInt32(txtRecipiente.Text));
        }

        private void btnSettaBicchiere_Click(object sender, EventArgs e)
        {
            recipiente.Set(Convert.ToInt32(txtBicchiere.Text));
        }

        private void btnCreaRecipiente_Click(object sender, EventArgs e)
        {
            recipiente = new Recipiente();
            
        }

        private void btnCreaBicchiere_Click(object sender, EventArgs e)
        {
            bicchiere = new Bicchiere();
        }

        private void btnMettiInRecipiente_Click(object sender, EventArgs e)
        {
            recipiente.Metti(Convert.ToInt32(txtMettiInRecipiente.Text));
        }

        private void btnMettiInBicchiere_Click(object sender, EventArgs e)
        {
            bicchiere.Metti(Convert.ToInt32(txtMettiInBicchiere.Text));
        }

        private void btnTogliRecipiente_Click(object sender, EventArgs e)
        {
            recipiente.Togli(Convert.ToInt32(txtTogliRecipiente.Text));
        }

        private void btnTogliBicchiere_Click(object sender, EventArgs e)
        {
            bicchiere.Togli(Convert.ToInt32(txtTogliBicchiere.Text));
        }

        private void btnCapacitaRec_Click(object sender, EventArgs e)
        {
            MessageBox.Show(recipiente.ToString()); 
        }

        private void btnVediCapacitaBicchiere_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bicchiere.ToString());
        }
    }
}
