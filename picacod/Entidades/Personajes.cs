using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picacod.Entidades
{
    public class Personajes
    {
        public string? Name { get; set; }
        public string? Clase { get; set; }
        public int Nivel { get; set; }

        public override string ToString()
        {
            return $"Nombre:{Name} - Clase:{Clase} - Nivel:{Nivel}";
        }
    }
}
