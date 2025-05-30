// See https://aka.ms/new-console-template for more information
/*2.Pedir al usuario 3 números y guardarlos en un `List<int>`.
3. Mostrar menú con opciones:
    -A: Promedio.
    - B: Mayor número.
    -C: Números ordenados descendente.
4. Utilizar `switch (opcion.Key)` con `ConsoleKey.A`, `B` y `C`.*/
using System.Data;

//FUNCIONES
static float Promedio(int nro1, int nro2, int nro3) {
    float promedio = (float)(nro1 + nro2 + nro3) / 3;
    return promedio;
}
static int MasGrande(int nro1, int nro2, int nro3) {
    int[] array = new int[] {nro1,nro2,nro3 };
    int max = array.Max();
    return max;
} 
static string Ordenado(int nro1, int nro2, int nro3) {
    int[] array = { nro1, nro2, nro3 };
    int[] arrayOrdenado = array.OrderDescending().ToArray();
    string ordenado = String.Join(' ', arrayOrdenado);
    return ordenado;
    
}
//MAIN
Console.WriteLine("Ingrese el 1er número por favor:");
int nro1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el 2do número por favor:");
int nro2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el 3er número por favor:");
int nro3 = int.Parse(Console.ReadLine());

bool bandera = true;
while (bandera)
{
    Console.WriteLine("\nSeleccione una opción:\nA.Promedio\nB.Mayor número\nC.Números ordenados descendente\nD.Salir");
    ConsoleKeyInfo opc = Console.ReadKey();
    switch (opc.KeyChar) {
        case 'A':
            Console.WriteLine($"\nPromedio: {Promedio(nro1,nro2,nro3)}");
            break;

        case 'a':
            Console.WriteLine($"\nPromedio: {Promedio(nro1, nro2, nro3)}");
            break;
        
        case 'B':
            Console.WriteLine($"\nMayor número: {MasGrande(nro1, nro2, nro3)}");
            break;
        case 'b':
            Console.WriteLine($"\nMayor número: {MasGrande(nro1, nro2, nro3)}");
            break;
        case 'C':
            Console.WriteLine($"\nNúmeros ordenados:\n{Ordenado(nro1,nro2,nro3)}");
            break;
        case 'c':
            Console.WriteLine($"\nNúmeros ordenados:\n{Ordenado(nro1, nro2, nro3)}");
            break;
        case 'd':
            Console.WriteLine($"\nSaliendo...");
            bandera = false;
            break;
        case 'D':
            Console.WriteLine($"\nSaliendo...");
            bandera =false;
            break;

    }
}
