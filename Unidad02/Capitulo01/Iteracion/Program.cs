// See https://aka.ms/new-console-template for more information
string[] arrayString; 
arrayString = new string[5];
int cantIteraciones = 5;
for (int i = 0; i < cantIteraciones; i++)
{
    Console.WriteLine($"\nstring {i+1}: ");
    arrayString[i] = Console.ReadLine();
}
for (int i = cantIteraciones-1; i >= 0; i--) {
    Console.WriteLine($"\nEn la pos{i+1}: {arrayString[i]}");
}
