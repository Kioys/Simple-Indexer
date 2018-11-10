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
            namesList.Add("MATAIS");
            namesList.Add("JOSE");
            namesList.Add("PEDRO");
            namesList.Add("DIEGO");
            namesList.Add("BERNARDO");
            namesList.Add("ANGEL");
            while (true)
            {
                MainMenu();
            }
        }

        static void AddName()
        {
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
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option\n\n");
            while (true)
            {
                Console.Write("[ 1 ] Add a name to the list\n\n[ 2 ] Display all the names\n\n[ 3 ] Delete a name off the list");
                Console.Write("\n\n>>> ");
                option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    AddName();
                }
                else if (option == 2)
                {
                    DisplayList();

                    Console.WriteLine("\n\nPress any key to continue...");
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    DeleteName();
                }
                break;
            }
        }

        static void DeleteName()
        {
            DisplayList();
            Console.Write("\n\n[DELETE] Choose a name: ");
            try
            {
                option = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("\n\nNO PUEDES COLOCAR LETRAS, SOLO NUMEROS.");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
            }

            if (option <= 0 || option > namesList.Count)
            {
                Console.WriteLine("\n\nNo puede ser menor o igual a 0 o un nombre que no este en la lista");
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
            }
            else
            {
                namesList.Remove(namesList[option - 1]);
            }
        }

    }
}
