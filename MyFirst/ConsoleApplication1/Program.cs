using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class SamplesArrayList
    {
        class Program
    {

            static void Main(string[] args)
            {
                int[] numbers = new int[] { 1, 2, 3, 4 };
                Console.WriteLine("\n");
                Console.WriteLine("MENU");
                Console.WriteLine("");
                Console.WriteLine("Enter 1 for addition");
                Console.WriteLine("Enter 2 for subtraction");
                Console.WriteLine("Enter 3 for multiplication");
                Console.WriteLine("Enter 4 for division");
                Console.WriteLine("Please enter a number");
                var valg = Console.ReadLine();

                int valgnummer = Convert.ToInt32(valg);
                int count = 0;
                while (count != 1) {
                    count = 0;
                    foreach (int element in numbers)
                    {
                        count += 1;
                        Console.WriteLine(element);
                    }
                    if (count != 1)
                        {
                            Console.WriteLine("Please enter a number between 1 and 4");
                        Console.WriteLine("Count " + count);
                        valg = Console.ReadLine();
                        }
                        }
                    // Console.WriteLine("Indtastet: " + valg);
                    // Læs første værdi      
                    Console.WriteLine("Please enter first number");
            string first = Console.ReadLine();
            int firstnumber = Convert.ToInt32(first);
            Console.WriteLine("Please enter second number");
            string second = Console.ReadLine();
            int secondnumber = Convert.ToInt32(second);
            switch (valgnummer)
            {
                case 1:
                    var facit = firstnumber + secondnumber;
                    Console.WriteLine("{0} plus {1} er lig med: {2}", firstnumber, secondnumber, firstnumber + secondnumber );
                    break;
                case 2:
                    break;
                default:
                    break;
            }
            Console.ReadLine();
            
        }
    }
}
}

