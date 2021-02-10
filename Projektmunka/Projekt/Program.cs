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

            
            string line;
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\Nándi\Documents\GitHub\blathy_20_11a_kanyicskanandor\file.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words;
                words = line.Split(';');
                Adatok current = new Adatok();
                current.Name = words[0];
                current.Price  = double.Parse(words[1]);
                current.NumberRemaining = int.Parse(words[2]);
            }
            file.Close();            
            Console.ReadKey();
        }       
    }

}
