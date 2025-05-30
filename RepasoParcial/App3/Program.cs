// See https://aka.ms/new-console-template for more information
/*2. Pedir al usuario cuántas palabras va a ingresar (validar > 0).
3. Guardarlas en un array.
4. Mostrar las palabras en orden inverso usando un `for` decreciente.*/

//MAIN
using System.Security.Cryptography;

Console.WriteLine("Ingrese la cantidad de palabras que desea almacenar o 0 para salir:");
int cantPalabras = int.Parse(Console.ReadLine());
if (cantPalabras != 0) {
    string[] array = new string[cantPalabras];
    for (int i = 0; i < cantPalabras; i++) {
        Console.WriteLine($"\n{i + 1}) Ingrese la palabra: ");
        array[i] = Console.ReadLine()?? "0";
    }
    Console.WriteLine("\nA continuación el print en orden inverso:");
    for (int i = 1; i <= cantPalabras; i++) {
        Console.WriteLine(array[cantPalabras-i]);
    }
}
    


