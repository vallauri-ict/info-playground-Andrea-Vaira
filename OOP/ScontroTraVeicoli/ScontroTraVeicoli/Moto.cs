using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScontroTraVeicoli
{
    class Moto:Veicolo
    {
        public int Velocità { get; set; }   
        public Moto() : base()
        {
            Probabilità = 6;
            Tipo = 'M';
        }

        /*public override Veicolo Scontro(Veicolo v1, Veicolo v2)
        {
            return v1;
        }*/
    }
}
