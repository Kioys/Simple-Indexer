using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Indexer
{
    class Program
    {
        private static List<String> namesList = new List<string>();
        private static int option;
        static void Main(string[] args)
        {
            while (true)
            {
                MainMenu();
            }
        }

        static void AddName()
        {
            Console.WriteLine("AAA");
            while (true)
            {
                Console.Clear();
                Console.Write("Add new name: ");
                string name = Console.ReadLine();
                namesList.Add(name);
                break;
            }
        }

        static void DisplayList()
        {
            
            Console.Clear();
            Console.WriteLine("Name List:\n\n");
            if (namesList.Count == 0)
            {
                Console.WriteLine("NO NAMES FOUND");
            }
            else
            {
                int count = 1;
                foreach (string name in namesList)
                {

                    Console.Write("  [{0}] {1}\n", count, name);
                    count++;
                }
            }
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option\n\n");
            while (true)
            {
                Console.Write("[ 1 ] Add a name to the list\n\n[ 2 ] Display all the names\n\n");
                Console.Write(">>> ");
                option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    AddName();
                }
                else if (option == 2)
                {
                    DisplayList();
                }
                break;
            }
        }

    }
}
