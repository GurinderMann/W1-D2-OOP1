using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il tuo Nome");
            string Nome = Console.ReadLine();

            Console.WriteLine("Inserisci il tuo Cognome");
            string Cognome = Console.ReadLine();

            Console.WriteLine("Inserisci Età");
            int Età = Convert.ToInt16(Console.ReadLine());

      
            Persona persona = new Persona(Nome, Cognome, Età);

            Console.WriteLine(persona.GetNome());
            Console.WriteLine("------------------------");


            Console.WriteLine(persona.GetCognome());
            Console.WriteLine("------------------------");

            Console.WriteLine(persona.GetEtà());
            Console.WriteLine("------------------------");

            Console.WriteLine("Dettagli completi");
            Console.WriteLine(persona.GetDettagli());

            Console.WriteLine("------------------------");

            Console.WriteLine("------------------------");

            //Parte del Prodotto

            Console.WriteLine("Inserisci nome del prodotto");
            string name = Console.ReadLine();


            Console.WriteLine("Inserisci il prezzo del prodotto");
            decimal prezzo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Inserisci la quantità del prodotto");

            int quantità  = Convert.ToInt32(Console.ReadLine());

            Prodotto prodotto = new Prodotto(name, prezzo, quantità);

            Console.WriteLine("------------------------");
            Console.WriteLine("Costo totale del prodotto:");
            prodotto.TotalPrice();



            Console.ReadLine();
        }
    }
}
