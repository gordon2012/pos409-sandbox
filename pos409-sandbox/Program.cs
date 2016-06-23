using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Reflection;

namespace pos409_sandbox
{
    // Struct
    public struct bookStruct
    {
        public string title;
        public string category;
        public string author;
        public int pages;
        public int currentPage;
        public string ISBN;
        public string coverStyle;

        public bookStruct(string title, string category, string author, int pages, string ISBN, string coverStyle)
        {
            this.title = title;
            this.category = category;
            this.author = author;
            this.pages = pages < 1 ? 1 : pages;
            this.currentPage = 1;
            this.ISBN = ISBN;
            this.coverStyle = coverStyle;
        }

        public void nextPage()
        {
            if (currentPage == pages )
            {
                Console.WriteLine("Already at the last page.");
            }
            else
            {
                currentPage++;
                Console.WriteLine("Going ahead to page " + currentPage);
            }
        }

        public void prevPage()
        {
            if (currentPage == 1)
            {
                Console.WriteLine("Already at the first page.");
            }
            else
            {
                currentPage++;
                Console.WriteLine("Going back to page " + currentPage);
            }
        }

        public void setPage(int page)
        {
            if (page >= 1 && page <= pages)
            {
                currentPage = page;
                Console.WriteLine("Page set to " + currentPage);
            }
            else
            {
                Console.WriteLine("Invalid page");
            }
        }

        public override string ToString()
        {
            return title + " by " + author + ", a " + coverStyle + " " + category + " book with " + pages + " page" + (pages == 1 ? "." : "s.") + " ISBN: " + ISBN;
        }

    }


    class Program
    {
        static string factorial(string input)
        {
            long num;

            Func<long, long> fac = null;
            fac = (n) =>
            {
                if (n == 0) return 1;

                long res = 0;

                checked
                {
                    try
                    {
                        res = fac(n - 1) * n;
                    }
                    catch(StackOverflowException)
                    {
                        return 0;
                    }
                    catch (Exception)
                    {
                        //Console.WriteLine(e.ToString());
                        throw;
                    }
                }
                return res;
            };
          
            //*
            checked
            {

                try 
                {
                    num = long.Parse(input);

                    if (num < 0)
                    {
                        //throw new ArgumentOutOfRangeException("input", "must not be negative");

                        //ArgumentOutOfRangeException ex;
                        //ex = new ArgumentOutOfRangeException("Must not be Negative", ex);


                        throw new ArgumentOutOfRangeException("Must not be Negative");

                       
                    }
                    return fac(num).ToString();
                }
                catch (FormatException)
                {
                    return "Format Exception";
                }
                catch (OverflowException)
                {
                    return "Overflow Exception";
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            //*/
        }


        static void Main(string[] args)
        {
            string menu = "";






            Console.WriteLine("Welcome to the Simple Menu Demonstration Application");
            Console.WriteLine("====================================================");

            bool first = true;

            while (true)
            {
                Console.WriteLine(Environment.NewLine + "Main Menu");
                Console.WriteLine("=========");
                Console.WriteLine("1: Strings");
                Console.WriteLine("2: Lottery");
                Console.WriteLine("3: Structs");
                Console.WriteLine("4: Factorial");
                Console.WriteLine("X: Exit");


                if(first)
                {
                    menu = "4";
                    first = false;
                } 
                else
                {
                    menu = first ? "4" : Console.ReadLine();
                }




                if (menu.Equals("1"))
                {

                    string[] fruits = { "Banana", "Orange", "Apple", "Kiwi", "Strawberry", "Grape" };
                    foreach (string f in fruits)
                    {
                        Console.WriteLine(f + " is a " + f.Length.ToString() + " character fruit.");
                    }

                }
                else if (menu.Equals("2"))
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

                else if (menu.Equals("3"))
                {
                    bookStruct myBook = new bookStruct("Design Patterns: Elements of Reusable Object-Oriented Software", "Software Engineering",
                                                        "Gang of Four", 395, "0-201-63361-2", "Paperback");
                    Console.WriteLine(myBook);
                    myBook.prevPage();
                    myBook.nextPage();
                    myBook.nextPage();
                    myBook.setPage(400);
                    myBook.setPage(395);
                    myBook.nextPage();

                    Console.WriteLine("========");

                    bookStruct nullBook = new bookStruct("Nullinomicon", "Errors", "void", 0, "0000", "Vacuum");
                    Console.WriteLine(nullBook);
                    nullBook.prevPage();
                    nullBook.nextPage();


                }
                else if (menu.Equals("4"))
                {
                    //Console.WriteLine(factorial(20).ToString("C"));
                    //int num = 0;
                    //double result = -1;

                    //while (num < 100)
                    //{
                    //    //result = factorial(num);
                    //    //Console.WriteLine(num++ + ": " + result);
                    //}

                    //Console.WriteLine(getFactorial(Console.ReadLine()));

                    string input = "";

                    while (true)
                    {

                        Console.Write("Enter number to factorialize: ");

                        input = Console.ReadLine();

                        if (input.Equals("X", StringComparison.OrdinalIgnoreCase))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(factorial(input));
                        }


                    }

                    

                }

                else if (menu.Equals("X", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Goodbye.");
                    break;
                }                
            }


            Console.ReadLine();

        }
    }
}
