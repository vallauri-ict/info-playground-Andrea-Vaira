using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacciaStrumenti
{
    class Tromba : Strumento
    {
        public override void Suona()
        {
            System.Windows.Forms.MessageBox.Show("Suona con la tromba che suona");
        }
    }
}
