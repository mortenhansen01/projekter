using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp
{

    public class Program
    
        public bool stop = true;
        public string nytstop = "";
        public double saldo;
        public int result;
        public int indsatte;

        static void Main(string[] args)
        {
            //Hovedmenu Hovedmenu = new Hovedmenu();
            Kunde kunde1 = new Kunde();
        }

     private void pengeud() {
                Console.Clear();
                Console.WriteLine("==========================================================");
                Console.WriteLine("==================== Welcome to ATM ======================");
                Console.WriteLine("Nuværende saldo" + kunde1.Saldo);
                Console.WriteLine("\n");
                Console.WriteLine("Hvor mange penge vil du hæve");
                Console.Write("==========================================================\n");

                Console.Write("Hvor mange penge vil du indsætte");
                result = Int32.TryParse((Console.ReadLine()), out indsatte);
            }             

       private void pengeind(Kunde kunde) { 
        
            do
            {
                Console.Clear();

                Console.WriteLine("==========================================================\n");
                Console.WriteLine("==================== Welcome to ATM ======================\n");
                Console.WriteLine("Nuværende saldo" + kunde.Saldo);
                Console.WriteLine("\n");
                Console.WriteLine("Hvor mange penge vil du indsætte");
                Console.Write("==========================================================\n");

                //Console.WriteLine("Hvor mange penge vil du indsætte");
                result = Int32.TryParse((Console.ReadLine()), out indsatte);

            }
            while (!result);
        }

    
}
