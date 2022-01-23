using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Vaira_Andrea
{
    internal class Giocatore
    {
        public string matricola;
        public string nome;
        public string cognome;

        private Giocatore()
        {

        }

        internal static Giocatore creaGiocatore(string txtMatricola, string txtUsername, string txtCognome)
        {
            Giocatore giocatore = new Giocatore();
            giocatore.matricola = txtMatricola;
            giocatore.nome = txtUsername;
            giocatore.cognome = txtCognome;
            return giocatore;
        }
    }
}
