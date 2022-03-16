using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito_contenitori
{
    static class utils
    {
        static public List<Contenitore> filtra(List<Contenitore> c, Contenitore campione)
        {
            List<Contenitore> contenitori = new List<Contenitore>();
            foreach (var contenitore in c)
            {
                if(contenitore.liquido != campione.liquido)
                {
                    contenitori.Add(contenitore);
                }
            }
            return contenitori;
        }
    }
}
