using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito_contenitori
{
    public class Contenitore : Icmp
    {
        public int progressivo = 0;
        protected int qta;
        public string liquido;
        protected string tipo_contenitore;
        protected Contenitore(ref int prog)
        {
            prog++;
            progressivo = prog;
        }
        public void confronta(Contenitore c1, Contenitore c2)
        {
            string msg;
            
            if(c1.tipo_contenitore == c2.tipo_contenitore)
            {
                if(c1.qta > c2.qta)
                {
                    msg = "Il primo contenitore ha una quantità di liquido superiore";
                }
                else if(c1.qta < c2.qta)
                {
                    msg = "Il secondo contenitore ha una quantità di liquido superiore";
                }
                else
                {
                    msg = "Entrambi i contenitori hanno la stessa quantità di liquido";
                }
                System.Windows.Forms.MessageBox.Show(msg, c1.tipo_contenitore.ToUpper());
            }

        }

        public string stampa()
        {
            string msg = "tipo: " + tipo_contenitore + " quantità: " + qta + " liquido: " + liquido + " progressivo: " + progressivo;
            return msg;
        }
    }
}
