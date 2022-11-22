using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_W1_D2
{
    internal class Esperienza
    {
        public string Azienda { get; set; }
        public string JobTitle { get; set; }
        public string Dal { get; set; }
        public string Al { get; set; }
        public string Descrizione { get; set; }
        public string Compiti { get; set; }

        public Esperienza(){}

        public Esperienza( string azienda, string jobtitle, string dal, string al, string descrizione, string compiti )
        {
            Azienda = azienda;
            JobTitle = jobtitle;
            Dal = dal;
            Al = al;
            Descrizione = descrizione;
            Compiti = compiti;
        }
    }
}
