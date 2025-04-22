using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class B : A
    {
        public void M4() {
            Console.WriteLine("Metodo del hijo Invocado");
        }
        /*public B() { haciendo esto, redefino el método por default de A
            NombreInstancia = "Instancia de B"; 
        }*/
        /*pero la consigna pide que al constructor de A con parámetro, se le pase como
        parámnetro "instancia de B"
         */
        public B() : base("Instancia de B") {
        } //acá la palabra base hace que se llame al constructor con parámetro base de A con el parámetro "instanc...."
    
    
    }

}
