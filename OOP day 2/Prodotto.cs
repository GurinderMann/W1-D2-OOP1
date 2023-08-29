using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP_day_2
{
    public class Prodotto
    {
        public string Name { get; set; }
        public decimal Prezzo { get; set; }
        public int Quantità { get; set; }

        public void TotalPrice()
        {
            Console.WriteLine(

                Prezzo * Quantità

                );
        }

        public Prodotto() { }

        public Prodotto (string nome, decimal prezzo, int quantità)
        {
            this.Name = nome;
            this.Prezzo = prezzo;
            this.Quantità = quantità;
        }
    }
}
