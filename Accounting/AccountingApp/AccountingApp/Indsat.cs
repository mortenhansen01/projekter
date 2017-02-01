using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp
{
    public class Indsat
    {
        public bool result;
        public string nytstop = "";
        public double saldo;
        public int indsatte;

        public Indsat()
        {
            do
            {
                Console.Clear();

                Console.WriteLine("==========================================================\n");
                Console.WriteLine("==================== Welcome to ATM ======================\n");
                Console.WriteLine("Nuværende saldo" + saldo);
                Console.WriteLine("\n");
                Console.WriteLine("Hvor mange penge vil du indsætte");
                Console.Write("==========================================================\n");

                //Console.WriteLine("Hvor mange penge vil du indsætte");
                result = Int32.TryParse((Console.ReadLine()), out indsatte);
                
            }
            while (!result);
        }
    }
};



