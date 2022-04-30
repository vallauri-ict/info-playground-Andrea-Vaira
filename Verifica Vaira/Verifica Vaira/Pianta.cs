using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Vaira
{
    public class Pianta : PiantaA, IPrezzoPianta
    {
        public string colore { get; set; }

        public Pianta(int num, string descrizione, string tipo, string genere, int costo)
        {
            this.num = num;
            this.descrizione = descrizione;
            this.tipo = tipo;
            this.genere = genere;
            this.costo = costo;
        }

        public void inserisciColore(string colore)
        {
            if (this.genere != "sempreverde")
                this.colore = colore;
            else
                System.Windows.Forms.MessageBox.Show("Non è possibile assegnare un colore a una pianta sempreverde");

        }

        public double calcolaPrezzo()
        {
            return  costo + costo * 0.4;
        }

        public void getNum(int n)
        {
            this.num = n;
        }

        public string GetString()
        {
            double d = calcolaPrezzo();
            string str = num.ToString() +" - " + colore+" - " + descrizione + " - " + tipo + " - " + genere + " - " + d.ToString() ;
            return str;
        }

        public int ritornaNum()
        {
            return this.num;
        }
    }
}
