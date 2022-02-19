using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScontroTraVeicoli
{
    class Veicolo : IVeicoli
    {
        public int Integrita { get; set; }  
        public int Probabilità { get; set; }    
        public char Tipo { get; set; }  

        public Veicolo()
        {
            this.Integrita = 100;
        }

        public virtual Veicolo Scontro(Veicolo v1, Veicolo v2)
        {
            throw new NotImplementedException();
        }
    }
}
