using picacod.Entidades;
using picacod.Generics;
using System.Text.Json;

var guille = new People()
{
	Name = "Guillermo",
	Age = 33
};

string json = JsonSerializer.Serialize(guille);
Console.WriteLine(json);


var miLista = new GuilleList<int>();
miLista.Add(2);
miLista.Add(3);
miLista.Add(4);
Console.WriteLine(miLista.GetElements());


//var list = "";
//foreach(var mi in miLista)
//{

//}



//var numbers = new MyList<int>(5);

var names = new MyList<string>(5);
names.Add("Guiilermo");
names.Add("Carlos");
names.Add("Leo");
names.Add("Lucas");
names.Add("Pedro");
names.Add("Frank");
Console.WriteLine(names.GetContent());

//var misPersonajes = new MyList<Personajes>(5);
//misPersonajes.Add(new Personajes()
//{
//    Name = "Genzai",
//    Clase = "Guerrero",
//    Nivel = 105
//}); 
//misPersonajes.Add(new Personajes()
//{
//    Name = "Deneikes",
//    Clase = "Asesino",
//    Nivel = 98
//}); 
//misPersonajes.Add(new Personajes()
//{
//    Name = "Rorutin",
//    Clase = "Mago",
//    Nivel = 105
//}); 
//misPersonajes.Add(new Personajes()
//{
//    Name = "FlechaDix",
//    Clase = "Arquero",
//    Nivel = 74
//});
//Console.WriteLine(misPersonajes.GetContent());

// Programacion  funcional se usa Ation cuando no retorna un valor

//var show = Show;

//Some(show, "Sr.Piton");
//void Show (string message)
//{
//    Console.WriteLine(message);
//}

//void Some (Action<string> fc,string message)
//{
//    Thread.Sleep(2000);
//    Console.WriteLine("Hola");
//    Thread.Sleep(1000);
//    fc(message);
//}

// Programacion  funcional se usa Fuction cuando se retorna un valor

//var show = Show;

//Some(show, ("Sr.Piton"));

//string  Show(string message)

//{
//    return message.ToUpper();   
//}

//void Some(Func<string,string> fc, string message)
//{
//    Thread.Sleep(2000);
//    Console.WriteLine("Hola");
//    Thread.Sleep(1000);
//    Console.WriteLine(fc(message));
//}

// Funcion Lambda

//Func<int,int, int>sub = (x, y) => x - y;
//sub(1, 2);
//Console.WriteLine(sub);

//Some((a, b) => a*b, 7);

//void Some (Func<int, int, int> f,int number)
//{
//    var result = f(number, number);
//    Console.WriteLine(result);
//}
var giveMessage = 1;
List<int> numbers = new List<int>();
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);

int myNumbers = 0;

foreach (var n in numbers)
{
	var message = 2 + 3 + 5+ n;
	myNumbers += message;
}
Console.WriteLine(giveMessage + myNumbers);

