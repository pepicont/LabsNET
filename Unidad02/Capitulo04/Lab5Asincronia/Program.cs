
static async Task OperacionCancelableAsync(CancellationToken token)
{
    bool fueCancelado = false;
  for (int i = 0; i < 10; i++)
    {
           try
            {
                await Task.Delay(1000, token); //las tasks pueden ser cancelables y se les pasa el token de cancelación
                token.ThrowIfCancellationRequested(); //tira la excepcion si alguien canceló
                Console.WriteLine($"Paso {i + 1} completado.");
            if (i == 9) { fueCancelado = true; } //esto para el mensaje
            }
            catch (OperationCanceledException error)
            {
                Console.WriteLine($"\nSe ha capturado la excepción:\n{error.Message}");
                break;//en vez de break throw. se usa para mandarla a bloques superiores, que no se ejecute código que no queremos (ej try-catch en main)
            }
        }
    if (fueCancelado) { Console.WriteLine("Podes escribir pero ya no se cancela porque terminó"); }
    }

CancellationTokenSource cts = new CancellationTokenSource(); //se usa Can...Source porque por sí solo sin ..Source no anda el token

Task operacion = OperacionCancelableAsync(cts.Token); //se accede al token con .Token //Eso de asignar operacion para poder dejarla en 2do plano mientras sigue abajo
Console.WriteLine("Presiona cualquier tecla para cancelar la operación...");
Console.ReadKey();
cts.Cancel();
await operacion;

/*
¿Qué sucede si no se utiliza un try-catch alrededor de la llamada asincrónica?
De la manera en la que lo realicé no ocurre nada. Sé que debería pasar algo, pero no es el caso
PREGUNTARLE ESTO AL PROFE: QUÉ DEBERÍA HABER OCURRIDO SI LLAMABA AL MÉTODO DE UN TRY EN EL MAIN Y UN CATCH DEBAJO PARA AGARRAR LA EXPECIÓN

¿Por qué es importante capturar las excepciones dentro del método asincrónico en lugar de hacerlo solo en Main?
 Capturar la excepción dentro del método asincrónico puede ayudar a mantener el control sobre el flujo del programa y recursos en uso. En el main
se pueden a llegar a perder excepciones si no se manejan adecuadamente

 */