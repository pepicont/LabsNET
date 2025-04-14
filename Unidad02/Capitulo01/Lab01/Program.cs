// See https://aka.ms/new-console-template for more information
Console.WriteLine("Por favor, ingrese un string: ");
string inputTexto = Console.ReadLine();

if (string.IsNullOrEmpty(inputTexto))
{
    Console.WriteLine("No ingresaste nada. Fin del programa");
}
else
{
    Console.WriteLine("Ingrese:\n" +
        "1. Convertir string a upper\n" +
        "2. Convertir string a lower\n" +
        "3. Calcular longitud del string");
    ConsoleKeyInfo opcion = Console.ReadKey();
    /*  if (opcion.Key == ConsoleKey.D1)
      { //si la info de tecla opcion = a la info del dígito 1
          Console.WriteLine(); //salto de línea
          Console.WriteLine(inputTexto.ToUpper());
      }
      else if (opcion.KeyChar == '2') //si el digito asociado a la tecla es igual a 2
      {
          Console.WriteLine($"\n{inputTexto.ToLower()}"); //otra manera de string+objetos en WriteLine
      }
      else if (opcion.KeyChar == '3') {
          Console.WriteLine($"\nPosee {inputTexto.Length} caracteres");    
      }
  }*/
    switch (opcion.KeyChar)
    {
        case '1':
            Console.WriteLine($"\n{inputTexto.ToUpper()}");
            break;

        case '2':
            Console.WriteLine($"\n{inputTexto.ToLower()}");
            break;

        case '3':
            Console.WriteLine($"\nPosee {inputTexto.Length} caracteres");
            break;
    }
}
