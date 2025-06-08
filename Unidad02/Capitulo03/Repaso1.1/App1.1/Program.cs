// See https://aka.ms/new-console-template for more information
/*Crear una solución llamada LabStrings y un proyecto consola llamado TransformadorDeTexto.

Pedir al usuario cuántas frases quiere ingresar (validar > 0).

Guardar las frases en un array de string.

Mostrar un menú con las siguientes opciones:

    1: Mostrar todas las frases en mayúsculas.

    2: Mostrar todas las frases con las palabras ordenadas alfabéticamente.

    3: Mostrar cuántas palabras tienen más de 5 letras en total.

    ESC: Salir del programa.

Usar un ciclo con Console.ReadKey(true) y switch para controlar la navegación del menú.

Cada opción debe estar implementada en un método diferente.*/

Console.WriteLine("Cuántas frases desea ingresar?");
int cantFrases = int.Parse(Console.ReadLine());

string[] palabras = new string[cantFrases];
for (int i = 0; i < cantFrases; i++) {
    Console.WriteLine($"Ingrese la palabra {i + 1}");
    palabras[i] = Console.ReadLine();
}
ConsoleKeyInfo opc;
while (true)
{
    Console.WriteLine("\nElija una de las opciones:\n1.Mostrar todas las frases en mayúsculas\n2.Mostrar" +
        " todas las frases ordenadas alfabéticamente\n3.Mostrar cuántas palabras tienen más de 5 letras en total\n0. Salir del programa");

    opc = Console.ReadKey();

    switch (opc.KeyChar) {
        case '1':
            foreach (string palabra in palabras) {
                Console.WriteLine($"\n{palabra.ToUpper()}");
            }
            break;

        case '2':
            string [] palabrasAux= palabras.Order().ToArray();
            foreach (string palabra in palabrasAux) {
                Console.WriteLine($"\n{palabra}");
            }
            break;

        case '3':
            int cant = 0;
            foreach (string palabra in palabras) {
                if (palabra.Count() > 5)
                    cant++;
            }
            Console.WriteLine($"{cant} palabras tienen más de 5 letras");
            break;

        case '0':
            Console.WriteLine("\nSaliendo del programa...");
            return;
            
    }


}