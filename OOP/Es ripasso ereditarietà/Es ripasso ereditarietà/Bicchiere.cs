using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_ripasso_ereditarietà
{
    internal class Bicchiere : Recipiente
    {
        public const int MAX = 1000;
        public Bicchiere()
        {
            capacita = 100;
        }
        public Bicchiere(int k)
        {
            if(k > MAX)
            {
                capacita = MAX;
            }
            else
            {
                capacita = k;
            }
        }
        public override string ToString()
        {
            return "Bicchire di capacità: "+capacita.ToString()+" riempito di "+contenuto.ToString();
        }

        new public virtual void Set(int n)
        {
            if(n > MAX)
                capacita = MAX;
            else
                capacita = n;
        }

        new public virtual int Get()
        {
            return capacita;
        }

        /*public void Metti(int k)
        {
            if ((k + contenuto) <= capacita)
            {
                contenuto += k;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Non è possibile aggiungere tale quantità");
            }
        }

         new public void  Togli(int k)
        {
            if ((k - contenuto) >= 0)
            {
                contenuto -= k;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Non è possibile rimouvere tale quantità");
            }
        }*/
    }
}
