// See https://aka.ms/new-console-template for more information
using Clases;

B b = new B();
A a = b; /*Creo un objeto de la clase A pero que ahora apunta a b. Permite código genérico. Objeto de la clase hija tratado como una variable de la Padre */
//viceversa no se puede, porque B hereda de A
a.F(); //ejecuta método de A
b.F(); //ejecuta método de B (por el new)
a.G(); //ejecuta método de B (por el virtual)
b.G(); //ejecuta método de B (por el override) que sobreescribe este ^

//conclusión, si no es ni virtual ni override, manda el tipo de variable
//si es virtual y override, polimorfismo real
Console.ReadKey();
