using System.Linq;

var names = new List<string>()
 {
     "Guille","Marco","Jarki","Indira","Edu"
 };


var nameResult =  from name in names
                  where name.Length > 4
                  orderby name
                  select name;
                  

foreach (var name in nameResult)
{
    Console.WriteLine(name);
}