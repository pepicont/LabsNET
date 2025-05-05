using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero): base(maxNumero) {
            //acá es necesario poner base con el parámetro para decir que es el mismo
        }
        public void Comparar(int nro) {
            if (nro - Numero > 100)
                Console.WriteLine("\nEl número ingresado es mayor y está muy lejos");
            if (nro - Numero<=5)
                Console.WriteLine("\nEl número ingresado está a 5 números o menos de distancia");
        }
    }
}
