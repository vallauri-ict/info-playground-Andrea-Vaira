using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    class Mostro
    {
        public string nome;
        public double punti;
        public Mostro()
        {
        }
        public Mostro(string n)
        {
            nome = n;
            punti = 100;
        }
        public double Valore()
        { // punti del Mostro
            return punti;
        }
    }
}
