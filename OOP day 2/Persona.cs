using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_day_2
{
    public class Persona
    {
        public string Nome { get; set; }

        public string Cognome { get; set; }
        public int Età { get; set; }

        public string GetNome ()
        {
            return Nome;

        }

        public string GetCognome ()
        {
           return Cognome;
        }

        public int GetEtà ()
        {
            return Età;
          
        }

        public string GetDettagli() {

            return Nome + " " +  Cognome + " " + " " + Età;

        }

       public  Persona () { }

       public  Persona (string Nome, string Cognome, int Età) 
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Età = Età;
        }
    }
}
