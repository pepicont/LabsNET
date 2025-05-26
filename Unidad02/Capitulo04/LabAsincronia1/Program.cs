// See https://aka.ms/new-console-template for more information
//FUNCIONES PEDIDAS
using System.Diagnostics;
using System.Net.NetworkInformation;

static void SimularOperacionPesada() {
    Thread.Sleep(3000);
}

static async Task SimularOperacionPesadaAsync()
{
    await Task.Delay(3000);
}

static async Task CompararSincronoVsAsincrono() {
    Console.WriteLine("Ejecutando método sincrónico"); //sincrono
    Stopwatch sw = Stopwatch.StartNew();
    SimularOperacionPesada();
    sw.Stop();
    Console.WriteLine($"La ejecución duró {sw.ElapsedMilliseconds} milisegundos");

    Console.WriteLine("Ejecutando método asincrono");
    sw.Restart();
    Task Asincrono = SimularOperacionPesadaAsync();
    Console.WriteLine("Escribi algo si querés");
    Console.ReadLine();
    await Asincrono;
    sw.Stop();
    Console.WriteLine($"\nLa tarea asincrona ha durado {sw.ElapsedMilliseconds} milisegundos");
}
//MAIN

CompararSincronoVsAsincrono();

/*Preguntas y rtas
¿Qué ventajas observás en el uso del código asincrónico?

Proporciona una mejor UX porque al ejecutarse no bloquea la consola como el método sincrónico, esto resulta ser un caso sencillo
pero en una lectura de disco u otro I/0 Bound puede llegar a ser crucial y el usuario podría asustarse o disgustarse con este
resultado.

¿Qué inconvenientes podría tener si el código asincrónico no se maneja adecuadamente?

Se puede tornar dificultoso a la hora de depurar el código o usar estructuras de control con múltiples tareas asincronas.
En definitiva, se torna dificil el código cuando esté requiere asincronia compleja.
 */
