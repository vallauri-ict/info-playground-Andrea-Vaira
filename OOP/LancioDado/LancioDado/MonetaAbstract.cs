using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancioDado
{
    internal class MonetaAbstract : OggettoLanciato
    {
        Random random = new Random();
        public MonetaAbstract()
        {
            x = 0;
        }
        public override void Lancia()
        {
            x = random.Next(2);
        }
    }
}
