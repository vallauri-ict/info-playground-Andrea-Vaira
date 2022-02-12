using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LancioDado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDado_Click(object sender, EventArgs e)
        {
            Dado d = new Dado();
            d.lancio();
            MessageBox.Show("Dado: "+d.N);
        }

        private void btnMoneta_Click(object sender, EventArgs e)
        {
            Moneta m = new Moneta();
            m.Lancio();
            MessageBox.Show("Moneta: "+ ((m.V == 0) ? "Testa":"Croce"));
        }

        private void btnDadoAstratto_Click(object sender, EventArgs e)
        {
            DadoAbstract d = new DadoAbstract();
            d.Lancia();
            MessageBox.Show("Dado: " + d.X);
        }

        private void btnMonetaAstratto_Click(object sender, EventArgs e)
        {
            MonetaAbstract m = new MonetaAbstract();
            m.Lancia();
            MessageBox.Show("Moneta: " + ((m.X == 0) ? "Testa" : "Croce"));
        }
    }
}
