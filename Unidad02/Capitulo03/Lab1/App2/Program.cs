// See https://aka.ms/new-console-template for more information
//Crear un programa que acepte una lista de números, los almacene en un objeto del tipo List<int>
//y luego usando LINQ muestre por Consola aquellos que son mayores a 20.
var numero = "12";
List<int> lista = new List<int>();
while (numero != "exit") {
    Console.WriteLine("Por favor, ingrese un número o \"exit\" para salir");
    numero = Console.ReadLine();
    if (numero != "exit") {
        int numeroParse = int.Parse(numero);
        lista.Add(numeroParse);
    }
}

var numerosM20 = lista.Where(numero => numero > 20);

Console.WriteLine("\nAquellos mayores a 20 son: ");
foreach (int num in numerosM20) {
    Console.WriteLine($"{num}");
}