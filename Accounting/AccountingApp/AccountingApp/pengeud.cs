using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp
{
    class pengeud
    {
        public bool result;
        public bool stop = true;
        public string nytstop = "";
        public double saldo;
        public int indsatte;

        public pengeud() { 
             do
            {
                Console.Clear();

                Console.WriteLine("==========================================================");
                Console.WriteLine("==================== Welcome to ATM ======================");
                Console.WriteLine("Nuværende saldo" + saldo);
                Console.WriteLine("\n");
                Console.WriteLine("Hvor mange penge vil du hæve");
                Console.Write("==========================================================\n");

                Console.Write("Hvor mange penge vil du indsætte");
                result = Int32.TryParse((Console.ReadLine()), out indsatte);
                
            }
            while (!result);
        }
    }
}
