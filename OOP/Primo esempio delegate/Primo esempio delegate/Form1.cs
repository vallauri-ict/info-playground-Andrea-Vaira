using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primo_esempio_delegate
{
    // Dichiarazione fuori della classe
    // Dichiarazione del delegate che accetta due parametri e restituisce un valore
    public delegate int Operazione(int a, int b);   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Scrivo e tre funzioni che utilizzerò con il delegate
        public int Somma(int x, int y)
        {
            return x + y;   
        }
        public int Sottrazione(int x, int y)
        {
            return x - y;
        }
        public int Prodotto(int x, int y)
        {
            return x * y;
        }
        private int Differenza(int a, int b, Operazione op)
        {
            if (a > b)
            {
                return op(a, b);
            }
            else
            {
                return op(b, a);
            }
        }

        private void btnPiu_Click(object sender, EventArgs e)
        {
            // Uso del delegate metodo1
            // Istanzio il delegate
            Operazione op = new Operazione(Somma);
            MessageBox.Show("Somma = "+op(10,15));
        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            // Passo il puntatore alla funzione
            Operazione op = Prodotto;
            MessageBox.Show("Prodotto = "+op(10,15));
        }

        private void btnMeno_Click(object sender, EventArgs e)
        {
            Operazione op = Sottrazione;
            MessageBox.Show("Differenza = "+Differenza(10,15, op));
        }

        
    }
}
