using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp
{
    public class Hovedmenu
    {
        public bool stop = true;
        public string nytstop = "";
        public double saldo;
        public int valg;
        public bool result;

        public Hovedmenu()
        {
            while (valg <= 3)
            {

            
                do
                {
                    Console.Clear();
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("==================== Welcome to ATM ======================");
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("Vælg funktion ");
                    Console.WriteLine("1) Indsæt penge ");
                    Console.WriteLine("2) Hæv penge ");
                    Console.WriteLine("3) Foretag indkøb");
                    Console.WriteLine("4) Afslut");
                    Console.WriteLine("==========================================================");
                    Console.Write("Indsæt valg: ");
                    result = Int32.TryParse((Console.ReadLine()), out valg);
                }
                while (!result);
                switch (valg)
                {
                    case 1:
                        Indsat indsat = new Indsat();
                        break;
                    case 2:
                        pengeud  pengeud = new pengeud();
                        break;
                    default:
                        break;
                }
            }
        }
    }
};
