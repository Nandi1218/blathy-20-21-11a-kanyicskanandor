using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
      public class Adatok : IComparable
      {
          public Adatok(string beSor)
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
              return this.name.CompareTo((obj as Adatok).name);
          }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", name, developer, publisher);
        }

    }
}
