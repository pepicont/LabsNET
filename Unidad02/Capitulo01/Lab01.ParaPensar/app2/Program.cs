// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un año para validad si es bisiesto: ");
int anio = int.Parse(Console.ReadLine() ?? "0");
if (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0)
{
    Console.WriteLine($"{anio} es bisiesto");
}
else Console.WriteLine($"{anio} no es bisiesto");