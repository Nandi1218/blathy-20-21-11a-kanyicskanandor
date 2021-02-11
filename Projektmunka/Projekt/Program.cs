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
            List<Adatok> adat = new List<Adatok>();
            int i = 0;
            while (i <3) 
            {
                adat.Add(new Adatok(Console.ReadLine()));
                i++;
            }

            adat.RemoveAt(1);
            for (int j = 0; j < adat.Count; j++)
            {
                Console.WriteLine(adat[j]);
            }
           
            Console.ReadKey();
        }       
    }

}
