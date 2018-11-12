using System;
using System.Collections.Generic;
using System.IO;

namespace Simple_Indexer
{
    class Program
    {
        private static List<String> namesList = new List<string>();
        static string path = Environment.CurrentDirectory;
        private static int option;

        static void Main(string[] args)
        {
            LoadList();
            while (true)
            {
                MainMenu();
            }
        }

        static void AddName()
        {
            Console.Clear();
            Console.Write("Add new name: ");
            string name = Console.ReadLine();
            namesList.Add(name.ToUpper());
            UpdateList();
        }

        static void DisplayList()
        {
            Console.Clear();
            Console.WriteLine("Name List:\n\n");

            if (namesList.Count == 0)
            {
                Console.WriteLine("NO NAMES/LIST FOUND");
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

                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("No puedes dejar el campo de opcion vacio!");
                }
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
                UpdateList();
            }
        }

        static void LoadList()
        {
            StreamReader f = new StreamReader(path + "\\List\\names.txt");
            if (f.Peek() > 0)
            {
                string[] names = f.ReadToEnd().Split(',');
                foreach (string n in names)
                {
                    namesList.Add(n.ToUpper());
                }
            }
            f.Close();
        }

        static void UpdateList()
        {
            if(namesList.Count > 0)
            {
                StreamWriter f = new StreamWriter(path + "\\List\\names.txt");
                string finalText = "";
                foreach (string name in namesList)
                {
                    finalText += name + ",";
                }
                f.WriteLine(finalText.Remove(finalText.Length - 1));
                f.Close();
            }
        }
    }
}
