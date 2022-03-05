using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScontroTraVeicoli
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Veicolo> lstVeicoli = new List<Veicolo>();
            Console.Write("Inserire il numero di auto: ");
            int len = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < len; i++)
            {
                Auto a = new Auto();
                Console.Write("Inserisci dimensione: ");
                a.Dimensione = Convert.ToInt32(Console.ReadLine());
                a.Name = "Auto"+(i+1).ToString();
                lstVeicoli.Add(a);
            }
            Console.Write("Inserire il numero di moto: ");
            len = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < len; i++)
            {
                Moto a = new Moto();
                Console.Write("Inserisci velocità: ");
                a.Velocità = Convert.ToInt32(Console.ReadLine());
                a.Name = "Moto" + (i + 1).ToString();
                lstVeicoli.Add(a);
            }
            Console.Write("Inserire il numero di camion: ");
            len = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < len; i++)
            {
                Camion a = new Camion();
                Console.Write("Inserisci peso: ");
                a.Peso = Convert.ToInt32(Console.ReadLine());
                a.Name = "Moto" + (i + 1).ToString();
                lstVeicoli.Add(a);
            }
            Console.WriteLine("-------Partecipanti alla gara-------");
            stampaLista(lstVeicoli);
            Console.WriteLine("Premi invio per iniziare la gara");
            while(lstVeicoli.Count > 1)
            {
                int index = rnd.Next(0, lstVeicoli.Count);
                Veicolo v = lstVeicoli[index];
                index = rnd.Next(0, lstVeicoli.Count);
                stampaScontro(v, lstVeicoli[index]);
                lstVeicoli.Remove(v.Scontro(lstVeicoli[index]));
                stampaLista(lstVeicoli);
            }

            Console.ReadKey();
        }

        private static void stampaScontro(Veicolo v1, Veicolo v2)
        {
            Console.WriteLine("Scontro tra "+v1.Name+" e "+v2.Name);
        }

        private static void stampaLista(List<Veicolo> lst)
        {
            Console.WriteLine("Lista veicoli");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write(lst[i].Name + " Integrità: " + lst[i].Integrita);
                if(lst[i].Tipo == 'A')
                {
                    Console.Write(" Dimensione: "+(lst[i] as Auto).Dimensione.ToString());
                }
                else if (lst[i].Tipo == 'M')
                {
                    Console.Write(" Velocità: " + (lst[i] as Moto).Velocità.ToString());
                }
                else 
                {
                    Console.Write(" Peso: " + (lst[i] as Camion).Peso.ToString());
                }
                Console.WriteLine();
            }
        }
    }
}


/*
Veicolo--> integrità, probabilità, tipo A C M

Auto--> dimensione 10
Camion--> peso 14
Moto-->velocità 6

list.count == 1

ps se sono dello stesso tipo verifico parametro+casualità 80%,20% altrimenti verifico probabilità e riduco integrità
*/