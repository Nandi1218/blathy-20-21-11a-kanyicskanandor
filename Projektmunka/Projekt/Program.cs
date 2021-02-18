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
            List<GameData> dataList = new List<GameData>();



            string removed= default;
            string removeAtInput = "";          
            int i = 0;  
            string input = default;             

            
            while (input != "stop")             //Main loop
            {
               
                input = Console.ReadLine();     //Input for the switch
               
                
                switch (input)
                {
                    
                    case "Help": case"help": case "?":

                        Console.WriteLine(@"List of available commands: 1. Load
                            2. Add
                            3. Remove
                            4. Update
                            5. ls");
                        break;





                    case "Load": case "load": case "1":
                        Console.Clear();
                        StreamReader sr = new StreamReader("TextFile1.txt");
                        dataList.Clear();
                        for (string sor = sr.ReadLine(); sor != null; sor = sr.ReadLine()) // Reads all rows from "TextFile1.txt" 
                        {                                                                  // and puts them into the dataList
                            dataList.Add(new GameData(sor));                               // as an instance of GameData
                        }
                        sr.Close();
                        Console.WriteLine("Successfully loaded.");
                        break;


                        
                    
                    case "Add": case "add": case"2":
                    {
                            Console.Clear();
                            Console.WriteLine("Format: Name;Developer;Publisher");
                            dataList.Add(new GameData(Console.ReadLine()));             //Creates a new instance of GameData for the input and puts it into the dataList.                        
                            i++;
                            Console.Clear();
                            Console.WriteLine("Added"); 
                       }
                        break;




                    case "Remove": case"remove": case"3":
                        Console.Clear();
                        Console.WriteLine("At which index would you like to remove an instance?");
                        removeAtInput = Console.ReadLine();
                        
                        dataList.RemoveAt(int.Parse(removeAtInput));
                        Console.WriteLine("Removed the " + removeAtInput + ". ");
                        break;




                    case "Update": case"update": case"4":
                        Console.Clear();
                        Console.WriteLine("At which index would you like to update the instance?");
                        removeAtInput = Console.ReadLine();
                        dataList.RemoveAt(int.Parse(removeAtInput));
                        Console.WriteLine("Type in the new elements");
                        dataList.Insert(int.Parse(removeAtInput), new GameData(Console.ReadLine()));
                        Console.WriteLine("Updated");
                        break;




                    case "ls": case "5": case "Ls":
                        Console.Clear();
                        for (int j = 0; j < dataList.Count; j++)
                        {
                            Console.WriteLine(j + ". " + dataList[j]);
                        }
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a valid command or a it's corresponding number.");
                        Console.WriteLine(@"List of available commands: 1. Load
                            2. Add
                            3. Remove
                            4. Update
                            5. ls");
                        break;



                        /* case "asd":

                       

                        break;
                        */
                        
                }
            }
        }       
    }

}
