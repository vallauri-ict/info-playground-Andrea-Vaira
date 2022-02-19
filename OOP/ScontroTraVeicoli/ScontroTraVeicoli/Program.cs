using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScontroTraVeicoli
{
    class Program
    {
        public List<Veicolo> lstVeicoli = new List<Veicolo>();
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}


/*
Veicolo--> integrità, probabilità, tipo A C M

Auto--> dimensione 10
Camion--> peso 14
Moto-->velocità 6

list.count == 1

ps se sono dello stesso tipo verifico parametro+casualità 80%,20% altrimenti verifico probabilità e riduco integrità
*/