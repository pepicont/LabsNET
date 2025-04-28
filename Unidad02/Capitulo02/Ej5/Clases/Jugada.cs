using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Jugada
    {
        public Boolean Adivino { get; set; }
        public int Intentos { get; set; }
        public int Numero { get; set; }
        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }
    }
}
