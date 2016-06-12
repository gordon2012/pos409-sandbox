using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos409_sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            Console.WriteLine("Welcome to the Simple Menu Demonstration Application");
            Console.WriteLine("====================================================");

            while (!input.Equals("X"))
            {
                Console.WriteLine(Environment.NewLine + "Main Menu");
                Console.WriteLine("=========");
                Console.WriteLine("1: Greeting");
                Console.WriteLine("2: Disclaimer");
                Console.WriteLine("X: Exit");

                input = Console.ReadLine();

                if (input.Equals("1"))
                {
                    Console.WriteLine("Hello, World!");
                }
                else if (input.Equals("2"))
                {
                    Console.WriteLine("The author is not responsible for any damages, real or imagined, caused by this program.");
                }
                else if (input.Equals("X"))
                {
                    Console.WriteLine("Goodbye.");
                }                
            }
        }
    }
}
