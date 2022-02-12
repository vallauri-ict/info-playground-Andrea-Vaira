using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacciaIComparable
{
    public partial class Form1 : Form
    {
        List<Persona> list = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.Nome = txtNome.Text;
            p.Cognome = txtCognome.Text;
            p.Eta = Convert.ToInt32(txtEta.Text);

            list.Add(p);
        }

        private void btnElenca_Click(object sender, EventArgs e)
        {
            list.Sort();
            string s = "";
            foreach (var p in list)
            {
                s += "Cognome: " + p.Cognome + " Nome: " + p.Nome + " Età: " + p.Eta.ToString()+"\n";
            }
            MessageBox.Show(s);
        }
    }
}
