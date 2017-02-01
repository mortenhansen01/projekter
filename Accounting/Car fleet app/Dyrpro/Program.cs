using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyrpro
{

    class Program
    {

        static void Main(string[] args)
        {

            var vovse = new Hund("Navn", 4, 4, "Tove" );
            Console.WriteLine("Antal ben: {0}",vovse.Ben);
            Console.WriteLine("Antal øjne: {0}",vovse.Ojne);
            Console.WriteLine("Hundens navn: {0}", vovse.Navn);
            Console.WriteLine("Mors navn: {0}", vovse.Morsnavn);
            Console.ReadLine();

        }
    }
}
