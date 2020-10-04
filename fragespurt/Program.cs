using System;

namespace fragespurt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Frågesport om Obsidian Entertainment");
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("When was obsidian entertainment founded?");
            Console.WriteLine("a: 2005 | b: 2003 | c: 2001");

            int points = 0;
            //fråga 1
            while (points == 0)
            {
                string a = Console.ReadLine();

                if (a == "b")
                {
                    Console.WriteLine("That's correct!");
                    points++;
                    Console.WriteLine("You now have " + points + " point!");
                }
                else if (a == "a")
                {
                    Console.WriteLine("That is incorrect!");
                    Console.WriteLine("You now have " + points + " points!");
                }

                else if (a == "c")
                {
                    Console.WriteLine("That's is incorrect");
                    Console.WriteLine("You now have " + points + " points!");
                }
                else
                {
                    Console.WriteLine("Type a | b | c");
                }
            }
            //fråga 2

            while (points == 1)
            {
                string a = Console.ReadLine();
                Console.WriteLine("Who is the mother company of Obsidian Entertainment?");
                Console.WriteLine("a: Microsoft | b: Bethesda | c: Apple");
                a = Console.ReadLine();


                if (a == "b")
                {
                    Console.WriteLine("That is incorrect!");
                    Console.WriteLine("You now have " + points + " points!");
                }
                else if (a == "a")
                {
                    Console.WriteLine("That's correct!");
                    points++;
                    Console.WriteLine("You now have " + points + " points!");
                }

                else if (a == "c")
                {
                    Console.WriteLine("That's is incorrect");
                    Console.WriteLine("You now have " + points + " points!");
                }
                else
                {
                    Console.WriteLine("Type a | b | c");
                }
            }
            //fråga 3

            while (points == 2)
            {
                string a = Console.ReadLine();

                Console.WriteLine("Who is the founder of Obsidian Entertainment?");
                Console.WriteLine("a: Bill Gates | b: Steve Jobs | c: Feargus Urquhart");
                a = Console.ReadLine();

                if (a == "b")
                {
                    Console.WriteLine("That's is incorrect");
                    Console.WriteLine("You now have " + points + " points!");
                }
                else if (a == "a")
                {
                    Console.WriteLine("That is incorrect!");
                    Console.WriteLine("You now have " + points + " points!");
                }

                else if (a == "c")
                {
                    Console.WriteLine("That's correct!");
                    points++;
                    Console.WriteLine("You now have " + points + " points!");
                }
                else
                {
                    Console.WriteLine("Type a | b | c");
                }
            }

            Console.WriteLine("wow that is amazing you got every single one right!");

            Console.ReadLine();

        }




    }
}

