using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectT3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            do
            {
                Console.WriteLine("----------MOVIE QUEUEING SYSTEM----------");
                Console.WriteLine("\n");
                Console.WriteLine("[1] - View Movie Schedule");
                Console.WriteLine("[2] - Buy Tickets");
                Console.WriteLine("[3] - View Order");
                Console.WriteLine("[4] - Proceed to Payment");
                Console.WriteLine("[5] - Quit Application");
                Console.WriteLine("\n");
                Console.Write("Enter Option: ");
                int.TryParse(Console.ReadLine(), out x);

                switch (x)
                {
                    case 1:
                        Schedule();
                        break;
                    case 2:
                        Schedule();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Environment.Exit(5);
                        break;
                    default:

                        break;
                }
            } while (x != 6);
        }

        static void Schedule()
        {
            Console.WriteLine();
            Console.WriteLine("   ----- CINEMA 1 -----");
            Console.WriteLine("Spider-Man: Far From Home");
            Console.WriteLine("        12:15 PM");
            Console.WriteLine("        3:00 PM");
            Console.WriteLine("        5:45 PM");
            Console.WriteLine("        8:30 PM");
            Console.WriteLine();
            Console.WriteLine("   ----- CINEMA 2 -----");
            Console.WriteLine("      The Lion King");
            Console.WriteLine("        11:00 AM");
            Console.WriteLine("        1:30 PM");
            Console.WriteLine("        4:00 PM");
            Console.WriteLine("        6:30 PM");
            Console.WriteLine("        9:00 PM");
            Console.WriteLine();
            Console.WriteLine("   ----- CINEMA 3 -----");
            Console.WriteLine("        Yesterday");
            Console.WriteLine("        1:40 PM");
            Console.WriteLine("        3:45 PM");
            Console.WriteLine("        5:50 PM");
            Console.WriteLine("        7:55 PM");

            Console.WriteLine();
            Console.WriteLine("Press 'Enter' to go back");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
