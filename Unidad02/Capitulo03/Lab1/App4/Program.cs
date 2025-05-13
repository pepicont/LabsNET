// See https://aka.ms/new-console-template for more information
/*Dada una List<Empleado> donde Empleado tiene las propiedades Id (int), Nombre (string),
Sueldo (decimal). Crear un programa que acepte dar de alta Empleados en esta lista y luego
muestre por Consola esta misma Lista ordenada por la propiedad Sueldo, tanto de manera
ascendente como descendente.*/
using App4; //para poder usar la clase Empleado


List<Empleado> lista = new List<Empleado>();

string nombre = "ejercicio4";
int i = 0;
while (nombre != "exit") {
    i++;
    Console.WriteLine("\nIngrese nombre del empleado a cargar o \"exit\" para salir: ");
    nombre = Console.ReadLine();
    if (nombre == "exit") break;
    Console.WriteLine("Ingrese el sueldo en decimales (con coma): ");
    float sueldo = float.Parse(Console.ReadLine());


    Empleado empleado = new Empleado(i, nombre, sueldo); //inicializo empleado con propiedades

    lista.Add(empleado); //agrego a la lista
}
    var ascendente = lista.OrderBy(e => e.Sueldo); //chatgpt decía de agregar ToList para convertirlo a lista (default devuele IEnumerable<T>)
    var descendente = lista.OrderByDescending(e => e.Sueldo);

    Console.WriteLine("\nOrdenado ascendentemente por el sueldo: ");
    foreach (Empleado emp in ascendente) {
        Console.WriteLine($"{emp.Id} {emp.Nombre} {emp.Sueldo:F2}");
    }

    Console.WriteLine("\nOrdenado descendentemente por el sueldo: ");
    foreach (Empleado emp in descendente)
    {
        Console.WriteLine($"{emp.Id} {emp.Nombre} {emp.Sueldo:F2}"); //:F2 formatea a 2 decimales en el print
    }





