using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancioDado
{
    internal class DadoAbstract : OggettoLanciato
    {
        Random random = new Random();
        public DadoAbstract()
        {
            x = 1;
        }
        public override void Lancia()
        {
            x = random.Next(6) + 1;
        }
    }
}
