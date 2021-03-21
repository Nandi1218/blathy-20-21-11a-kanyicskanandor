using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
      public class GameData : IComparable
      {
            public GameData(string beSor)
            {
                  string[] darabok = beSor.Split(';');
                  name = darabok[0];
                  developer = darabok[1];
                  publisher = darabok[2];
            }
            string name;
            string developer;
            string publisher;
          

            public int CompareTo(object obj)
            {
                return this.name.CompareTo((obj as GameData).name);
            }
            public override string ToString()
            {
                return string.Format("{0} {1} {2}", name, developer, publisher);
            }
            
      }
}
