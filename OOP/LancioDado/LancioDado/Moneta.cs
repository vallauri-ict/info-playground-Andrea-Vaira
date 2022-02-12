using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancioDado
{
    internal class Moneta
    {
        private int v;
        Random rnd = new Random();

        public Moneta()
        {
            this.v = 0;
        }

        public int V { get => v; }

        public void Lancio()
        {
             v = rnd.Next(2); // 0-->testa 1-->croce 
        }
    }
}
