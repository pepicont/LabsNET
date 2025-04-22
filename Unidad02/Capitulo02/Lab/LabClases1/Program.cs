// See https://aka.ms/new-console-template for more information
using Clases;
A instanciaA = new A("AAAAAAAAAAAAAH CON RAZON"); //con la expresión como NombreInstancia
B instanciaB = new B(); //con NombreInstancia "instancia de b"

instanciaA.MostrarNombre(); //llamo métodos de A
instanciaA.M1();
instanciaA.M2();
instanciaA.M3();

instanciaB.MostrarNombre(); //llamo métodos de B
instanciaB.M1();
instanciaB.M2();
instanciaB.M3();
instanciaB.M4();
/*Luego, la consigna pide cambiar propiedas y métodos a private y protected
 
 Primero: private -> solo accesible dentro de la misma clase
 Segundo: protected -> accesible dentro de la misma clase y clases derivadas

 Qué hubiese pasado (refiriendome a acceso a propiedas y msjs si cambio en A):
 Acceso(public), desdeMain(SI), desdeClaseB(SI)
 Acceso(protected), desdeMain(NO), desdeClaseB(SI)
 Acceso(private), desdeMain(NO), desdeClaseB(NO)
 */