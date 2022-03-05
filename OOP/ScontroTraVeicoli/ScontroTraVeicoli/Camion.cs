using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScontroTraVeicoli
{
    class Camion : Veicolo
    {
        public int Peso { get; set; }
        public Camion() : base()
        {
            Tipo = 'C';
            Probabilità = 14;
        }

        /*public override Veicolo Scontro(Veicolo v1, Veicolo v2)
        {
            return v1;
        }*/
    }
}
