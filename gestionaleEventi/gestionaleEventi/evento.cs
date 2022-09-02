using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionaleEventi
{
    public class evento
    {
        public int idEvento; // chiave primaria
        public string tipologia;
        public string denominazione;
        public string descrizione;
        public DateTime data;
        public double costo;
        public string prezzo;

        public evento(int idEvento, string tipologia, string denominazione, string descrizione, DateTime data, double costo)
        {
            this.idEvento = idEvento;
            this.tipologia = tipologia;
            this.denominazione = denominazione;
            this.descrizione = descrizione;
            this.data = data;
            this.costo = costo;
            this.prezzo = costo.ToString() + " €";
        }
    }
}
