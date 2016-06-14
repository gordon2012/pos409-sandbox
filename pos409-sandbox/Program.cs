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
                Console.WriteLine("1: Strings");
                Console.WriteLine("2: Disclaimer");
                Console.WriteLine("X: Exit");

                input = Console.ReadLine();

                if (input.Equals("1"))
                {

                    string[] fruits = { "Banana", "Orange", "Apple", "Kiwi", "Strawberry", "Grape" };
                    foreach (string f in fruits)
                    {
                        Console.WriteLine(f + " is a " + f.Length.ToString() + " character fruit.");
                    }

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
