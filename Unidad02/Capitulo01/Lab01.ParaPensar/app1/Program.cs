https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el primer valor para la suma: ");
int nro1 = int.Parse(Console.ReadLine() ?? "0"); //parse convierte el string en int
Console.WriteLine("Ingrese el segundo valor: ");
int nro2 = int.Parse(Console.ReadLine() ?? "0"); // ?? "0". Si ingresa null, se lee 0
int suma = nro1 + nro2;
Console.WriteLine($"El resultado de la suma de {nro1} y {nro2} es: {suma}");