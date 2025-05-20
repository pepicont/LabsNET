// See https://aka.ms/new-console-template for more information
/***Objetivo:** Reforzar uso de `ConsoleKey`, validación de input y estructuras de decisión.

**Duración:** 20 minutos

**Pasos:**

1. Crear un proyecto consola llamado `Ejercicio1`.
2. Pedir al usuario que ingrese una palabra clave para desbloquear un menú.
3. Si escribe la palabra "clave", salir del programa.
4. Mostrar menú:
    - 1: Invertir la palabra ingresada.
    - 2: Mostrar la palabra en formato “snake_case”.
    - 3: Mostrar la palabra reemplazando vocales por ‘*’.
5. Usar `Console.ReadKey()` y `if` anidados para validar la opción.*/

Console.WriteLine("Ingrese una palabra a modificar o \"clave\" para salir del programa:");
string palabra = Console.ReadLine().ToLower();
if (String.IsNullOrEmpty(palabra)) {
    palabra = "palabra vacía";
}

if (palabra != "clave")
{ //entra al programa
    while (true)
    {
        Console.WriteLine("\nSeleccione una opción:\n1.Invertir la palabra ingresada.\n2.Mostrar la palabra en formato \"snake_case\"\n" +
        "3.Mostrar la palabra reemplazando vocales por \"*\"\n0.Para salir");
        ConsoleKeyInfo opc = Console.ReadKey(); //lee la letra ingresada
        if (opc.KeyChar == '1')
        {
            string reemplazada = new string(palabra.Reverse().ToArray());
            Console.WriteLine();
            Console.WriteLine(reemplazada);

        }
        if (opc.KeyChar == '2') 
        {
            string reemplazada = palabra.Replace(' ','_');
            Console.WriteLine();
            Console.WriteLine(reemplazada);
        }
        if (opc.KeyChar == '3')
        {
            string reemplazada = palabra.Replace('a', '*').Replace('e', '*').Replace('i', '*').Replace('o', '*').Replace('u', '*');
            Console.WriteLine();
            Console.WriteLine(reemplazada);
        }
        if (opc.KeyChar == '0')
        {
            Console.WriteLine();
            Console.WriteLine("Saliendo chauuuu!");
            break;
        }
    }
}


