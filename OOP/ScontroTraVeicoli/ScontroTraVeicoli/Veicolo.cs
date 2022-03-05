using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScontroTraVeicoli
{
    class Veicolo : IVeicoli
    {
        public string Name { get; set; }
        public int Integrita { get; set; }  
        public int Probabilità { get; set; }    
        public char Tipo { get; set; }  
        Random rnd = new Random();  

        public Veicolo()
        {
            this.Integrita = 100;
        }

        public virtual Veicolo Scontro(Veicolo v2)
        {
            //ritorno il perdente
            if(this.Tipo == v2.Tipo)
            {
                switch (this.Tipo)
                {
                    case 'A':
                        if ((v2 as Auto).Dimensione > (this as Auto).Dimensione)
                            return this;
                        else
                            return v2;
                    case 'M':
                        if ((v2 as Moto).Velocità > (this as Moto).Velocità)
                            return this;
                        else
                            return v2;
                    case 'C':
                        if ((v2 as Camion).Peso > (this as Camion).Peso)
                            return this;
                        else
                            return v2;
                }
            }
            else
            {
                int esito = rnd.Next(0, this.Probabilità+v2.Probabilità);
                if (esito < this.Probabilità)
                    return v2;
                else
                    return this;
            }
            return v2;
        }
    }
}
