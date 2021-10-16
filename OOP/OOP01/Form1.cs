using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP01
{
    public partial class Form1 : Form
    {
        Rectangle r; // creiamo la variabile r di tipo Rectangle (andrà poi instanziata)
        Rectangle s = new Rectangle();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            //istanziamo la nostra variabile di tipo Rectangle
            r = new Rectangle();
            r.side1 = Convert.ToInt32(txtBase.Text);
            r.side2 = Convert.ToInt32(txtAltezza.Text);
            MessageBox.Show("Oggetto r -> Lati: " + r.side1.ToString() + " - " + r.side2.ToString());

            s.side1 = Convert.ToInt32(txtBase.Text);
            s.side2 = Convert.ToInt32(txtAltezza.Text);
            MessageBox.Show("Oggetto s -> Lati: " + s.side1.ToString() + " - " + s.side2.ToString());

            Rectangle t; // t è un puntatore ad un'area di memoria 
            t = r; // in questo modo mettiamo in t il contenuto di r, quindi anche t punterà all'oggetto Rectangle
            MessageBox.Show("Oggetto t -> Lati: " + t.side1.ToString() + " - " + t.side2.ToString());
        }
    }
}
