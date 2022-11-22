using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_W1_D2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cv NuovoCv = new Cv();

            NuovoCv.Info = new InformazioniPersonali("Mario", "Rossi", "3200000000", "mario@rossi.it");


            NuovoCv.Studi = new Studi("Dottore", "Politecnico Milano", "Laurea Magistrale", "22/09/2002", "15/07/2007") ;

            
            NuovoCv.Impiego = new Impiego();

            Esperienza NuovaEsp = new Esperienza("Epicode", "Developer", "2012", "2022", "Insegnante", "Insegnamento, consulenza");
            NuovoCv.Impiego.ListaImpiego.Add(NuovaEsp);
            Esperienza SecondEsp = new Esperienza("CapGemini", "Consulente", "2008", "2011", "Consulenza Informatica", "Consulenza, ricezione clienti ");
            NuovoCv.Impiego.ListaImpiego.Add(SecondEsp);
            Console.WriteLine(NuovoCv.Impiego.ListaImpiego.Count);
        }
    }
}
