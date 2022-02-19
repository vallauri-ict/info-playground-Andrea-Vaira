using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScontroTraVeicoli
{
    class Auto: Veicolo
    {
        public int Dimensione { get; set; }
        public Auto()
        {
            Probabilità = 10;
            Tipo = 'A';
        }
    }

}
