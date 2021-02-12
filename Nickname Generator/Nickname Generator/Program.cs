using System;
using System.Collections.Generic;

namespace Nickname_Generator
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> nicknames = new List<string>();
            nicknames.Add("The Extravagant");
            nicknames.Add("The Hacker");
            nicknames.Add("The Runner");
            nicknames.Add("The Engineer");
            nicknames.Add("The BookWorm");
            nicknames.Add("The \"Can't Shutup\"");

            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();

            //int num = 0;
            bool loop = true;
            while (loop == true)
            {
                int inputNum = Run();

                if (inputNum == 1) //Get new name
                {
                    Console.WriteLine("Enter First Name: ");
                    firstName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name: ");
                    lastName = Console.ReadLine();
                }

                if (inputNum == 2) //Create random nickname
                {
                    Random rnd = new Random();
                    int randnum = rnd.Next(0, nicknames.Count);

                    Console.WriteLine(firstName + " " + nicknames[randnum] + " " + lastName);
                }

                if (inputNum == 3) //List all nicknames
                {
                    Console.WriteLine("---------All Nicknames-----------");
                    Console.WriteLine(String.Join("\n", nicknames));
                    Console.WriteLine("----------------------------------");
                }
                if (inputNum == 4)
                {
                    Console.WriteLine("Write A Nickname of your Choice!");
     
                    nicknames.Add(Console.ReadLine());
                }

                if (inputNum == 5)
                {
                    Console.WriteLine("Write A Nickname that you would like to remove");

                        nicknames.Remove(Console.ReadLine());

                    Console.WriteLine("A chosen nickname has been removed!");
                    
                } 

                if (inputNum == 6)
                {
                    Console.WriteLine("Goodbye!");
                    loop = false;
                }
            }
        }

        public static int Run()
        {
            Console.WriteLine("-------Main Menu---------");
            Console.WriteLine("Press 1 to Change Name");
            Console.WriteLine("Press 2 to Display a Random Nickname");
            Console.WriteLine("Press 3 to Display All Nicknames");
            Console.WriteLine("Press 4 to Add a Nickname");
            Console.WriteLine("Press 5 to Remove a Nickname");
            Console.WriteLine("Press 6 to Exit");
            Console.WriteLine("--------------------------");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
