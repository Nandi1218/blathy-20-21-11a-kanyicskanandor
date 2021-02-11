using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            string removeAtInput = "";
            List<Adatok> adat = new List<Adatok>();
            int i = 0;
            string input = "";
            while (input != "stop")
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "Add":
                        {
                            adat.Add(new Adatok(Console.ReadLine()));
                            i++;
                        }
                        break;
                    case "Remove":
                        Console.WriteLine("At which index would you like to remove an instance?");
                        removeAtInput = Console.ReadLine();
                        adat.RemoveAt(int.Parse(removeAtInput));
                        Console.WriteLine("Removed");
                        break;
                    case "Update":

                        Console.WriteLine("At which index would you like to update the instance?");
                        removeAtInput = Console.ReadLine();
                        adat.RemoveAt(int.Parse(removeAtInput));
                        Console.WriteLine("Type in the new elements");
                        adat.Insert(int.Parse(removeAtInput), new Adatok(Console.ReadLine()));

                        Console.WriteLine("Updated");
                        break;
                    case "ls":

                        for (int j = 0; j < adat.Count; j++)
                        {
                            Console.WriteLine(adat[j]);
                        }
                        break;
                    default:
                        Console.WriteLine("Update, add or remove");
                        break;
                }
            }

           /* while (i <3) 
            {
                adat.Add(new Adatok(Console.ReadLine()));
                i++;
            }

            adat.RemoveAt(1);
            for (int j = 0; j < adat.Count; j++)
            {
                Console.WriteLine(adat[j]);
            }
           */
            Console.ReadKey();
        }       
    }

}
