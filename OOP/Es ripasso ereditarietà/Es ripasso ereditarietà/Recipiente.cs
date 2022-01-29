using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_ripasso_ereditarietà
{
    
    internal class Recipiente
    {
        protected int capacita;
        protected int contenuto = 0;

        public Recipiente()
        {
            capacita = 1000;
        }

        public Recipiente(int k)
        {
            capacita = k;
        }

        public override string ToString()
        {
            return "Recipiente di capacità: "+capacita.ToString()+ " riempito di: " + contenuto;
        }

        public virtual void Set(int n)
        {
            capacita = n;
        }

        public virtual int Get()
        {
            return capacita;
        }

        public void Metti(int k)
        {
            if((k+contenuto) <= capacita)
            {
                 contenuto += k;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Non è possibile aggiungere tale quantità");
            }
        }

        public void Togli(int k)
        {
            if ((contenuto-k) >= 0)
            {
                contenuto -= k;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Non è possibile rimouvere tale quantità");
            }
        }
    }
}
