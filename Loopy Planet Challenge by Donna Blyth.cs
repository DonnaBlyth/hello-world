using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)

        {
            

            Console.WriteLine("     Menu of Planets");
            Console.WriteLine("     ===============");
            Console.WriteLine("        ");
            //Prints title of the program
            Console.WriteLine("1. Jupiter 2. Mars 3. Mercury 4. Neptune");
            Console.WriteLine("5. Pluto 6. Saturn 7. Uranus 8. Venus 9. Quit");
            //Prints the planet options
            Console.Write("Enter your menu choice: ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            //Allows user input into the menu

            Console.Write("Enter your weight on earth: ");
            int weight;
            weight = Convert.ToInt32(Console.ReadLine());
            //Asks for user weight on earth and inputs it into a variable
            Console.Write("Your weight on chosen planet: ");
            int planet;
            planet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your weight of {0}", weight);
            Console.WriteLine("pounds on earth would be {0}", weight + planet);
            Console.WriteLine("pounds on {0}", num);


        }
    }
    }