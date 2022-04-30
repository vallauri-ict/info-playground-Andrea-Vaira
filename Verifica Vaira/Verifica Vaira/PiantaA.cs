using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Vaira
{
    public abstract class PiantaA
    {
        protected int num { get; set; }
        protected string descrizione { get; set; }
        protected string tipo { get; set; }
        protected string genere { get; set; }
        protected double costo  { get; set; }
        protected int prezzo { get; set; }

        public PiantaA() {
            
        }

        public PiantaA(string prezzo)
        {
            this.prezzo = Convert.ToInt32(prezzo);
        }

        
    }
}
