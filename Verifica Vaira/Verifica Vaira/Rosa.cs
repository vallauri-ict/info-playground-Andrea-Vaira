using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Vaira
{
    public class Rosa : PiantaA, IPrezzoRosa
    {
        public string varieta { get; set; }
        public int nRose { get; set; }

        public Rosa(int num, string descrizione, string tipo, string genere, int costo)
        {
            this.num = num;
            this.descrizione = descrizione;
            this.tipo = tipo;   
            this.genere = genere;
            this.costo = costo;
        }

        public double calcolaPrezzo(int nRose)
        {
            if(nRose > 1 && nRose <= 10)
            {
                return costo + costo * 0.2;
            }
            else
            {
                return costo + costo * 0.1;
            }
        }

        public string GetString()
        {
            string str = num.ToString() + " - " + varieta + " - " + descrizione + " - " + tipo + " - " + genere + " - "; //calcolaprezzo
            return str;
        }

        public int ritornaNum()
        {
            return this.num;
        }
    }
}
