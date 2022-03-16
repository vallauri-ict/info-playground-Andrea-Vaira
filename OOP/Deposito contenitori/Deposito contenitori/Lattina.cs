using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito_contenitori
{
    public class Lattina : Contenitore
    {
        public Lattina(int qta, string liquido, ref int prog) : base(ref prog)
        {
            base.qta = qta;
            base.liquido = liquido.ToLower();
            base.tipo_contenitore = "lattina";
        }
    }
}
