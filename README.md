GameData osztály.
String name, string developer, string publisher mező vannak benne.
Listában vannak eltárolva a példányok.


WPF-ben:

A  program a mostani helyzetében az input stringet feldarabolja a ';' -nél akkor, ha legalább 2 van benne és a string vége nem ';', és az így kapott substringeket beleteszi a saját listájukba/ListBoxukba (Name, Developer, Publisher).

- [x] Adatkötés
- [x] Commandokkal való vezérlés
- [x] Add 
- [x] Clear   



```c#
    string[] temp = Input.Split(';');

            GameName.Add(temp[0]);
            Developer.Add(temp[1]);
            Publisher.Add(temp[2]);
            Input = "";
            
            
            char c = ';';
            if (!string.IsNullOrWhiteSpace(Input) && !(Input.Last() == c))
            {
                if ((Regex.Matches(Input, ";").Count) == 2)
                {
                    return true;
                }
```




ConsoleAppban:
Képes txt-ből adatokat felvenni.
- [x] Add
- [x] Remove
- [x] Update
- [x] Load
- [x] List out
- [ ] Save



Bónusz munka [videó](https://youtu.be/dQw4w9WgXcQ)
