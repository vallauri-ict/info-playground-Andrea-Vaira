using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControl
{
    public partial class UserControl1: UserControl
    {
        private bool numero = false; // se true la txt accetta solo numeri
        private string testo; // testo della txt
        private int CifreDecimali = 0; // contiene il numero di cifre decimali

        public bool Numero { get => numero; set => numero = value; }
        public string Testo { 
            get {
                testo = UcTextBox.Text;
                return testo;
            }
            set {
                testo = value;  // value è il valore passato 
                UcTextBox.Text = testo;
            } }
        public int CifreDecimali1
        {
            get => CifreDecimali;
            set {
                CifreDecimali = value;
                ReimpostaTesto();
            }
        }

        public UserControl1()
        {
            InitializeComponent();
        }
        private void ReimpostaTesto()
        {
            if(numero && testo != "")
            {
                try
                {
                    // controllare che non ci sia più di una virgola
                    if (contaVirgola(testo) > 1)
                    {
                        throw new Exception("Ci sono troppe virgole");
                    }

                    double numero = Math.Round(Convert.ToDouble(testo), CifreDecimali);
                    testo = numero.ToString();
                }
                catch (Exception)
                {
                    throw new Exception("Valore non valido");
                }
            }
        }

        private int contaVirgola(string testo)
        {
            int count = 0;
            for (int i = 0; i < testo.Length; i++)
            {
                char c = Convert.ToChar(testo.Substring(i, 1));

                if (c == ',')
                    count++;
            }
            return count;
        }

        public void Pulisci()
        {
            testo = "";
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (numero)
            {
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == ',' || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }

        private void OnLeave(object sender, EventArgs e)
        {
            ReimpostaTesto();
        }
    }
}
