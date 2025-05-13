// See https://aka.ms/new-console-template for more information
/*3) Dado un ArrayList que incluya al menos 10 Ciudades de Argentina incluyendo Nombre y Código
Postal usar LINQ para obtener y mostrar por Consola el Código Postal de aquellas ciudades que
incluyan dentro de su nombre una expresión de busqueda de tres caracteres, sin respetar
mayusculas o minusculas. Por ejemplo, si se ingresa “ros” y el ArrayList incluye Rosario entonces
debe mostrarse el Código Postal de Rosario.*/

using System.Collections;
using App3;

// Inicialización de ciudades
Ciudad ciudad1 = new Ciudad("Buenos Aires", "C1000");
Ciudad ciudad2 = new Ciudad("Córdoba", "X5000");
Ciudad ciudad3 = new Ciudad("Rosario", "S2000");
Ciudad ciudad4 = new Ciudad("Mendoza", "M5500");
Ciudad ciudad5 = new Ciudad("La Plata", "B1900");
Ciudad ciudad6 = new Ciudad("San Miguel de Tucumán", "T4000");
Ciudad ciudad7 = new Ciudad("Mar del Plata", "B7600");
Ciudad ciudad8 = new Ciudad("Salta", "A4400");
Ciudad ciudad9 = new Ciudad("Santa Fe", "S3000");
Ciudad ciudad10 = new Ciudad("San Juan", "J5400");

// Inicializamos y agregamos a la ArrayList
ArrayList ciudades = new ArrayList();
ciudades.Add(ciudad1);
ciudades.Add(ciudad2);
ciudades.Add(ciudad3);
ciudades.Add(ciudad4);
ciudades.Add(ciudad5);
ciudades.Add(ciudad6);
ciudades.Add(ciudad7);
ciudades.Add(ciudad8);
ciudades.Add(ciudad9);
ciudades.Add(ciudad10);

//task
Console.WriteLine("Favor de ingresar nombre parcial a buscar de una ciudad");
string busqueda = Console.ReadLine().ToLower();

var ciudadesCondicion = ciudades.Cast<Ciudad>()
    .Where(c => c.Nombre.ToLower().Contains(busqueda))
    .Select(c=> c.CodPostal);
//el cast es porque en el ArrayList se convierten en object
//sintaxis var coleccionNueva= colecion.Cast<Clase>().Where(condicion).Select(que quiero)

Console.WriteLine($"los códigos postales que coinciden con lo ingresado: {busqueda} son: ");
foreach (string codpostal in ciudadesCondicion) {
    Console.WriteLine(codpostal);
}

