// See https://aka.ms/new-console-template for more information
static async Task EscribirArchivoAsync(string ruta, string contenido) //método que pide
{
    await File.WriteAllTextAsync(ruta, contenido);
}

static async Task<string> LeerArchivoAsync(string ruta) //método que pide. devuelve un string
{
    // Si el archivo no existe, se lanza una excepción
    if (!File.Exists(ruta))
    {
        throw new FileNotFoundException("El archivo no fue encontrado.", ruta);
    }

    return await File.ReadAllTextAsync(ruta); //devuelve una vez que se termine el resultado del file.ReadAllText....
}

//MAIN
string rutaArchivo = "datos.txt"; 
;
string contenido = "Este es el contenido escrito de forma asíncrona.";

try
{
    // Escribir contenido al archivo
    await EscribirArchivoAsync(rutaArchivo, contenido);
    Console.WriteLine("Archivo escrito exitosamente.\n");

    // Leer contenido desde el archivo
    string contenidoLeido = await LeerArchivoAsync(rutaArchivo);
    Console.WriteLine("Contenido leído del archivo:");
    Console.WriteLine(contenidoLeido);
}
catch (FileNotFoundException ex) //excepcion arrojada por LeerArchivo
{
    Console.WriteLine($"Error: El archivo no existe. Detalles: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error inesperado: {ex.Message}");
}

// Simular que el archivo no existe
Console.WriteLine("\nSimulando lectura de archivo inexistente...");
try
{
    string noExiste = await LeerArchivoAsync("archivo_que_no_existe.txt");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("Archivo no encontrado al intentar leer 'archivo_que_no_existe.txt'");
}