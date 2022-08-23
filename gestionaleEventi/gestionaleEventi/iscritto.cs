using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionaleEventi
{
    public class iscritto
    {
        public string email; // chiave primaria
        public int telefono; // chiave primaria
        public string nome;
        public string cognome;
        public char genere;
        public DateTime data_nascita;
        public int idEvento; // chiave esterna

        public iscritto(string email, int phone, string name,
            string surname, char gender, DateTime date, int idEvento)
        {
            this.email = email;
            this.telefono = phone;
            this.nome = name;
            this.cognome = surname;
            this.genere = gender;
            this.data_nascita = date;
            this.idEvento = idEvento;
        }
    }
}
