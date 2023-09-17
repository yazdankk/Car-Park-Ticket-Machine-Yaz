using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Park_Ticket_Machine_Yaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            while (loop == true)
            {
                Console.WriteLine("\n#####################################################\n\n  W E L C O M E   T O   B O B ' S   C A R   P A R K  \n\n#####################################################\n\nPlease enter car registration:\n");
                string carRegistration = Console.ReadLine();
                Console.WriteLine("\nRegistration entered: " + carRegistration + "\n\nIs this correct? (y/n)");
                string userChoice = Console.ReadLine();

                if (userChoice == "y")
                {
                    Console.ReadLine();
                    loop = false;
                }
                else
                {
                    
                }
            }
            Console.ReadLine();
        }
    }
}
