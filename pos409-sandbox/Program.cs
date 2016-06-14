﻿using System;
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
                Console.WriteLine("2: Lottery");
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
                    Random rnd = new Random();
                    int[] numbers = { 0, 0, 0, 0, 0, 0 };
                    for (int i = 0; i < 6; i++)
                    {
                        int num;
                        bool unique;
                        do
                        {
                            num = rnd.Next(1, 49 + 1);
                            unique = true;
                            foreach (int n in numbers)
                            {
                                if (n == num)
                                {
                                    unique = false;
                                }
                            }
                        } while (!unique);
                        numbers[i] = num;
                    }
                    foreach (int n in numbers)
                    {
                        Console.Write(n.ToString() + " ");
                    }
                    Console.WriteLine();



                }
                else if (input.Equals("X"))
                {
                    Console.WriteLine("Goodbye.");
                }                
            }


            Console.ReadLine();

        }
    }
}
