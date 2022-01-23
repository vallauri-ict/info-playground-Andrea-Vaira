using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaira_Andrea
{
    internal class Squadra
    {
        private Squadra()
        { // costruttore privato
          // eventuali inizializzazioni di istanza
        }

        private static Squadra _instance = null;
        private string nome = "Squadra1";
        private string citta = "Città1";
        private string punteggio = "10";
        public bool newSquadra = false;
        private List<Giocatore> giocatori = new List<Giocatore>();
        public static Squadra GetInstance()
        {
            if (_instance == null) _instance = new Squadra();
            return _instance;
        }

        public void AddGiocatoreList(Giocatore g)
        {
            giocatori.Add(g);
        }

        public List<Giocatore> getListGiocatori()
        {
            return giocatori;
        }

        public string GetNome()
        {
            if (!newSquadra)
                return nome;
            else
                return "";
        }
        public string GetCitta()
        {
            if (!newSquadra)
                return citta;
            else
                return "";
        }
        public string GetPunteggio()
        {
            if (!newSquadra)
                return punteggio;
            else
                return "";
        }
    }
}


/*public class Singleton{
private Singleton() { // costruttore privato
// eventuali inizializzazioni di istanza
}
private static Singleton _instance=null;
public static Singleton GetInstance() {
if(_instance==null) _instance=new Singleton();
return _instance;
}*/