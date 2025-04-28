// See https://aka.ms/new-console-template for more information
using System;
using Clases;

Console.WriteLine("Ingrese la opción que guste:\n1.Construir una persona\n2.Destruir una persona\n3.GetFullName\n0.Salir");
ConsoleKeyInfo opc = Console.ReadKey();
Persona persona = null;
while (opc.KeyChar != '0')
{
    switch (opc.KeyChar)
    {
        case '1':
            Console.WriteLine("\nIngrese el nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la edad");
            int edad = int.Parse(Console.ReadLine() ?? "0"); //buena práctica
            Console.WriteLine("Ingrese el dni");
            string dni = Console.ReadLine();

            persona = new Persona(nombre, apellido, edad, dni);
            break;

        case '2':
            Console.WriteLine("\nFuncionalidad para destruir una persona implementada pero no puede ser llamada");
            break;

        case '3':
            persona.GetFullName();
            break;

        default:
            Console.WriteLine("\nOpción no válida. Intente nuevamente.");
            break;
    }

    Console.WriteLine("\nIngrese la opción que guste:\n1.Construir una persona\n2.Destruir una persona\n3.GetFullName\n0.Salir");
    opc = Console.ReadKey();
}
