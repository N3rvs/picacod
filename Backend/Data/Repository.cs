
namespace Backend.Data;
using Entidades;



public class Repository
{
    public static  List<People> People = new List<People>
    {
        new People()
        {
            Id = 1,
            Name = "Guille",
            Brithdate = new DateTime(1991, 12, 31)
        },   
        new People()
        {
            Id = 2,
            Name = "Pedro",
            Brithdate = new DateTime(1996, 07, 26)
        },  
        new People()
        {
            Id = 3,
            Name = "Carlos",
            Brithdate = new DateTime(1999, 01,04)
        }
    };
}

