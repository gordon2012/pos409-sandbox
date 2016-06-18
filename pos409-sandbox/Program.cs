using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine("3: Structs");
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

                else if (input.Equals("3"))
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


                else if (input.Equals("X"))
                {
                    Console.WriteLine("Goodbye.");
                }                
            }


            Console.ReadLine();

        }
    }
}
