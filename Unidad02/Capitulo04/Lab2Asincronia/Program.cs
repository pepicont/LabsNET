// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
//las 3 operaciones asincronicas
static async Task OperacionMediaAsync() {
    Console.WriteLine("Ejecutando operacion media");
    await Task.Delay(2000);
    Console.WriteLine("Se ejecutó operacion media");
}

static async Task OperacionCortaAsync()
{
    Console.WriteLine("Ejecutando operacion corta");
    await Task.Delay(1000);
    Console.WriteLine("Se ejecutó operacion corta");
}

static async Task OperacionLargaAsync()
{
    Console.WriteLine("Ejecutando operacion larga");
    await Task.Delay(3000);
    Console.WriteLine("Se ejecutó operacion larga");
}
//metodo que ejecuta en paralelo
static async Task EjecutarTareasParalelasAsync()
{
    Stopwatch sw = Stopwatch.StartNew();
    Console.WriteLine("Se comenzaron a ejecutar las tareas en paralelo");
    await Task.WhenAll(
        OperacionCortaAsync(),
        OperacionMediaAsync(),
        OperacionLargaAsync()
    );
    sw.Stop();
    Console.WriteLine($"Se terminaron de ejecutar las tareas en paralelo en {sw.ElapsedMilliseconds} milisegundos");
}
//metodo que ejecuta secuencialmente
static async Task EjecutarTareasSincronicas()
{
    Stopwatch sw = Stopwatch.StartNew();
    Console.WriteLine("Se comenzaron a ejecutar las tareas en serie");
    await OperacionCortaAsync();
    await OperacionMediaAsync();
    await OperacionLargaAsync();
    sw.Stop();
    Console.WriteLine($"Se terminaron de ejecutar las tareas en serie en {sw.ElapsedMilliseconds} milisegundos");
}

//MAIN
await EjecutarTareasParalelasAsync();
Console.WriteLine("\n Ahora en serie:");
await EjecutarTareasSincronicas();

/*RTA A LA PREGUNTA:
LA DIFERENCIA DE TIEMPO BÁSICAMENTE ES EL DOBLE, SE TRATA DE 3MSEG PARA PARALELO Y 6MSEG EN SERIE
ESTO SE DEBE A QUE AL HACER EN PARALELO, TODAS ARRANCAN A CONTAR EL DELAY AL MISMO TIEMPO
MIENTRAS QUE EN SERIE ESTO NO PASA (CADA DELAY ARRANCA CUANDO TERMINA EL ANTERIOR)*/