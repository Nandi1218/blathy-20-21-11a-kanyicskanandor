GameData osztály
string name, string developer, string publisher mezői vannak.
Képes txt-ből adatokat felvenni.



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
