// See https://aka.ms/new-console-template for more information
static async Task OperacionLargaConProgresoAsync(IProgress<int> progreso)
{
    int cant = 10;
    Console.WriteLine("Progreso:");
    for (int i = 1; i <= cant; i++)
    {
        await Task.Delay(500);
        progreso.Report(i * 10); //se llama a report (callback de WriteLine y se le pasa un valor 10...20...)
    }
}
//MAIN
IProgress<int> progreso = new Progress<int>(valor => Console.WriteLine($"{valor}%")); //valor sería i*10
await OperacionLargaConProgresoAsync(progreso);

//RTAS
/*
 1. Lo usaría cuando tengo procesos asincrónicos muy largos y quiero mostrar al usuario una constante retroalimentacion
de lo que está pasando con ese método.

2. le pregunté a chatgpt porque la verdad no tenía idea y me aclaró:
Usa IProgress<T> en escenarios con interfaces gráficas, múltiples hilos o tareas complejas donde quieras mantener seguridad de contexto e integridad de datos.
(además es + eficiente)

Usa Action<T> en situaciones simples, sin hilos múltiples ni requerimientos de sincronización.
 
 */