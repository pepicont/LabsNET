// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Ingrese cuantas iteraciones de la serie de Fibonacci desea ver: ");
int nros = int.Parse(Console.ReadLine() ?? "0");
int a = 1;
int b = 1;
int aux;
for (int i = 0; i < nros; i++)
{
    Console.WriteLine(a);
    aux = a;
    a = b;
    b = b + aux;
}


